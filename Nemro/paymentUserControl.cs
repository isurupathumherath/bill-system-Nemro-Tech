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
    public partial class paymentUserControl : UserControl
    {

        public paymentUserControl()
        {
            InitializeComponent();
        }

        private void paymentUserControl_Load(object sender, EventArgs e)
        {

        }

        
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NemroTech.mdf;Integrated Security=True;Connect Timeout=30");
        //SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename='E:\Project Files\C#\Nemro\Nemro\nemro.mdf';Integrated Security=True;User Instance=True");

        public void pay()
        {
            Connection.conn.Open();
            String query2 = "INSERT INTO paid (CusId,Amount,Date,VoucherNo,VoucherDate) VALUES ('" + txtId.Text + "','" + txtAmount.Text + "','" + dtpicker2.Text + "','" + txtVoucher.Text + "','" + dtpicker1.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query2, Connection.conn);
            sda.SelectCommand.ExecuteNonQuery();
            Connection.conn.Close();
        }


        //Reset Function
        public void reset()
        {
            //clear texts            
            lblName.Text = "";
            lblAddress.Text = "";
            lblTp.Text = "";
            lblType.Text = "";
            lblBalance.Text = "";
            txtAmount.Text = "";
            txtVoucher.Text = ""; 

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
            String query5 = "UPDATE Customer SET Balance = '" + MyGlobalPayment.balance + "', LastUpdate = '" + dtpicker2.Text + "' WHERE CusId = '" + txtId.Text + "'";
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

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            Search();
        }

        private void btnPay_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            //int cusid = Convert.ToInt32(txtId.Text);
            String paid = "paid";
            String query1 = "UPDATE Daily SET Status = '" + paid + "' WHERE Id = '" + txtId.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query1, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();

            pay();
            total();
            payment();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Selected_Payments lg = new Selected_Payments();
            lg.Show();
            //customerSearchUC1.BringToFront();
        }
    }
}

public static class MyGlobalPayment
{
    public static int balance = 0;
    public static String balan;
}