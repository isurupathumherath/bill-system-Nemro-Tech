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
    public partial class SelectedPayment : UserControl
    {
        

        public SelectedPayment()
        {
            InitializeComponent();
        }

        private void SelectedPayment_Load(object sender, EventArgs e)
        {

        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NemroTech.mdf;Integrated Security=True;Connect Timeout=30");


        public void search()
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

        public void updatebalance()
        {
            conn.Open();
            String query5 = "UPDATE Customer SET Balance = '" + MyGlobalPayment.balan + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query5, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
        }

        public void delete()
        {
            int Total = 0;
            int j = 0;
            while (j < (dataGridView1.Rows.Count - 1))
            {
                bool isChecked = (bool)dataGridView1.Rows[j].Cells[0].Value;
                if (isChecked == true)
                {
                    conn.Open();
                    String paid = "paid";
                    String selected = Convert.ToString(dataGridView1.Rows[j].Cells[1].Value);
                    String query1 = "UPDATE Daily SET Status = '" + paid + "' WHERE ItemId = '" + selected + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query1, conn);
                    sda.SelectCommand.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Database Updated!");
                }
                else if (isChecked == false)
                {
                    //MessageBox.Show("Do Nothing");
                }
                j++;
            }
            lblTotal.Text = Convert.ToString(Total);
        }

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

        public void paid()
        {
            Connection.conn.Open();
            String query2 = "INSERT INTO paid (CusId,Amount,Date,VoucherNo,VoucherDate) VALUES ('" + txtId.Text + "','" + txtAmount.Text + "','" + dtpicker2.Text + "','" + txtVoucher.Text + "','" + dtpicker1.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query2, Connection.conn);
            sda.SelectCommand.ExecuteNonQuery();
            Connection.conn.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            /*
            for (int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[0].Value == false)
                {
                    dataGridView1.Rows[i].Cells[0].Value = true;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[0].Value = false;
                }
                //Total
                TxtTotal.Text = (dataGridView1.Rows.Cast<DataGridViewRow>()
                    .Where(r => Convert.ToBoolean(r.Cells[0].Value).Equals(true))
                    .Sum(t => Convert.ToDouble(t.Cells[1].Value)).ToString());
            }
           */

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            total();
            delete();
            updatebalance();
            paid();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            /*
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            TxtTotal.Text = Convert.ToString(sum);
            */
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)

            int Total = 0;
            int i = 0;
            while (i < (dataGridView1.Rows.Count - 1))
            {
                bool isChecked = (bool)dataGridView1.Rows[i].Cells[0].Value;
                if (isChecked == true)
                {
                    Total += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
                    MessageBox.Show(Convert.ToString(Total));
                }
                else if (isChecked == false)
                {
                    //MessageBox.Show("Do Nothing");
                }
                i++;
            }

            lblTotal.Text = Convert.ToString(Total);

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void btnTotal_Click_1(object sender, EventArgs e)
        {
            int Total = 0;
            int i = 0;
            while (i < (dataGridView1.Rows.Count - 1))
            {
                bool isChecked = (bool)dataGridView1.Rows[i].Cells[0].Value;
                if (isChecked == true)
                {
                    Total += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
                    //MessageBox.Show(Convert.ToString(Total));
                    i++;
                }
                else if (isChecked == false)
                {
                    i++;
                    //MessageBox.Show("Do Nothing");
                }
                //i++;
            }

            lblTotal.Text = Convert.ToString(Total);
        }

        private void btnPay_Click_1(object sender, EventArgs e)
        {
            total();
            delete();
            updatebalance();
            paid();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        public void reset()
        {
            //clear texts
            txtId.Text = "";
            //Clear DataGrid
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
