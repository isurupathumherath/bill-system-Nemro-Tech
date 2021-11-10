namespace Nemro
{
    partial class NewBill
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTp = new System.Windows.Forms.TextBox();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.DisData = new System.Windows.Forms.DataGridView();
            this.txtItem = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.ckboxCus = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DisData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telephone No";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(202, 126);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(531, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(202, 156);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(531, 26);
            this.txtAddress.TabIndex = 2;
            // 
            // txtTp
            // 
            this.txtTp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTp.Location = new System.Drawing.Point(202, 190);
            this.txtTp.Name = "txtTp";
            this.txtTp.Size = new System.Drawing.Size(531, 26);
            this.txtTp.TabIndex = 3;
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(500, 483);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(75, 23);
            this.btnCash.TabIndex = 7;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(581, 483);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(75, 23);
            this.btnCredit.TabIndex = 8;
            this.btnCredit.Text = "Credit";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(662, 483);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Customer ID";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(202, 94);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(226, 26);
            this.txtId.TabIndex = 0;
            // 
            // DisData
            // 
            this.DisData.AllowUserToDeleteRows = false;
            this.DisData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtItem,
            this.txtReason,
            this.txtQuantity,
            this.txtPrice,
            this.txtTotal});
            this.DisData.Location = new System.Drawing.Point(18, 265);
            this.DisData.Name = "DisData";
            this.DisData.RowHeadersVisible = false;
            this.DisData.Size = new System.Drawing.Size(715, 185);
            this.DisData.TabIndex = 5;
            this.DisData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisData_CellContentClick);
            // 
            // txtItem
            // 
            this.txtItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtItem.HeaderText = "Item";
            this.txtItem.Items.AddRange(new object[] {
            "Photo - Copy",
            "Print Out",
            "Duplo",
            "Send Email",
            "Send Fax",
            "Other"});
            this.txtItem.Name = "txtItem";
            this.txtItem.Width = 200;
            // 
            // txtReason
            // 
            this.txtReason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtReason.HeaderText = "Reason";
            this.txtReason.Name = "txtReason";
            // 
            // txtQuantity
            // 
            this.txtQuantity.HeaderText = "Quantity";
            this.txtQuantity.Name = "txtQuantity";
            // 
            // txtPrice
            // 
            this.txtPrice.HeaderText = "Price";
            this.txtPrice.Name = "txtPrice";
            // 
            // txtTotal
            // 
            this.txtTotal.HeaderText = "Total Price";
            this.txtTotal.Name = "txtTotal";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(17, 483);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 488);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Type";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Personal",
            "School",
            "Other"});
            this.comboBoxType.Location = new System.Drawing.Point(202, 225);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(226, 28);
            this.comboBoxType.TabIndex = 4;
            // 
            // ckboxCus
            // 
            this.ckboxCus.AutoSize = true;
            this.ckboxCus.Location = new System.Drawing.Point(399, 487);
            this.ckboxCus.Name = "ckboxCus";
            this.ckboxCus.Size = new System.Drawing.Size(95, 17);
            this.ckboxCus.TabIndex = 6;
            this.ckboxCus.Text = "New Customer";
            this.ckboxCus.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 14;
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(98, 483);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 15;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(591, 460);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(450, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(530, 460);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Total Rs.";
            // 
            // dtpicker
            // 
            this.dtpicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpicker.Location = new System.Drawing.Point(529, 227);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpicker.Size = new System.Drawing.Size(204, 26);
            this.dtpicker.TabIndex = 19;
            this.dtpicker.Value = new System.DateTime(2020, 3, 21, 0, 0, 0, 0);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(200, 62);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(0, 16);
            this.lblCustomer.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Last Customer ID";
            // 
            // NewBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 537);
            this.Controls.Add(this.dtpicker);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ckboxCus);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.DisData);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.txtTp);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Bill";
            this.Load += new System.EventHandler(this.NewBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTp;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView DisData;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.CheckBox ckboxCus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewComboBoxColumn txtItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTotal;


    }
}