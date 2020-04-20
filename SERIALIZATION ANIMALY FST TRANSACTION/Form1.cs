using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERIALIZATION_ANIMALY_FST_TRANSACTION
{
    public partial class Form1 : Form
    {
        DataTable datasource_for_dgv = new DataTable();
        private static readonly string _sConnStr = new NpgsqlConnectionStringBuilder
        {
            Host = "localhost",
            Port = 5432,
            Database = "normalisation",
            Username = Environment.GetEnvironmentVariable("POSTGRESQL_USERNAME"),
            Password = Environment.GetEnvironmentVariable("POSTGRESQL_PASSWORD"),
            AutoPrepareMinUsages = 2,
            MaxAutoPrepare = 10
        }.ConnectionString;
        private static NpgsqlTransaction transaction;
        private static NpgsqlConnection sConn;
        private static NpgsqlCommand sCommand;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = datasource_for_dgv;
            using (var sConn = new NpgsqlConnection(_sConnStr))
            {
                sConn.Open();
                using (var sCommand = new NpgsqlCommand())
                {
                    sCommand.Connection = sConn;
                    sCommand.CommandText = "INSERT INTO branch (branch_address, branch_phone, branch_area, branch_working_hours) VALUES ('test', 'test', 100, 'test');";
                    sCommand.ExecuteNonQuery();
                }
            }
            btn_2.Enabled = btn_4.Enabled = false;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            btn_1.Enabled = btn_3.Enabled = false;
            btn_2.Enabled = true;

            sConn = new NpgsqlConnection(_sConnStr);
            sConn.Open();
            sCommand = new NpgsqlCommand();
            sCommand.Connection = sConn;
            transaction = sConn.BeginTransaction(IsolationLevel.RepeatableRead);
            sCommand.Transaction = transaction;
            sCommand.CommandText = "UPDATE branch SET branch_area = branch_area+100; SELECT * FROM branch;";
            datasource_for_dgv.Clear();
            datasource_for_dgv.Load(sCommand.ExecuteReader());
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            btn_2.Enabled = false;
            btn_4.Enabled = true;
            sCommand.CommandText = "SELECT * FROM branch;";
            datasource_for_dgv.Clear();
            datasource_for_dgv.Load(sCommand.ExecuteReader());
            transaction.Rollback();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var sConn = new NpgsqlConnection(_sConnStr))
            {
                sConn.Open();
                using (var sCommand = new NpgsqlCommand())
                {
                    sCommand.Connection = sConn;
                    sCommand.CommandText = "DELETE FROM branch WHERE branch_address = 'test'";
                    sCommand.ExecuteNonQuery();
                }
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            btn_1.Enabled = btn_3.Enabled = false;
            btn_2.Enabled = true;

            sConn = new NpgsqlConnection(_sConnStr);
            sConn.Open();
            sCommand = new NpgsqlCommand();
            sCommand.Connection = sConn;
            transaction = sConn.BeginTransaction(IsolationLevel.Serializable);
            sCommand.Transaction = transaction;
            sCommand.CommandText = "SELECT * FROM branch;";
            datasource_for_dgv.Clear();
            datasource_for_dgv.Load(sCommand.ExecuteReader());
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            btn_4.Enabled = false;
            sConn = new NpgsqlConnection(_sConnStr);
            sConn.Open();
            sCommand = new NpgsqlCommand();
            sCommand.Connection = sConn;
            sCommand.CommandText = "SELECT * FROM branch;";
            datasource_for_dgv.Clear();
            datasource_for_dgv.Load(sCommand.ExecuteReader());
        }
    }
}
