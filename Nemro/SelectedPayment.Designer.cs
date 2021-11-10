namespace Nemro
{
    partial class SelectedPayment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lalRs = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dtpicker2 = new System.Windows.Forms.DateTimePicker();
            this.dtpicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtVoucher = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lalRs
            // 
            this.lalRs.AutoSize = true;
            this.lalRs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalRs.Location = new System.Drawing.Point(534, 80);
            this.lalRs.Name = "lalRs";
            this.lalRs.Size = new System.Drawing.Size(33, 20);
            this.lalRs.TabIndex = 64;
            this.lalRs.Text = "Rs.";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(566, 80);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(27, 20);
            this.lblTotal.TabIndex = 65;
            this.lblTotal.Text = "00";
            // 
            // dtpicker2
            // 
            this.dtpicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpicker2.Location = new System.Drawing.Point(521, 426);
            this.dtpicker2.Name = "dtpicker2";
            this.dtpicker2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpicker2.Size = new System.Drawing.Size(204, 26);
            this.dtpicker2.TabIndex = 5;
            this.dtpicker2.Value = new System.DateTime(2020, 3, 21, 0, 0, 0, 0);
            // 
            // dtpicker1
            // 
            this.dtpicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpicker1.Location = new System.Drawing.Point(219, 462);
            this.dtpicker1.Name = "dtpicker1";
            this.dtpicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpicker1.Size = new System.Drawing.Size(225, 26);
            this.dtpicker1.TabIndex = 4;
            this.dtpicker1.Value = new System.DateTime(2020, 3, 21, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 300);
            this.dataGridView1.TabIndex = 61;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(649, 461);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(76, 27);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click_1);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(649, 78);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(76, 26);
            this.btnTotal.TabIndex = 2;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(362, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 26);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtVoucher
            // 
            this.txtVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucher.Location = new System.Drawing.Point(219, 430);
            this.txtVoucher.Name = "txtVoucher";
            this.txtVoucher.Size = new System.Drawing.Size(225, 26);
            this.txtVoucher.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(521, 463);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(123, 26);
            this.txtAmount.TabIndex = 6;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(189, 77);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(155, 26);
            this.txtId.TabIndex = 0;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 52;
            this.label3.Text = "Expire Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "Cheque Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(36, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 24);
            this.label11.TabIndex = 54;
            this.label11.Text = "Customer ID";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 51);
            this.label1.TabIndex = 51;
            this.label1.Text = "Selected Credit Payment ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 66;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectedPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
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
            this.Name = "SelectedPayment";
            this.Size = new System.Drawing.Size(753, 521);
            this.Load += new System.EventHandler(this.SelectedPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalRs;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker dtpicker2;
        private System.Windows.Forms.DateTimePicker dtpicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtVoucher;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
