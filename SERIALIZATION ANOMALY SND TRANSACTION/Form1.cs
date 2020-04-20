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

namespace SERIALIZATION_ANOMALY_SND_TRANSACTION
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
            btn_2.Enabled = false;
            dataGridView1.DataSource = datasource_for_dgv;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            btn_1.Enabled = false;
            btn_2.Enabled = true;
            sConn = new NpgsqlConnection(_sConnStr);
            sConn.Open();
            sCommand = new NpgsqlCommand();
            sCommand.Connection = sConn;
            transaction = sConn.BeginTransaction(IsolationLevel.RepeatableRead);
            sCommand.Transaction = transaction;
            sCommand.CommandText = "SELECT * FROM branch";
            datasource_for_dgv.Clear();
            datasource_for_dgv.Load(sCommand.ExecuteReader());
            //sCommand.Transaction = transaction;
            //sCommand.CommandText = "UPDATE branch SET branch_area = branch_area+150;";
            //try
            //{
            //    sCommand.ExecuteNonQuery();
            //}
            //catch (Exception excp)
            //{
            //    MessageBox.Show(excp.Message);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_2.Enabled = false;
            sConn = new NpgsqlConnection(_sConnStr);
            sConn.Open();
            sCommand = new NpgsqlCommand();
            sCommand.Connection = sConn;
            transaction = sConn.BeginTransaction(IsolationLevel.ReadCommitted);
            sCommand.Transaction = transaction;
            sCommand.CommandText = "INSERT INTO branch (branch_address, branch_phone, branch_area, branch_working_hours) VALUES ('test2', 'test2', 100, 'test2'); SELECT * FROM branch";
            datasource_for_dgv.Clear();
            datasource_for_dgv.Load(sCommand.ExecuteReader());
            transaction.Commit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var sConn = new NpgsqlConnection(_sConnStr))
            {
                sConn.Open();
                using (var sCommand = new NpgsqlCommand())
                {
                    sCommand.Connection = sConn;
                    sCommand.CommandText = "DELETE FROM branch WHERE branch_address = 'test2'";
                    sCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
