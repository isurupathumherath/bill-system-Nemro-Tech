namespace Nemro
{
    partial class Selected_Payments
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtVoucher = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTotal = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpicker2 = new System.Windows.Forms.DateTimePicker();
            this.lalRs = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 300);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(631, 456);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(76, 27);
            this.btnPay.TabIndex = 29;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(192, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 26);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtVoucher
            // 
            this.txtVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucher.Location = new System.Drawing.Point(201, 425);
            this.txtVoucher.Name = "txtVoucher";
            this.txtVoucher.Size = new System.Drawing.Size(225, 26);
            this.txtVoucher.TabIndex = 26;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(19, 73);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(155, 26);
            this.txtId.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Voucher Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-214, -18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 24);
            this.label11.TabIndex = 25;
            this.label11.Text = "Customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 51);
            this.label1.TabIndex = 22;
            this.label1.Text = "Selected Credit Payment ";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(631, 73);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(76, 26);
            this.btnTotal.TabIndex = 28;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(503, 458);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(123, 26);
            this.txtAmount.TabIndex = 27;
            // 
            // dtpicker1
            // 
            this.dtpicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpicker1.Location = new System.Drawing.Point(201, 457);
            this.dtpicker1.Name = "dtpicker1";
            this.dtpicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpicker1.Size = new System.Drawing.Size(225, 26);
            this.dtpicker1.TabIndex = 32;
            this.dtpicker1.Value = new System.DateTime(2020, 3, 21, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Expire Date";
            // 
            // dtpicker2
            // 
            this.dtpicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpicker2.Location = new System.Drawing.Point(503, 421);
            this.dtpicker2.Name = "dtpicker2";
            this.dtpicker2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpicker2.Size = new System.Drawing.Size(204, 26);
            this.dtpicker2.TabIndex = 33;
            this.dtpicker2.Value = new System.DateTime(2020, 3, 21, 0, 0, 0, 0);
            // 
            // lalRs
            // 
            this.lalRs.AutoSize = true;
            this.lalRs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalRs.Location = new System.Drawing.Point(521, 75);
            this.lalRs.Name = "lalRs";
            this.lalRs.Size = new System.Drawing.Size(33, 20);
            this.lalRs.TabIndex = 49;
            this.lalRs.Text = "Rs.";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(553, 75);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(27, 20);
            this.lblTotal.TabIndex = 50;
            this.lblTotal.Text = "00";
            // 
            // Selected_Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 490);
            this.Controls.Add(this.lalRs);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dtpicker2);
            this.Controls.Add(this.dtpicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtVoucher);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Name = "Selected_Payments";
            this.Text = "Selected_Payments";
            this.Load += new System.EventHandler(this.Selected_Payments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtVoucher;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtpicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpicker2;
        private System.Windows.Forms.Label lalRs;
        private System.Windows.Forms.Label lblTotal;
    }
}