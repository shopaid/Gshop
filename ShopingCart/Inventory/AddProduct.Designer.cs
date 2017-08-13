namespace ShopingCart.Inventory
{
    partial class AddProduct
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
            this.txt_pdtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pdtBuy = new System.Windows.Forms.TextBox();
            this.txt_pdtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_PdtDisc = new System.Windows.Forms.TextBox();
            this.txt_PdtGst = new System.Windows.Forms.TextBox();
            this.txt_PdtSell = new System.Windows.Forms.TextBox();
            this.txt_PdtPurchase = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_PdtQuantity = new System.Windows.Forms.TextBox();
            this.rdn_Inclusive = new System.Windows.Forms.RadioButton();
            this.rdn_Exclusive = new System.Windows.Forms.RadioButton();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grdProductView = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_pdtId
            // 
            this.txt_pdtId.Location = new System.Drawing.Point(207, 56);
            this.txt_pdtId.Name = "txt_pdtId";
            this.txt_pdtId.Size = new System.Drawing.Size(100, 20);
            this.txt_pdtId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Buy Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_pdtBuy
            // 
            this.txt_pdtBuy.Location = new System.Drawing.Point(207, 145);
            this.txt_pdtBuy.Name = "txt_pdtBuy";
            this.txt_pdtBuy.Size = new System.Drawing.Size(100, 20);
            this.txt_pdtBuy.TabIndex = 4;
            this.txt_pdtBuy.Text = "0";
            // 
            // txt_pdtName
            // 
            this.txt_pdtName.Location = new System.Drawing.Point(207, 97);
            this.txt_pdtName.Name = "txt_pdtName";
            this.txt_pdtName.Size = new System.Drawing.Size(100, 20);
            this.txt_pdtName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product GST";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product Sell Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Product Purchase Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(83, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Product Discount";
            // 
            // txt_PdtDisc
            // 
            this.txt_PdtDisc.Location = new System.Drawing.Point(207, 266);
            this.txt_PdtDisc.Name = "txt_PdtDisc";
            this.txt_PdtDisc.Size = new System.Drawing.Size(100, 20);
            this.txt_PdtDisc.TabIndex = 10;
            this.txt_PdtDisc.Text = "0";
            // 
            // txt_PdtGst
            // 
            this.txt_PdtGst.Location = new System.Drawing.Point(207, 225);
            this.txt_PdtGst.Name = "txt_PdtGst";
            this.txt_PdtGst.Size = new System.Drawing.Size(100, 20);
            this.txt_PdtGst.TabIndex = 11;
            this.txt_PdtGst.Text = "0";
            // 
            // txt_PdtSell
            // 
            this.txt_PdtSell.Location = new System.Drawing.Point(207, 184);
            this.txt_PdtSell.Name = "txt_PdtSell";
            this.txt_PdtSell.Size = new System.Drawing.Size(100, 20);
            this.txt_PdtSell.TabIndex = 12;
            this.txt_PdtSell.Text = "0";
            // 
            // txt_PdtPurchase
            // 
            this.txt_PdtPurchase.Location = new System.Drawing.Point(207, 295);
            this.txt_PdtPurchase.Name = "txt_PdtPurchase";
            this.txt_PdtPurchase.Size = new System.Drawing.Size(100, 20);
            this.txt_PdtPurchase.TabIndex = 13;
            this.txt_PdtPurchase.Text = "8/12/2017 12:00:00 AM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Product Tax Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Product Quantity";
            // 
            // txt_PdtQuantity
            // 
            this.txt_PdtQuantity.Location = new System.Drawing.Point(207, 334);
            this.txt_PdtQuantity.Name = "txt_PdtQuantity";
            this.txt_PdtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txt_PdtQuantity.TabIndex = 16;
            this.txt_PdtQuantity.Text = "0";
            // 
            // rdn_Inclusive
            // 
            this.rdn_Inclusive.AutoSize = true;
            this.rdn_Inclusive.Checked = true;
            this.rdn_Inclusive.Location = new System.Drawing.Point(207, 371);
            this.rdn_Inclusive.Name = "rdn_Inclusive";
            this.rdn_Inclusive.Size = new System.Drawing.Size(88, 17);
            this.rdn_Inclusive.TabIndex = 17;
            this.rdn_Inclusive.TabStop = true;
            this.rdn_Inclusive.Text = "Inclusive Tax";
            this.rdn_Inclusive.UseVisualStyleBackColor = true;
            // 
            // rdn_Exclusive
            // 
            this.rdn_Exclusive.AutoSize = true;
            this.rdn_Exclusive.Location = new System.Drawing.Point(207, 407);
            this.rdn_Exclusive.Name = "rdn_Exclusive";
            this.rdn_Exclusive.Size = new System.Drawing.Size(91, 17);
            this.rdn_Exclusive.TabIndex = 18;
            this.rdn_Exclusive.Text = "Exclusive Tax";
            this.rdn_Exclusive.UseVisualStyleBackColor = true;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(539, 424);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 19;
            this.btn_Submit.Text = "Add";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(730, 424);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(829, 424);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grdProductView
            // 
            this.grdProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductView.Location = new System.Drawing.Point(323, 59);
            this.grdProductView.Name = "grdProductView";
            this.grdProductView.Size = new System.Drawing.Size(940, 295);
            this.grdProductView.TabIndex = 22;
            this.grdProductView.SelectionChanged += new System.EventHandler(this.grdProductView_SelectionChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(635, 424);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(923, 424);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 495);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grdProductView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.rdn_Exclusive);
            this.Controls.Add(this.rdn_Inclusive);
            this.Controls.Add(this.txt_PdtQuantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_PdtPurchase);
            this.Controls.Add(this.txt_PdtSell);
            this.Controls.Add(this.txt_PdtGst);
            this.Controls.Add(this.txt_PdtDisc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_pdtName);
            this.Controls.Add(this.txt_pdtBuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pdtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_pdtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pdtBuy;
        private System.Windows.Forms.TextBox txt_pdtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_PdtDisc;
        private System.Windows.Forms.TextBox txt_PdtGst;
        private System.Windows.Forms.TextBox txt_PdtSell;
        private System.Windows.Forms.TextBox txt_PdtPurchase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_PdtQuantity;
        private System.Windows.Forms.RadioButton rdn_Inclusive;
        private System.Windows.Forms.RadioButton rdn_Exclusive;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView grdProductView;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
    }
}