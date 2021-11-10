namespace Nemro
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbladmin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnnewbill = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSelectedPayment = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.customerSearchUC1 = new Nemro.CustomerSearchUC();
            this.paymentUserControl1 = new Nemro.paymentUserControl();
            this.selectedPayment1 = new Nemro.SelectedPayment();
            this.userControl11 = new Nemro.UserControl1();
            this.userControl12 = new Nemro.UserControl1();
            this.userControl13 = new Nemro.UserControl1();
            this.customerSearchUC2 = new Nemro.CustomerSearchUC();
            this.details11 = new Nemro.Details1();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbladmin
            // 
            this.lbladmin.AutoSize = true;
            this.lbladmin.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmin.Location = new System.Drawing.Point(28, 5);
            this.lbladmin.Name = "lbladmin";
            this.lbladmin.Size = new System.Drawing.Size(129, 21);
            this.lbladmin.TabIndex = 0;
            this.lbladmin.Text = "Admin Dashboard";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.lbladmin);
            this.panel2.Location = new System.Drawing.Point(203, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 33);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(732, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "X";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayment.Location = new System.Drawing.Point(0, 171);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(230, 37);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "Full Payment";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(0, 257);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(230, 37);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search Customers";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnnewbill
            // 
            this.btnnewbill.FlatAppearance.BorderSize = 0;
            this.btnnewbill.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnnewbill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnnewbill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnnewbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewbill.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewbill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnewbill.Location = new System.Drawing.Point(0, 128);
            this.btnnewbill.Name = "btnnewbill";
            this.btnnewbill.Size = new System.Drawing.Size(230, 37);
            this.btnnewbill.TabIndex = 0;
            this.btnnewbill.Text = "New Bill";
            this.btnnewbill.UseVisualStyleBackColor = true;
            this.btnnewbill.Click += new System.EventHandler(this.btnnewbill_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnDetails);
            this.panel1.Controls.Add(this.btnChange);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnSelectedPayment);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.btnnewbill);
            this.panel1.Controls.Add(this.btnPayment);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 561);
            this.panel1.TabIndex = 13;
            // 
            // btnDetails
            // 
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.btnDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDetails.Location = new System.Drawing.Point(0, 386);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(230, 37);
            this.btnDetails.TabIndex = 16;
            this.btnDetails.Text = "Payment Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnChange
            // 
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.btnChange.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChange.Location = new System.Drawing.Point(3, 343);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(230, 37);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReport.Location = new System.Drawing.Point(3, 300);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(230, 37);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnSelectedPayment
            // 
            this.btnSelectedPayment.FlatAppearance.BorderSize = 0;
            this.btnSelectedPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectedPayment.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelectedPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectedPayment.Location = new System.Drawing.Point(3, 214);
            this.btnSelectedPayment.Name = "btnSelectedPayment";
            this.btnSelectedPayment.Size = new System.Drawing.Size(230, 37);
            this.btnSelectedPayment.TabIndex = 2;
            this.btnSelectedPayment.Text = "Selected Payment";
            this.btnSelectedPayment.UseVisualStyleBackColor = true;
            this.btnSelectedPayment.Click += new System.EventHandler(this.btnSelectedPayment_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Location = new System.Drawing.Point(3, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(230, 1);
            this.panel4.TabIndex = 15;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(10, 72);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(214, 17);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Wednesday, March 25, 2020";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Transparent;
            this.lblTime.Location = new System.Drawing.Point(10, 45);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(99, 17);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "12:00:00 AM";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SandyBrown;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Font = new System.Drawing.Font("Montserrat Subrayada", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(-5, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 33);
            this.panel3.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Teko SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nemro Tech";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // customerSearchUC1
            // 
            this.customerSearchUC1.Location = new System.Drawing.Point(356, 54);
            this.customerSearchUC1.Name = "customerSearchUC1";
            this.customerSearchUC1.Size = new System.Drawing.Size(753, 521);
            this.customerSearchUC1.TabIndex = 17;
            // 
            // paymentUserControl1
            // 
            this.paymentUserControl1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.paymentUserControl1.Location = new System.Drawing.Point(325, 54);
            this.paymentUserControl1.Name = "paymentUserControl1";
            this.paymentUserControl1.Size = new System.Drawing.Size(753, 521);
            this.paymentUserControl1.TabIndex = 16;
            // 
            // selectedPayment1
            // 
            this.selectedPayment1.Location = new System.Drawing.Point(333, 54);
            this.selectedPayment1.Name = "selectedPayment1";
            this.selectedPayment1.Size = new System.Drawing.Size(753, 521);
            this.selectedPayment1.TabIndex = 18;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl11.data = new System.DateTime(((long)(0)));
            this.userControl11.datain = null;
            this.userControl11.Location = new System.Drawing.Point(227, 36);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(753, 522);
            this.userControl11.TabIndex = 15;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl12.data = new System.DateTime(((long)(0)));
            this.userControl12.datain = null;
            this.userControl12.Location = new System.Drawing.Point(235, 35);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(745, 521);
            this.userControl12.TabIndex = 20;
            // 
            // userControl13
            // 
            this.userControl13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl13.data = new System.DateTime(((long)(0)));
            this.userControl13.datain = null;
            this.userControl13.Location = new System.Drawing.Point(333, 45);
            this.userControl13.Name = "userControl13";
            this.userControl13.Size = new System.Drawing.Size(745, 521);
            this.userControl13.TabIndex = 0;
            this.userControl13.Load += new System.EventHandler(this.userControl13_Load);
            // 
            // customerSearchUC2
            // 
            this.customerSearchUC2.Location = new System.Drawing.Point(325, 54);
            this.customerSearchUC2.Name = "customerSearchUC2";
            this.customerSearchUC2.Size = new System.Drawing.Size(745, 529);
            this.customerSearchUC2.TabIndex = 20;
            // 
            // details11
            // 
            this.details11.Location = new System.Drawing.Point(341, 60);
            this.details11.Name = "details11";
            this.details11.Size = new System.Drawing.Size(745, 523);
            this.details11.TabIndex = 21;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(983, 552);
            this.Controls.Add(this.userControl13);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customerSearchUC1);
            this.Controls.Add(this.paymentUserControl1);
            this.Controls.Add(this.selectedPayment1);
            this.Controls.Add(this.customerSearchUC2);
            this.Controls.Add(this.details11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbladmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnnewbill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private UserControl1 userControl11;
        private paymentUserControl paymentUserControl1;
        private CustomerSearchUC customerSearchUC1;
        private SelectedPayment selectedPayment1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSelectedPayment;
        private System.Windows.Forms.Button btnChange;
        //private Admin_Changes admin_Changes1;
        private UserControl1 userControl12;
        private UserControl1 userControl13;
        private CustomerSearchUC customerSearchUC2;
        private System.Windows.Forms.Button btnDetails;
        private Details1 details11;
    }
}