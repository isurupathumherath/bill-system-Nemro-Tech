using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nemro
{
    public partial class CustomerSearch : Form
    {
        public CustomerSearch()
        {
            InitializeComponent();
        }

        private void CustomerSearch_Load(object sender, EventArgs e)
        {

        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NemroTech.mdf;Integrated Security=True;Connect Timeout=30");

        //get data in to datadrid
        public void Dis_Data()
        {

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Customer WHERE CusId = '" + txtId.Text + "' OR Name = '" + txtName.Text + "' OR Address = '" + txtAddress.Text + "' OR Tp = '" + txtTp.Text + "' OR Date = '" + dateTimePicker1.Text + "'";
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

    }
}
