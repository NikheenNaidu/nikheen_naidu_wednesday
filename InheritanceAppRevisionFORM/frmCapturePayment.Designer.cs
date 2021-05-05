
namespace InheritanceAppRevisionFORM
{
    partial class frmCapturePayment
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.txbReference = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.pnlCash = new System.Windows.Forms.Panel();
            this.txbCurrency = new System.Windows.Forms.TextBox();
            this.txbChange = new System.Windows.Forms.TextBox();
            this.txbTendered = new System.Windows.Forms.TextBox();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.txbProvider = new System.Windows.Forms.TextBox();
            this.txbDigits = new System.Windows.Forms.TextBox();
            this.txbHolder = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.pnlCash.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(255, 43);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(200, 23);
            this.txbID.TabIndex = 0;
            this.txbID.Text = "Order ID";
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(255, 197);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(200, 23);
            this.txbAmount.TabIndex = 2;
            this.txbAmount.Text = "Amount";
            // 
            // txbReference
            // 
            this.txbReference.Location = new System.Drawing.Point(255, 282);
            this.txbReference.Name = "txbReference";
            this.txbReference.Size = new System.Drawing.Size(200, 23);
            this.txbReference.TabIndex = 3;
            this.txbReference.Text = "Reference";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(255, 128);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 23);
            this.dtpDate.TabIndex = 4;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.cmbType.Location = new System.Drawing.Point(255, 355);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(200, 23);
            this.cmbType.TabIndex = 5;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // pnlCash
            // 
            this.pnlCash.Controls.Add(this.txbCurrency);
            this.pnlCash.Controls.Add(this.txbChange);
            this.pnlCash.Controls.Add(this.txbTendered);
            this.pnlCash.Location = new System.Drawing.Point(622, 73);
            this.pnlCash.Name = "pnlCash";
            this.pnlCash.Size = new System.Drawing.Size(292, 161);
            this.pnlCash.TabIndex = 6;
            this.pnlCash.Visible = false;
            // 
            // txbCurrency
            // 
            this.txbCurrency.Location = new System.Drawing.Point(90, 124);
            this.txbCurrency.Name = "txbCurrency";
            this.txbCurrency.Size = new System.Drawing.Size(100, 23);
            this.txbCurrency.TabIndex = 10;
            this.txbCurrency.Text = "Currency";
            // 
            // txbChange
            // 
            this.txbChange.Location = new System.Drawing.Point(90, 77);
            this.txbChange.Name = "txbChange";
            this.txbChange.Size = new System.Drawing.Size(100, 23);
            this.txbChange.TabIndex = 9;
            this.txbChange.Text = "Change";
            // 
            // txbTendered
            // 
            this.txbTendered.Location = new System.Drawing.Point(90, 24);
            this.txbTendered.Name = "txbTendered";
            this.txbTendered.Size = new System.Drawing.Size(100, 23);
            this.txbTendered.TabIndex = 8;
            this.txbTendered.Text = "Tendered";
            // 
            // pnlCard
            // 
            this.pnlCard.Controls.Add(this.txbProvider);
            this.pnlCard.Controls.Add(this.txbDigits);
            this.pnlCard.Controls.Add(this.txbHolder);
            this.pnlCard.Location = new System.Drawing.Point(622, 309);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(292, 198);
            this.pnlCard.TabIndex = 7;
            this.pnlCard.Visible = false;
            // 
            // txbProvider
            // 
            this.txbProvider.Location = new System.Drawing.Point(90, 126);
            this.txbProvider.Name = "txbProvider";
            this.txbProvider.Size = new System.Drawing.Size(100, 23);
            this.txbProvider.TabIndex = 2;
            this.txbProvider.Text = "Provider";
            // 
            // txbDigits
            // 
            this.txbDigits.Location = new System.Drawing.Point(90, 76);
            this.txbDigits.Name = "txbDigits";
            this.txbDigits.Size = new System.Drawing.Size(100, 23);
            this.txbDigits.TabIndex = 1;
            this.txbDigits.Text = "Last 4 Digits";
            // 
            // txbHolder
            // 
            this.txbHolder.Location = new System.Drawing.Point(90, 19);
            this.txbHolder.Name = "txbHolder";
            this.txbHolder.Size = new System.Drawing.Size(100, 23);
            this.txbHolder.TabIndex = 0;
            this.txbHolder.Text = "Holder";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(288, 461);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(622, 33);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(83, 15);
            this.lblCash.TabIndex = 9;
            this.lblCash.Text = "Cash Payment";
            this.lblCash.Visible = false;
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(622, 270);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(89, 15);
            this.lblCredit.TabIndex = 10;
            this.lblCredit.Text = "Credit Payment";
            this.lblCredit.Visible = false;
            // 
            // frmCapturePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 581);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.pnlCash);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txbReference);
            this.Controls.Add(this.txbAmount);
            this.Controls.Add(this.txbID);
            this.Name = "frmCapturePayment";
            this.Text = "Form1";
            this.pnlCash.ResumeLayout(false);
            this.pnlCash.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.TextBox txbReference;
        private System.Windows.Forms.DateTimePicker dtpValue;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Panel pnlCash;
        private System.Windows.Forms.TextBox txbCurrency;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txb;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.TextBox txbProvider;
        private System.Windows.Forms.TextBox txbDigits;
        private System.Windows.Forms.TextBox txbHolder;
        private System.Windows.Forms.TextBox txbChange;
        private System.Windows.Forms.TextBox txbTendered;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lablCredit;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}

