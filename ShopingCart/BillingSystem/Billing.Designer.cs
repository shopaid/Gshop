namespace ShopingCart.BillingSystem
{
    partial class Billing
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
            this.grdBilling = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_BillNo = new System.Windows.Forms.TextBox();
            this.lbl_cusName = new System.Windows.Forms.Label();
            this.txt_CusName = new System.Windows.Forms.TextBox();
            this.lbl_cusAddress = new System.Windows.Forms.Label();
            this.lbl_cusMobile = new System.Windows.Forms.Label();
            this.txt_cusMobile = new System.Windows.Forms.TextBox();
            this.rch_cusAddress = new System.Windows.Forms.RichTextBox();
            this.lbl_billDate = new System.Windows.Forms.Label();
            this.dt_billDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_pdtCount = new System.Windows.Forms.Label();
            this.txt_pdtCount = new System.Windows.Forms.TextBox();
            this.lbl_qauntCount = new System.Windows.Forms.Label();
            this.txt_QuantCount = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBilling)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBilling
            // 
            this.grdBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBilling.Location = new System.Drawing.Point(61, 152);
            this.grdBilling.Name = "grdBilling";
            this.grdBilling.Size = new System.Drawing.Size(761, 244);
            this.grdBilling.TabIndex = 0;
            this.grdBilling.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBilling_CellEndEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bill No";
            // 
            // txt_BillNo
            // 
            this.txt_BillNo.Location = new System.Drawing.Point(159, 16);
            this.txt_BillNo.Name = "txt_BillNo";
            this.txt_BillNo.Size = new System.Drawing.Size(100, 20);
            this.txt_BillNo.TabIndex = 2;
            // 
            // lbl_cusName
            // 
            this.lbl_cusName.AutoSize = true;
            this.lbl_cusName.Location = new System.Drawing.Point(58, 56);
            this.lbl_cusName.Name = "lbl_cusName";
            this.lbl_cusName.Size = new System.Drawing.Size(82, 13);
            this.lbl_cusName.TabIndex = 3;
            this.lbl_cusName.Text = "Customer Name";
            // 
            // txt_CusName
            // 
            this.txt_CusName.Location = new System.Drawing.Point(159, 49);
            this.txt_CusName.Name = "txt_CusName";
            this.txt_CusName.Size = new System.Drawing.Size(100, 20);
            this.txt_CusName.TabIndex = 4;
            // 
            // lbl_cusAddress
            // 
            this.lbl_cusAddress.AutoSize = true;
            this.lbl_cusAddress.Location = new System.Drawing.Point(404, 23);
            this.lbl_cusAddress.Name = "lbl_cusAddress";
            this.lbl_cusAddress.Size = new System.Drawing.Size(92, 13);
            this.lbl_cusAddress.TabIndex = 5;
            this.lbl_cusAddress.Text = "Customer Address";
            // 
            // lbl_cusMobile
            // 
            this.lbl_cusMobile.AutoSize = true;
            this.lbl_cusMobile.Location = new System.Drawing.Point(58, 88);
            this.lbl_cusMobile.Name = "lbl_cusMobile";
            this.lbl_cusMobile.Size = new System.Drawing.Size(99, 13);
            this.lbl_cusMobile.TabIndex = 6;
            this.lbl_cusMobile.Text = "Customer MobileNo";
            // 
            // txt_cusMobile
            // 
            this.txt_cusMobile.Location = new System.Drawing.Point(159, 81);
            this.txt_cusMobile.Name = "txt_cusMobile";
            this.txt_cusMobile.Size = new System.Drawing.Size(100, 20);
            this.txt_cusMobile.TabIndex = 8;
            // 
            // rch_cusAddress
            // 
            this.rch_cusAddress.Location = new System.Drawing.Point(511, 5);
            this.rch_cusAddress.Name = "rch_cusAddress";
            this.rch_cusAddress.Size = new System.Drawing.Size(196, 64);
            this.rch_cusAddress.TabIndex = 9;
            this.rch_cusAddress.Text = "";
            // 
            // lbl_billDate
            // 
            this.lbl_billDate.AutoSize = true;
            this.lbl_billDate.Location = new System.Drawing.Point(404, 88);
            this.lbl_billDate.Name = "lbl_billDate";
            this.lbl_billDate.Size = new System.Drawing.Size(46, 13);
            this.lbl_billDate.TabIndex = 10;
            this.lbl_billDate.Text = "Bill Date";
            // 
            // dt_billDate
            // 
            this.dt_billDate.CustomFormat = "";
            this.dt_billDate.Location = new System.Drawing.Point(511, 88);
            this.dt_billDate.Name = "dt_billDate";
            this.dt_billDate.Size = new System.Drawing.Size(200, 20);
            this.dt_billDate.TabIndex = 11;
            this.dt_billDate.Value = new System.DateTime(2017, 8, 15, 0, 12, 54, 0);
            // 
            // lbl_pdtCount
            // 
            this.lbl_pdtCount.AutoSize = true;
            this.lbl_pdtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pdtCount.Location = new System.Drawing.Point(845, 152);
            this.lbl_pdtCount.Name = "lbl_pdtCount";
            this.lbl_pdtCount.Size = new System.Drawing.Size(121, 13);
            this.lbl_pdtCount.TabIndex = 12;
            this.lbl_pdtCount.Text = "Total Product Count";
            this.lbl_pdtCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_pdtCount
            // 
            this.txt_pdtCount.Location = new System.Drawing.Point(848, 177);
            this.txt_pdtCount.Name = "txt_pdtCount";
            this.txt_pdtCount.Size = new System.Drawing.Size(100, 20);
            this.txt_pdtCount.TabIndex = 13;
            // 
            // lbl_qauntCount
            // 
            this.lbl_qauntCount.AutoSize = true;
            this.lbl_qauntCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qauntCount.Location = new System.Drawing.Point(845, 222);
            this.lbl_qauntCount.Name = "lbl_qauntCount";
            this.lbl_qauntCount.Size = new System.Drawing.Size(124, 13);
            this.lbl_qauntCount.TabIndex = 14;
            this.lbl_qauntCount.Text = "Total Quantity Count";
            this.lbl_qauntCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_QuantCount
            // 
            this.txt_QuantCount.Location = new System.Drawing.Point(848, 252);
            this.txt_QuantCount.Name = "txt_QuantCount";
            this.txt_QuantCount.Size = new System.Drawing.Size(100, 20);
            this.txt_QuantCount.TabIndex = 15;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(390, 434);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 556);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_QuantCount);
            this.Controls.Add(this.lbl_qauntCount);
            this.Controls.Add(this.txt_pdtCount);
            this.Controls.Add(this.lbl_pdtCount);
            this.Controls.Add(this.dt_billDate);
            this.Controls.Add(this.lbl_billDate);
            this.Controls.Add(this.rch_cusAddress);
            this.Controls.Add(this.txt_cusMobile);
            this.Controls.Add(this.lbl_cusMobile);
            this.Controls.Add(this.lbl_cusAddress);
            this.Controls.Add(this.txt_CusName);
            this.Controls.Add(this.lbl_cusName);
            this.Controls.Add(this.txt_BillNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdBilling);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Billing";
            this.Text = "Billing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBilling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_BillNo;
        private System.Windows.Forms.Label lbl_cusName;
        private System.Windows.Forms.TextBox txt_CusName;
        private System.Windows.Forms.Label lbl_cusAddress;
        private System.Windows.Forms.Label lbl_cusMobile;
        private System.Windows.Forms.TextBox txt_cusMobile;
        private System.Windows.Forms.RichTextBox rch_cusAddress;
        private System.Windows.Forms.Label lbl_billDate;
        private System.Windows.Forms.DateTimePicker dt_billDate;
        private System.Windows.Forms.Label lbl_pdtCount;
        private System.Windows.Forms.TextBox txt_pdtCount;
        private System.Windows.Forms.Label lbl_qauntCount;
        private System.Windows.Forms.TextBox txt_QuantCount;
        private System.Windows.Forms.Button btn_Save;
    }
}