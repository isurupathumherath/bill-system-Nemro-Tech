using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Nemro
{  
    public partial class NewBill : Form
    {
        public NewBill()
        {
            InitializeComponent();
        }




        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NemroTech.mdf;Integrated Security=True;Connect Timeout=30");

        //Search Customer data from the database
        public void search()
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
            conn.Close();
        }

        //Enter data to UnpaidInvoice table
        private void unpaidv()
        {
            for (int isuru = 0; isuru < DisData.Rows.Count - 1; isuru++)
            {
                /*

                conn.Open();
                String query15 = "INSERT INTO UnpaidInvoice (Item,Quantity,Price,TotalPrice,Id) VALUES ('" + DisData.Rows[isuru].Cells[0].Value + "','" + DisData.Rows[isuru].Cells[1].Value + "','" + DisData.Rows[isuru].Cells[2].Value + "','" + DisData.Rows[isuru].Cells[3].Value + "','" + MyGlobal.datain + "')";
                SqlDataAdapter sda3 = new SqlDataAdapter(query15, conn);
                sda3.SelectCommand.ExecuteNonQuery();
                conn.Close();

                
                SqlCommand cmd10 = new SqlCommand("INSERT INTO UnpaidInvoice (Item,Quantity,Price,TotalPrice,Id) VALUES ('" + DisData.Rows[isuru].Cells[0].Value + "','" + DisData.Rows[isuru].Cells[1].Value + "','" + DisData.Rows[isuru].Cells[2].Value + "','" + DisData.Rows[isuru].Cells[3].Value + "','" + MyGlobal.datain + "')", conn);
                conn.Open();
                cmd10.ExecuteNonQuery();
                conn.Close();
                label6.Text = "Inserted Successfully!";
                */
            }
        }

        //Getdata Function
        public void dataget()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT CusId from Customer ORDER BY CusId ASC"; 
            SqlDataReader daa = cmd.ExecuteReader();
            while (daa.Read())
            {
                String data = daa.GetValue(0).ToString();
                MyGlobal.datain = Convert.ToInt32(data);
                lblCustomer.Text = MyGlobal.datain.ToString();
            }
            conn.Close();
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
                sum+= Convert.ToInt32(DisData.Rows[i].Cells[5].Value);
            }
            MyGlobal.sumint = sum;
            MyGlobal.sumstr = sum.ToString();
            //MessageBox.Show(MyGlobal.sumstr);
            lblTotal.Text = (MyGlobal.sumstr);
        }

        public void Balance()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand(); 
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Balance FROM Customer WHERE CusId = '"+txtId.Text+"'";
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
            conn.Close();
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
            conn.Open();
            String query1 = "INSERT INTO Paid (CusId,Amount,Date) VALUES ('" + MyGlobal.datain + "','" + MyGlobal.sumstr + "','" + dtpicker.Text + "')"; 
            SqlDataAdapter sda = new SqlDataAdapter(query1, conn); 
            sda.SelectCommand.ExecuteNonQuery(); 
            conn.Close();
        }

        //Unpaid Function
        public void Unpaid()
        {
            Connection.conn.Open();
            String query2 = "INSERT INTO Unpaid (CusId,Amount,Date) VALUES ('" + MyGlobal.datain + "','" + MyGlobal.sumstr + "','" + dtpicker.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query2, Connection.conn);
            sda.SelectCommand.ExecuteNonQuery();
            Connection.conn.Close();
            unpaidv();
        }

        //Cash Function
        public void Cash()
        {
            if (ckboxCus.Checked == true)
            {
                int balance = 0;
                //Enter data to Customer Table 
                conn.Open();
                String query3 = "INSERT INTO Customer (Name,Address,Tp,Type,Date,Balance,LastUpdate) VALUES ('" + txtName.Text + "','" + txtAddress.Text + "','" + txtTp.Text + "','" + comboBoxType.Text + "','" + dtpicker.Text + "','" + balance + "','" + dtpicker.Text + "')";
                SqlDataAdapter sda1 = new SqlDataAdapter(query3, conn);
                sda1.SelectCommand.ExecuteNonQuery(); 
                conn.Close();
           
                //Dis_Data();

                /*
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Id from Customer ORDER BY Id DESC";
                SqlDataReader daa = cmd.ExecuteReader();
                while (daa.Read())
                {
                    String data = daa.GetValue(0).ToString();
                    int datain = Convert.ToInt32(data);
                }
                conn.Close();
                */

                dataget();

                //Enter data to Daily table
                for (int i = 0; i < DisData.Rows.Count - 1; i++)
                {
                    SqlCommand cmd2 = new SqlCommand("INSERT INTO Daily (Item,Quantity,Price,TotalPrice,Id ) VALUES ('" + DisData.Rows[i].Cells[0].Value + "','" + DisData.Rows[i].Cells[1].Value + "','" + DisData.Rows[i].Cells[2].Value + "','" + DisData.Rows[i].Cells[3].Value + "','" + MyGlobal.datain + "')", conn);

                    conn.Open();
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                    label6.Text = "Inserted Successfully!";
                }
                //reset();


            }
            else
            {
                //Enter data to Customer Table 
                conn.Open();
                String query4 = "UPDATE Customer SET LastUpdate = '" + dtpicker.Text + "' WHERE CusId= '" + txtId.Text + "'";
                SqlDataAdapter sda2 = new SqlDataAdapter(query4, conn);
                sda2.SelectCommand.ExecuteNonQuery();
                conn.Close();

                //Enter data to Daily table
                for (int i = 0; i < DisData.Rows.Count - 1; i++)
                {
                    SqlCommand cmd4 = new SqlCommand("INSERT INTO Daily (Item,Quantity,Price,TotalPrice,Id ) VALUES ('" + DisData.Rows[i].Cells[0].Value + "','" + DisData.Rows[i].Cells[1].Value + "','" + DisData.Rows[i].Cells[2].Value + "','" + DisData.Rows[i].Cells[3].Value + "','" + txtId.Text + "')", conn);

                    conn.Open();
                    cmd4.ExecuteNonQuery();
                    conn.Close();
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
                conn.Open();
                String query5 = "INSERT INTO Customer (Name,Address,Tp,Type,Date,Balance,LastUpdate) VALUES ('" + txtName.Text + "','" + txtAddress.Text + "','" + txtTp.Text + "','" + comboBoxType.Text + "','" + dtpicker.Text + "','" + MyGlobal.sumstr + "','" + dtpicker.Text + "')";
                SqlDataAdapter sda3 = new SqlDataAdapter(query5, conn);
                sda3.SelectCommand.ExecuteNonQuery();
                conn.Close();

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
                conn.Open();
                String query6 = "UPDATE Customer SET Balance = '" + MyGlobal.balancestr + "', LastUpdate =  '" + dtpicker.Text + "' WHERE CusId= '" + txtId.Text + "'";
                SqlDataAdapter sda4 = new SqlDataAdapter(query6, conn);
                sda4.SelectCommand.ExecuteNonQuery();
                conn.Close();

                //Dis_Data();
                dataget();

                //Enter data to Daily table
                for (int i = 0; i < DisData.Rows.Count - 1; i++)
                {
                    //Add data + price

                    SqlCommand cmd4 = new SqlCommand("INSERT INTO Daily (Item,Quantity,Price,TotalPrice,Id ) VALUES ('" + DisData.Rows[i].Cells[0].Value + "','" + DisData.Rows[i].Cells[1].Value + "','" + DisData.Rows[i].Cells[2].Value + "','" + DisData.Rows[i].Cells[3].Value + "','" + txtId.Text + "')", conn);

                    conn.Open();
                    cmd4.ExecuteNonQuery();
                    conn.Close();
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

        private void btnCash_Click(object sender, EventArgs e)
        {
            Cash();
            Paid();
            dataget();
        }

        //get data in to datadrid
        public void Dis_Data()
        {
            
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Customer";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DisData.DataSource = dt;
            conn.Close();
             
        }


        private void DisData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NewBill_Load(object sender, EventArgs e)
        {
            //Dis_Data();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataget();
            reset();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataget();
            search();
        }

        public DateTime data { get; set; }

        public string datain { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Total();
            datagridsum();
            Balance();
            
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            dataget();
            Credit();
            Unpaid();
        }
    }
    
}


