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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NemroTech.mdf;Integrated Security=True;Connect Timeout=30");

        //Reset Function
        public void reset()
        {
            //clear texts
            txtAmount.Text = "";
            lblName.Text = "";
            lblAddress.Text = "";
            lblTp.Text = "";
            lblType.Text = "";
            lblBalance.Text = "";

        }

        public void Search()
        {
            //data select from Customer Table
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Customer WHERE CusId= '" + txtId.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //put data in text boxes 
                    txtId.Text = (dr["CusId"].ToString());
                    lblName.Text = (dr["Name"].ToString());
                    lblAddress.Text = (dr["Address"].ToString());
                    lblTp.Text = (dr["Tp"].ToString());
                    lblType.Text = (dr["Type"].ToString());
                    lblBalance.Text = (dr["Balance"].ToString());
                }
             else
                {
                    //clear Username and Password TextBoxes
                    reset();
                }
            }
            //     DisData.DataSource = dt;
            conn.Close();
        }

        //Total Balance
        public void total()
        {
            int amount;
            //String love;
            amount = Convert.ToInt32(txtAmount.Text);
            //love = Convert.ToString(amount);
            //MessageBox.Show(love);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Balance FROM Customer WHERE CusId = '" + txtId.Text + "'";
            SqlDataReader da1 = cmd.ExecuteReader();
            while (da1.Read())
            {
                String bal = da1.GetValue(0).ToString();
                //MessageBox.Show(bal); //cc
                MyGlobalPayment.balance = Convert.ToInt32(bal);      
                MyGlobalPayment.balance = MyGlobalPayment.balance - amount;

                MyGlobalPayment.balan = MyGlobalPayment.balance.ToString();
                //MessageBox.Show(MyGlobalPayment.balan); //cc
            }
            
            conn.Close();
        }

        public void updatecustomer()
        {
            //Update data to Customer Table 
            conn.Open();
            String query5 = "UPDATE Customer SET Balance = '" + MyGlobalPayment.balance + "', LastUpdate = '" + dateTimePicker1.Text + "' WHERE CusId = '" + txtId.Text + "'";
            SqlDataAdapter sda3 = new SqlDataAdapter(query5, conn);
            sda3.SelectCommand.ExecuteNonQuery();
            conn.Close();
        }

        //Payment Function
        public void payment()
        {
            

            if (checkBox1.Checked == true)
            {
                updatecustomer();
                reset();


            }
            else
            {
                updatecustomer();
                reset();
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            total();
            payment();
        }
    }
}