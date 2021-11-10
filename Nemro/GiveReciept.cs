using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace Nemro
{
    public partial class GiveReciept : Form
    {
        public GiveReciept()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NemroTech.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;
            ws.Name = "Invoice";

            ws.Cells[1, 2] = "Invoice";
            ws.Cells.Range["A1:E1"].Font.Size = 14;
            ws.Cells.Range["A1:E1"].Font.Color = Color.Green;

            ws.Cells[5, 2] = txtId.Text;

            for (int isuru = 0; isuru < DataGridSearchResult.Rows.Count; isuru++)
            {
                for(int pathum = 0; pathum < DataGridSearchResult.Columns.Count; pathum++)
                {
                    ws.Cells[isuru + 2, pathum + 2] = DataGridSearchResult.Rows[isuru].Cells[pathum].Value;
                }
            }
        }

        private void GiveReciept_Load(object sender, EventArgs e)
        {

        }
        

        public void search()
        {
            String unpaid = "unpaid";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Daily WHERE Id = '" + txtId.Text + "' AND Status = '" + unpaid + "'";
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            DataGridSearchResult.DataSource = dt;
            conn.Close();
        }
    }

}
