using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nemro
{
    public partial class Details1 : UserControl
    {
        public Details1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NemroTech.mdf;Integrated Security=True;Connect Timeout=30");

        public void search()
        {
            //DataGridViewCheckBoxColumn datacheck = new DataGridViewCheckBoxColumn();

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT VoId,CusId,Amount,Date,VoucherNo,VoucherDate FROM Paid WHERE (CusId = '" + txtId.Text + "' OR Date BETWEEN '"+ dateTimePicker1.Text+ "' AND '" + dateTimePicker1.Text + "') OR (Date = '"+dateTimePicker3.Text+"')";
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DisData.DataSource = dt;
            conn.Close();
        }

        public void all()
        {
            //DataGridViewCheckBoxColumn datacheck = new DataGridViewCheckBoxColumn();

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT VoId,CusId,Amount,Date,VoucherNo,VoucherDate FROM Paid";
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DisData.DataSource = dt;
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            all();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisData.DataSource = null;
            DisData.Columns.Clear();
            DisData.Rows.Clear();
            txtId.Text = "";
        }
    }
}
