namespace AdvC__Lab7
{
    partial class Form1
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
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnRegisterProduct = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbProoduct = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reg. date:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(93, 115);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(258, 20);
            this.txtDate.TabIndex = 5;
            // 
            // btnRegisterProduct
            // 
            this.btnRegisterProduct.Location = new System.Drawing.Point(16, 162);
            this.btnRegisterProduct.Name = "btnRegisterProduct";
            this.btnRegisterProduct.Size = new System.Drawing.Size(103, 23);
            this.btnRegisterProduct.TabIndex = 6;
            this.btnRegisterProduct.Text = "Register Product";
            this.btnRegisterProduct.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(139, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(277, 162);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // cbCustomer
            // 
            this.cbCustomer.DisplayMember = "CustomerID";
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(93, 34);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(259, 21);
            this.cbCustomer.TabIndex = 9;
            this.cbCustomer.ValueMember = "CustomerID";
            // 
            // cbProoduct
            // 
            this.cbProoduct.DisplayMember = "ProductCode";
            this.cbProoduct.FormattingEnabled = true;
            this.cbProoduct.Location = new System.Drawing.Point(93, 77);
            this.cbProoduct.Name = "cbProoduct";
            this.cbProoduct.Size = new System.Drawing.Size(258, 21);
            this.cbProoduct.TabIndex = 10;
            this.cbProoduct.ValueMember = "ProductCode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 204);
            this.Controls.Add(this.cbProoduct);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegisterProduct);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnRegisterProduct;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbProoduct;
    }
}

