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
    public partial class RecordChange : Form
    {
        public RecordChange()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NemroTech.mdf;Integrated Security=True;Connect Timeout=30");

        public void psearch()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            DataGridViewCheckBoxColumn datacheck = new DataGridViewCheckBoxColumn();
            datacheck.HeaderText = "Select";
            dataGridView1.Columns.Add(datacheck);
            String unpaid = "unpaid";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ItemId,Item,Reason,Quantity,Price,TotalPrice,Date FROM Daily WHERE Id = '" + txtId.Text + "' AND Status = '" + unpaid + "'";
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        public void usearch()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            DataGridViewCheckBoxColumn datacheck = new DataGridViewCheckBoxColumn();
            datacheck.HeaderText = "Select";
            dataGridView1.Columns.Add(datacheck);
            String unpaid = "paid";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ItemId,Item,Reason,Quantity,Price,TotalPrice,Date FROM Daily WHERE Id = '" + txtId.Text + "' AND Status = '" + unpaid + "'";
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        public void itemsload()
        {
            //DataGridViewCheckBoxColumn datacheck = new DataGridViewCheckBoxColumn();
            //datacheck.HeaderText = "Select";
            //dataGridView1.Columns.Add(datacheck);
            conn.Open();
            SqlCommand cmd5 = conn.CreateCommand();
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "SELECT * FROM Item";
            cmd5.ExecuteNonQuery();
            System.Data.DataTable dt5 = new System.Data.DataTable();
            SqlDataAdapter da5 = new SqlDataAdapter(cmd5);
            da5.Fill(dt5);
            dataGridView2.DataSource = dt5;
            conn.Close();
        }

        public void typeload()
        {
            //DataGridViewCheckBoxColumn datacheck = new DataGridViewCheckBoxColumn();
            //datacheck.HeaderText = "Select";
            //dataGridView1.Columns.Add(datacheck);
            conn.Open();
            SqlCommand cmd6 = conn.CreateCommand();
            cmd6.CommandType = CommandType.Text;
            cmd6.CommandText = "SELECT * FROM Type";
            cmd6.ExecuteNonQuery();
            System.Data.DataTable dt6 = new System.Data.DataTable();
            SqlDataAdapter da6 = new SqlDataAdapter(cmd6);
            da6.Fill(dt6);
            dataGridView3.DataSource = dt6;
            conn.Close();
        }


        public void searchname()
        {
            //DataGridViewCheckBoxColumn datacheck = new DataGridViewCheckBoxColumn();
            //datacheck.HeaderText = "Select";
            //dataGridView1.Columns.Add(datacheck);

            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Name FROM Customer WHERE CusId = '" + txtId.Text + "'";
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt1 = new System.Data.DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt1);
            //dataGridView1.DataSource = dt1;
            

            if (dt1.Rows.Count == 1)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //put data in text boxes 

                    LabelName.Text = (dr["Name"].ToString());
                }
                else
                {
                    MessageBox.Show("Invalid Customer ID");
                }
            }
            conn.Close();
        }
        public void delete()
        {
            try
            {
                int j = 0;
                while (j < (dataGridView1.Rows.Count - 1))
                {
                    bool isChecked = (bool)dataGridView1.Rows[j].Cells[0].Value;
                    if (isChecked == true)
                    {
                        conn.Open();

                        String selected = Convert.ToString(dataGridView1.Rows[j].Cells[1].Value);
                        String query1 = "DELETE FROM Daily WHERE ItemId = '" + selected + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(query1, conn);
                        sda.SelectCommand.ExecuteNonQuery();
                        conn.Close();

                        
                    }
                    else if (isChecked == false)
                    {
                        //MessageBox.Show("Do Nothing");
                    }
                    j++;

                }
                MessageBox.Show("Database Updated!");
            }
            catch
            {
                MessageBox.Show("Select record!");
            }
            
            
        }

        private void refreshname()
        {
            comboBox2.Items.Clear();
            Connection.conn.Open();
            SqlCommand cmd = Connection.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Username FROM Authentication";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                comboBox2.Items.Add(dr["Username"].ToString());
            }
            Connection.conn.Close();
        }

        private void chechvalue()
        {
            try
            {
                //Create a Connection
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NemroTech.mdf;Integrated Security=True;Connect Timeout=30");
                //SqlDataAdapter sda = new SqlDataAdapter("Select * from Authentication where username = '" + comboBox2.Text + "' and password = '" + txtPassword.Text + "'", conn);
                SqlDataAdapter sda2 = new SqlDataAdapter("Select * from Authentication where username = '" + comboBox2.Text + "' and password = '" + txtcurrentpass.Text + "'", conn);

                //DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();

                //sda.Fill(dt);
                sda2.Fill(dt2);

                if (dt2.Rows.Count == 1)
                {
                    conn.Open();
                    String query5 = "UPDATE Authentication SET Password = '" + txtPassword.Text + "' WHERE Username = '" + comboBox2.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query5, conn);
                    sda.SelectCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Database Updated!");
                }
                else
                {
                    //Showmessage if username or Password incorrect
                    MessageBox.Show("Password is incorrect!");
                }
            }
            catch (Exception e01)
            {
                //If connection Error
                MessageBox.Show("Error!" + e01);
            }
        }

        private void insert()
        {
            comboBox2.Items.Clear();
            Connection.conn.Open();
            SqlCommand cmd = Connection.conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Username FROM Authentication";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                if (textBox6.Text == (dr["Username"].ToString()))
                {
                    MessageBox.Show("Username Already Exists!");
                }
            }
            Connection.conn.Close();

            Connection.conn.Open();
            String query1 = "INSERT INTO Authentication (Username,Password,Role) VALUES ('" + textBox6.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query1, Connection.conn);
            sda.SelectCommand.ExecuteNonQuery();
            Connection.conn.Close();
            MessageBox.Show("Database Updated!");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            chechvalue();
            refreshname();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            psearch();
            searchname();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            insert();
            refreshname();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //clear texts
            comboBox2.Text = "";
            txtcurrentpass.Text = "";
            txtPassword.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clear texts
            comboBox1.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void btnrst_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void RecordChange_Load(object sender, EventArgs e)
        {
            itemsload();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query6 = "DELETE FROM Item WHERE Name = '" + textBox2.Text + "'";
            SqlDataAdapter sda6 = new SqlDataAdapter(query6, conn);
            sda6.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Deleted Successfuly!");
            itemsload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.conn.Open();
            String query3 = "INSERT INTO Item (Name) VALUES ('" + textBox2.Text + "')";
            SqlDataAdapter sda3 = new SqlDataAdapter(query3, Connection.conn);
            sda3.SelectCommand.ExecuteNonQuery();
            Connection.conn.Close();
            MessageBox.Show("Database Updated!");
            itemsload();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            itemsload();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            Connection.conn.Open();
            String query9 = "INSERT INTO Type (Type) VALUES ('" + txtType.Text + "')";
            SqlDataAdapter sda9 = new SqlDataAdapter(query9, Connection.conn);
            sda9.SelectCommand.ExecuteNonQuery();
            Connection.conn.Close();
            MessageBox.Show("Database Updated!");
            typeload();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query10 = "DELETE FROM Type WHERE Type = '" + txtType.Text + "'";
            SqlDataAdapter sda10 = new SqlDataAdapter(query10, conn);
            sda10.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Deleted Successfuly!");
            typeload();
        }

        public void reset()
        {
            //clear texts
            txtId.Text = "";
            //Clear DataGrid
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            LabelName.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtType.Text = "";
            typeload();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.Open();
            String query10 = "DELETE FROM Customer WHERE CusId = '" + txtId.Text + "'";
            String query11 = "DELETE FROM Daily WHERE Id = '" + txtId.Text + "'";
            SqlDataAdapter sda10 = new SqlDataAdapter(query10, conn);
            SqlDataAdapter sda11 = new SqlDataAdapter(query11, conn);
            sda10.SelectCommand.ExecuteNonQuery();
            sda11.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Deleted Successfuly!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            usearch();
            searchname();
        }
    }
}
