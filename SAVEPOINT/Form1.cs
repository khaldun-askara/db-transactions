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

namespace SAVEPOINT
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
                    sCommand.CommandText = "INSERT INTO branch (branch_address, branch_phone, branch_area, branch_working_hours) VALUES ('test', 'test', 100, 'test'); SELECT * FROM branch";
                    datasource_for_dgv.Clear();
                    datasource_for_dgv.Load(sCommand.ExecuteReader());
                }
            }
            btn_1000.Enabled = btn_2000.Enabled = false;
            btn_ROLLBACK.Enabled = btn_ROLLBACKTO.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = false;
            btn_1000.Enabled = btn_2000.Enabled = btn_ROLLBACK.Enabled = true;
            sConn = new NpgsqlConnection(_sConnStr);
            sConn.Open();
            sCommand = new NpgsqlCommand();
            sCommand.Connection = sConn;
            transaction = sConn.BeginTransaction(IsolationLevel.ReadCommitted);
            sCommand.Transaction = transaction;
            sCommand.CommandText = "UPDATE branch SET branch_phone = 'test2' WHERE branch_address = 'test'; SELECT* FROM branch;";
            datasource_for_dgv.Clear();
            datasource_for_dgv.Load(sCommand.ExecuteReader());
            transaction.Save("test2");
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            btn_1000.Enabled = btn_2000.Enabled = false;
            btn_ROLLBACK.Enabled = btn_ROLLBACKTO.Enabled = true;
            sCommand.CommandText = "UPDATE branch SET branch_area = 1000 WHERE branch_address = 'test'; SELECT* FROM branch;";
            datasource_for_dgv.Clear();
            datasource_for_dgv.Load(sCommand.ExecuteReader());
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            btn_1000.Enabled = btn_2000.Enabled = false;
            btn_ROLLBACK.Enabled = btn_ROLLBACKTO.Enabled = true;
            sCommand.CommandText = "UPDATE branch SET branch_area = 2000 WHERE branch_address = 'test'; SELECT* FROM branch;";
            datasource_for_dgv.Clear();
            datasource_for_dgv.Load(sCommand.ExecuteReader());
        }

        private void btnres1_Click(object sender, EventArgs e)
        {
            btn_1000.Enabled = btn_2000.Enabled = false;
            btn_ROLLBACK.Enabled = btn_ROLLBACKTO.Enabled = false;
            btn_start.Enabled = true;
            transaction.Rollback();
            using (var sConn = new NpgsqlConnection(_sConnStr))
            {
                sConn.Open();
                using (var sCommand = new NpgsqlCommand())
                {
                    sCommand.Connection = sConn;
                    sCommand.CommandText = "SELECT * FROM branch";
                    datasource_for_dgv.Clear();
                    datasource_for_dgv.Load(sCommand.ExecuteReader());
                }
            }
        }

        private void btnres2_Click(object sender, EventArgs e)
        {
            btn_ROLLBACKTO.Enabled = false;
            btn_1000.Enabled = btn_2000.Enabled = true;
            transaction.Rollback("test2");
            sCommand.CommandText = "SELECT * FROM branch";
            datasource_for_dgv.Clear();
            datasource_for_dgv.Load(sCommand.ExecuteReader());
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
    }
}
