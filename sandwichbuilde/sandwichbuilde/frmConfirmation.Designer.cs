namespace sandwichbuilde
{
    partial class frmConfirmation
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
            this.lblOrderdetilce = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.LblDisplayTotal = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOrderdetilce
            // 
            this.lblOrderdetilce.AutoSize = true;
            this.lblOrderdetilce.Location = new System.Drawing.Point(23, 34);
            this.lblOrderdetilce.Name = "lblOrderdetilce";
            this.lblOrderdetilce.Size = new System.Drawing.Size(102, 20);
            this.lblOrderdetilce.TabIndex = 0;
            this.lblOrderdetilce.Text = "Order Datlice";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 221);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(903, 465);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 20);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total :";
            // 
            // LblDisplayTotal
            // 
            this.LblDisplayTotal.AutoSize = true;
            this.LblDisplayTotal.Location = new System.Drawing.Point(987, 465);
            this.LblDisplayTotal.Name = "LblDisplayTotal";
            this.LblDisplayTotal.Size = new System.Drawing.Size(95, 20);
            this.LblDisplayTotal.TabIndex = 3;
            this.LblDisplayTotal.Text = "DisplayTotal";
            this.LblDisplayTotal.Click += new System.EventHandler(this.LblDisplayTotal_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(401, 492);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(182, 42);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 575);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.LblDisplayTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblOrderdetilce);
            this.Name = "frmConfirmation";
            this.Text = "frmConfirmation";
            this.Load += new System.EventHandler(this.frmConfirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderdetilce;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label LblDisplayTotal;
        private System.Windows.Forms.Button btnSubmit;
    }
}