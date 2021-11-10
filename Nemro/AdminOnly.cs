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
    public partial class Admin_Only : Form
    {
        public Admin_Only()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NemroTech.mdf;Integrated Security=True;Connect Timeout=30");


        public void todaytotal()
        {
            MessageBox.Show("Uder Constructing!");
            String paid = "paid";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TotalPrice FROM Daily WHERE Status = '" + paid + "' AND Date = '" + GlobalDate.date + "";
            cmd.CommandText = "SELECT Amount FROM Paid WHERE Date = '" + GlobalDate.date + "'";
            SqlDataReader da1 = cmd.ExecuteReader();

            int i = 0;
            while (da1.Read())
            {
                int Total = 0;
                String balance = da1.GetValue(i).ToString();
                int bal = Convert.ToInt32(balance);
                Total = Total + bal;
                i = i + 1;
                String TotalS = bal.ToString();
                MessageBox.Show(TotalS);
            }

            conn.Close();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            todaytotal();
        }

        private void Admin_Only_Load(object sender, EventArgs e)
        {

        }
    }
}
        
