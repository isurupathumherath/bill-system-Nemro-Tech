using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace Nemro
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NemroTech.mdf;Integrated Security=True;Connect Timeout=30");

        public void search()
        {
            //DataGridViewCheckBoxColumn datacheck = new DataGridViewCheckBoxColumn();
            //datacheck.HeaderText = "Select";
            //dataGridView1.Columns.Add(datacheck);
            String unpaid = "unpaid";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Date,Item,Reason,Quantity,Price,TotalPrice FROM Daily WHERE Id = '" + txtId.Text + "' AND Status = '" + unpaid + "'";
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void datagridsum()
        {
            int x = 0, y, i = 0;

            //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            
            while (i < dataGridView1.Rows.Count - 1)
            {
                 y = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
                 //y = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                 x += y;
                 i++;
                 //dataGridView1.Rows[i].Cells[4].Value = y;
                }

            try
            {
                //int m = dataGridView1.Rows.Add();
                //m = i;
                
                
                dataGridView1.Rows[i].Cells[4].Value = "Total";
                dataGridView1.Rows[i].Cells[5].Value = Convert.ToString(x);
                
            }

            catch
            {
                MessageBox.Show("There is no record in the database!");
            }
            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
            datagridsum();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
           //printer.RowHeight = DGVPrinter.RowHeightSetting.CellHeight;
            printer.Title = "Nemro Tec";
            printer.SubTitle = "Address: 49/1, Noori Road, Deraniyagala\n TP: 0726073580\n";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }
    }
}
