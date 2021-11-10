using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Nemro
{
    public partial class Login : Form
    {
        //Panal Moving Handler
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int msg, int wparm, int ipram);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Focus to username When the windows is opened
            txtUsername.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Create a Connection
                string constring = "Server=localhost; Port=3306; Datbase=nemrotech; Uid=root; Passowrd=";
                MySqlConnection conn = new MySqlConnection(constring);
                MySqlDataAdapter sda = new MySqlDataAdapter("Select * from Authentication where username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'", conn);
                MySqlDataAdapter sda2 = new MySqlDataAdapter("Select Role from Authentication where username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'", conn);

                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();

                sda.Fill(dt);
                sda2.Fill(dt2);
                String role = "admin";

                if (dt.Rows.Count == 1)
                {
                    
                        if (dt2.Rows[0]["Role"].ToString() == role)
                        {
                            //open Admin Form
                            Admin mf = new Admin();
                            mf.Show();
                        }
                        else
                        {
                            //open client Form
                            Client mf1 = new Client();
                            mf1.Show();
                        }
                    
                    
                    //clear Username and Password TextBoxes
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    this.Hide();
                }
                else
                {
                    //Showmessage if username or Password incorrect
                    MessageBox.Show("Username or Password is incorrect!");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
            }
            catch (Exception e01)
            {
                //If connection Error
                MessageBox.Show("Error!" + e01);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
public static class GlobalDate
{
    public static String date = DateTime.Now.ToShortDateString();
}