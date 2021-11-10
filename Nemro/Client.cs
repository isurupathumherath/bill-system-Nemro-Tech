using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Nemro
{
    public partial class Client : Form
    {
        //Panal Moving Handler
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int msg, int wparm, int ipram);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnnewbill_Click_1(object sender, EventArgs e)
        {
            userControl11.BringToFront();
            //userControl113.BringToFront();
            //NewBill newbill = new NewBill();
            //newbill.Show();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            customerSearchUC1.BringToFront();
            //CustomerSearch customersearch = new CustomerSearch();
            //customersearch.Show();
        }

        private void btnPayment_Click_1(object sender, EventArgs e)
        {
           
           paymentUserControl1.BringToFront();
            //Payment payment = new Payment();
            //payment.Show();
        }

        private void panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnSelectedPayment_Click(object sender, EventArgs e)
        {
           // selectedPayment1.BringToFront();
            //SelectedPayment selectedpayment = new SelectedPayment();
            //selectedpayment.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPayment1.BringToFront();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
