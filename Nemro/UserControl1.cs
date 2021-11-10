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
    public partial class UserControl1 : UserControl
    {

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        //SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\nemro.mdf;Integrated Security=True;User Instance=True");
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename='E:\Project Files\C#\Nemro\Nemro\nemro.mdf';Integrated Security=True;User Instance=True");

        //Search Customer data from the database
        public void search()
        {
            //data select from Customer Table
            Connection.conn.Open();
            SqlCommand cmd = Connection.conn.CreateCommand();
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
                    txtName.Text = (dr["Name"].ToString());
                    txtAddress.Text = (dr["Address"].ToString());
                    txtTp.Text = (dr["Tp"].ToString());
                    comboBoxType.Text = (dr["Type"].ToString());
                }
                else
                {
                    //clear Username and Password TextBoxes
                    reset();
                }
            }
            //     DisData.DataSource = dt;
            Connection.conn.Close();
        }
        //Getdata Function
        public void dataget()
        {
            Connection.conn.Open();
            SqlCommand cmd = Connection.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT CusId from Customer ORDER BY CusId ASC";
            SqlDataReader daa = cmd.ExecuteReader();
            while (daa.Read())
            {
                String data = daa.GetValue(0).ToString();
                MyGlobal.datain = Convert.ToInt32(data);
                lblCustomer.Text = MyGlobal.datain.ToString();
            }
            Connection.conn.Close();
        }

        //Reset Function
        public void reset()
        {
            //clear texts
            txtId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtTp.Text = "";
            comboBoxType.Text = "";
            //Clear DataGrid
            DisData.Rows.Clear();
        }

        //Calculate Total Fro Add to datagrid
        private void datagridsum()
        {
            int x, y, z;

            for (int i = 0; i < DisData.Rows.Count - 1; i++)
            {
                x = Convert.ToInt32(DisData.Rows[i].Cells[2].Value);
                y = Convert.ToInt32(DisData.Rows[i].Cells[3].Value);
                z = x * y;
                DisData.Rows[i].Cells[4].Value = z;
            }
        }

        //Total Function
        public void Total()
        {
            int sum = 0;
            for (int i = 0; i < DisData.Rows.Count - 1; i++)
            {
                sum += Convert.ToInt32(DisData.Rows[i].Cells[4].Value);
            }
            MyGlobal.sumint = sum;
            MyGlobal.sumstr = sum.ToString();
            lblTotal.Text = (MyGlobal.sumstr);
            //MessageBox.Show(MyGlobal.sumstr);
            lblTotal.Text = (MyGlobal.sumstr);
        }

        public void Balance()
        {
            Connection.conn.Open();
            SqlCommand cmd = Connection.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Balance FROM Customer WHERE CusId = '" + txtId.Text + "'";
            SqlDataReader da1 = cmd.ExecuteReader();
            while (da1.Read())
            {
                String bal = da1.GetValue(0).ToString();
                //MessageBox.Show(bal);
                MyGlobal.balance = Convert.ToInt32(bal);
                MyGlobal.balance = MyGlobal.balance + MyGlobal.sumint;
                MyGlobal.balancestr = MyGlobal.balance.ToString();
                //MessageBox.Show(MyGlobal.balancestr);
            }
            Connection.conn.Close();
        }

        //convert date to String Value and save in a Global Variable
        public void datetime()
        {
            MyGlobal.today = Convert.ToString(dtpicker);
            MessageBox.Show(MyGlobal.today);
        }

        //Paid Function
        public void Paid()
        {
            Connection.conn.Open();
            String query1 = "INSERT INTO Paid (CusId,Amount,Date) VALUES ('" + MyGlobal.datain + "','" + MyGlobal.sumstr + "','" + dtpicker.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query1, Connection.conn);
            sda.SelectCommand.ExecuteNonQuery();
            Connection.conn.Close();
        }

        //Unpaid Function
        public void Unpaid()
        {
            Connection.conn.Open();
            String query2 = "INSERT INTO Unpaid (CusId,Amount,Date) VALUES ('" + MyGlobal.datain + "','" + MyGlobal.sumstr + "','" + dtpicker.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query2, Connection.conn);
            sda.SelectCommand.ExecuteNonQuery();
            Connection.conn.Close();
        }

        //Cash Function
        public void Cash()
        {
            if (ckboxCus.Checked == true)
            {
                int balance = 0;
                //Enter data to Customer Table 
                Connection.conn.Open();
                String query3 = "INSERT INTO Customer (Name,Address,Tp,Type,Date,Balance,LastUpdate) VALUES ('" + txtName.Text + "','" + txtAddress.Text + "','" + txtTp.Text + "','" + comboBoxType.Text + "','" + dtpicker.Text + "','" + balance + "','" + dtpicker.Text + "')";
                SqlDataAdapter sda1 = new SqlDataAdapter(query3, Connection.conn);
                sda1.SelectCommand.ExecuteNonQuery();
                Connection.conn.Close();

                //Dis_Data();

                /*
                Connection.conn.Open();
                SqlCommand cmd = Connection.conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Id from Customer ORDER BY Id DESC";
                SqlDataReader daa = cmd.ExecuteReader();
                while (daa.Read())
                {
                    String data = daa.GetValue(0).ToString();
                    int datain = Convert.ToInt32(data);
                }
                Connection.conn.Close();
                */

                dataget();

                //Enter data to Daily table
                for (int i = 0; i < DisData.Rows.Count - 1; i++)
                {
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO Daily (Item,Reason,Quantity,Price,TotalPrice,Id ) VALUES ('" + DisData.Rows[i].Cells[0].Value + "','" + DisData.Rows[i].Cells[1].Value + "','" + DisData.Rows[i].Cells[2].Value + "','" + DisData.Rows[i].Cells[3].Value + "','" + DisData.Rows[i].Cells[4].Value + "','" + MyGlobal.datain + "')", Connection.conn);

                    Connection.conn.Open();
                    cmd2.ExecuteNonQuery();
                    Connection.conn.Close();
                    label6.Text = "Inserted Successfully!";
                }
                //reset();


            }
            else
            {
                //Enter data to Customer Table 
                Connection.conn.Open();
                String query4 = "UPDATE Customer SET LastUpdate = '" + dtpicker.Text + "' WHERE CusId= '" + txtId.Text + "'";
                SqlDataAdapter sda2 = new SqlDataAdapter(query4, Connection.conn);
                sda2.SelectCommand.ExecuteNonQuery();
                Connection.conn.Close();

                //Enter data to Daily table
                for (int i = 0; i < DisData.Rows.Count - 1; i++)
                {
                    SqlCommand cmd7 = new SqlCommand("INSERT INTO Daily (Item,Reason,Quantity,Price,TotalPrice,Id ) VALUES ('" + DisData.Rows[i].Cells[0].Value + "','" + DisData.Rows[i].Cells[1].Value + "','" + DisData.Rows[i].Cells[2].Value + "','" + DisData.Rows[i].Cells[3].Value + "','" + DisData.Rows[i].Cells[4].Value + "','" + MyGlobal.datain + "')", Connection.conn);

                    Connection.conn.Open();
                    cmd7.ExecuteNonQuery();
                    Connection.conn.Close();
                    label6.Text = "Inserted Successfully!";
                }
                //reset();
            }
        }

        //Credit Function
        public void Credit()
        {
            if (ckboxCus.Checked == true)
            {
                //Enter data to Customer Table 
                Connection.conn.Open();
                String query5 = "INSERT INTO Customer (Name,Address,Tp,Type,Date,Balance,LastUpdate) VALUES ('" + txtName.Text + "','" + txtAddress.Text + "','" + txtTp.Text + "','" + comboBoxType.Text + "','" + dtpicker.Text + "','" + MyGlobal.sumstr + "','" + dtpicker.Text + "')";
                SqlDataAdapter sda3 = new SqlDataAdapter(query5, Connection.conn);
                sda3.SelectCommand.ExecuteNonQuery();
                Connection.conn.Close();

                //Dis_Data();
                dataget();

                //Enter data to Daily table
                for (int i = 0; i < DisData.Rows.Count - 1; i++)
                {
                    SqlCommand cmd3 = new SqlCommand("INSERT INTO Daily (Item,Reason,Quantity,Price,TotalPrice,Id ) VALUES ('" + DisData.Rows[i].Cells[0].Value + "','" + DisData.Rows[i].Cells[1].Value + "','" + DisData.Rows[i].Cells[2].Value + "','" + DisData.Rows[i].Cells[3].Value + "','" + DisData.Rows[i].Cells[4].Value + "','" + MyGlobal.datain + "')", Connection.conn);

                    Connection.conn.Open();
                    cmd3.ExecuteNonQuery();
                    Connection.conn.Close();
                    label6.Text = "Inserted Successfully!";
                }
                //reset();


            }
            else
            {

                //Enter data to Customer Table 
                Connection.conn.Open();
                String query6 = "UPDATE Customer SET Balance = '" + MyGlobal.balancestr + "', LastUpdate =  '" + dtpicker.Text + "' WHERE CusId= '" + txtId.Text + "'";
                SqlDataAdapter sda4 = new SqlDataAdapter(query6, Connection.conn);
                sda4.SelectCommand.ExecuteNonQuery();
                Connection.conn.Close();

                //Dis_Data();
                dataget();

                //Enter data to Daily table
                for (int i = 0; i < DisData.Rows.Count - 1; i++)
                {
                    //Add data + price

                    SqlCommand cmd4 = new SqlCommand("INSERT INTO Daily (Item,Reason,Quantity,Price,TotalPrice,Id ) VALUES ('" + DisData.Rows[i].Cells[0].Value + "','" + DisData.Rows[i].Cells[1].Value + "','" + DisData.Rows[i].Cells[2].Value + "','" + DisData.Rows[i].Cells[3].Value + "','" + DisData.Rows[i].Cells[4].Value + "','" + MyGlobal.datain + "')", Connection.conn);

                    Connection.conn.Open();
                    cmd4.ExecuteNonQuery();
                    Connection.conn.Close();
                    label6.Text = "Inserted Successfully!";
                }
                //reset();
            }
            //Enter data to Daily table
            for (int i = 0; i < DisData.Rows.Count - 1; i++)
            {
                SqlCommand cmd5 = new SqlCommand("INSERT INTO Daily (Item,Reason,Quantity,Price,TotalPrice,Id ) VALUES ('" + DisData.Rows[i].Cells[0].Value + "','" + DisData.Rows[i].Cells[1].Value + "','" + DisData.Rows[i].Cells[2].Value + "','" + DisData.Rows[i].Cells[3].Value + "','" + DisData.Rows[i].Cells[4].Value + "','" + MyGlobal.datain + "')", Connection.conn);

                Connection.conn.Open();
                cmd5.ExecuteNonQuery();
                Connection.conn.Close();
                label6.Text = "Inserted Successfully!";
            }
            //reset();
        }

        //get data in to datadrid
        public void Dis_Data()
        {

            Connection.conn.Open();
            SqlCommand cmd = Connection.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Customer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DisData.DataSource = dt;
            Connection.conn.Close();

        }


        private void DisData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public DateTime data { get; set; }

        public string datain { get; set; }


        private void btnSum_Click(object sender, EventArgs e)
        {
            Total();
            datagridsum();
            Balance();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataget();
            search();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            Cash();
            Paid();
            dataget();
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            dataget();
            Credit();
            Unpaid();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataget();
            reset();
        }
    }
}

public static class MyGlobal
{
    public static int datain;
    public static int sumint;
    public static String sumstr;
    public static String balancestr;
    public static int balance = 0;
    public static String today;
}