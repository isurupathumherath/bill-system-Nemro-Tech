using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Nemro
{
    public partial class Admin : Form
    {
        //Panal Moving Handler
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int msg, int wparm, int ipram);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        public Admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            //this.Close();
            Application.Exit();
        }

        private void btnnewbill_Click(object sender, EventArgs e)
        {
            userControl13.BringToFront();
            //NewBill newbill = new NewBill();
            //newbill.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            customerSearchUC2.BringToFront();
            //CustomerSearch customersearch = new CustomerSearch();
            //customersearch.Show();
        }


        private void btnPayment_Click(object sender, EventArgs e)
        {
            paymentUserControl1.BringToFront();
            //Payment payment = new Payment();
            //payment.Show();
        }

        private void btnSelectedPayment_Click(object sender, EventArgs e)
        {
            selectedPayment1.BringToFront();
            //Payment payment = new Payment();
            //payment.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
            userControl11.BringToFront();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Only adminsee = new Admin_Only();
            adminsee.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GiveReciept reciept = new GiveReciept();
            reciept.Show();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectedPayment_Click_1(object sender, EventArgs e)
        {
            selectedPayment1.BringToFront();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            //report1.BringToFront();
        }

        private void report1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            RecordChange change = new RecordChange();
            change.Show();
        }

        private void userControl13_Load(object sender, EventArgs e)
        {

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            details11.BringToFront();
        }
    }
}

public static class Connection
{
    //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NemroTech.mdf;Integrated Security=True;Connect Timeout=30");
    public static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\NemroTech.mdf;Integrated Security=True;Connect Timeout=30");
}
