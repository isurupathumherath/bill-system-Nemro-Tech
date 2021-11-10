using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Nemro
{
    public partial class CustomerSearchUC : UserControl
    {
        public CustomerSearchUC()
        {
            InitializeComponent();
        }

        private void CustomerSearchUC_Load(object sender, EventArgs e)
        {

        }

        //OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\myFolder\myAccessFile.accdb;Persist Security Info=False;");
        
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NemroTech.mdf;Integrated Security=True;Connect Timeout=30");
        //SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename='E:\Project Files\C#\Nemro\Nemro\nemro.mdf';Integrated Security=True;User Instance=True");

        //get data in to datadrid
        public void Dis_Data()
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Customer WHERE CusId = '" + txtId.Text + "' OR Name = '" + txtName.Text + "' OR Address = '" + txtAddress.Text + "' OR Tp = '" + txtTp.Text + "' OR LastUpdate = '" + dateTimePicker1.Text + "' OR Type = '"+ comboBoxType.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Dis_Data();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
