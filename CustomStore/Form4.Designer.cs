namespace CustomStore
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.customerCustomer = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IDCustomer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // customerCustomer
            // 
            this.customerCustomer.BackColor = System.Drawing.Color.White;
            this.customerCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customerCustomer.Location = new System.Drawing.Point(154, 185);
            this.customerCustomer.Name = "customerCustomer";
            this.customerCustomer.Size = new System.Drawing.Size(218, 26);
            this.customerCustomer.TabIndex = 12;
            // 
            // phoneNumber
            // 
            this.phoneNumber.BackColor = System.Drawing.Color.White;
            this.phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNumber.Location = new System.Drawing.Point(154, 232);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(218, 26);
            this.phoneNumber.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.RosyBrown;
            this.label12.Location = new System.Drawing.Point(49, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 28);
            this.label12.TabIndex = 18;
            this.label12.Text = "Customer";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.RosyBrown;
            this.label13.Location = new System.Drawing.Point(12, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 28);
            this.label13.TabIndex = 19;
            this.label13.Text = "Phone number";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save.Location = new System.Drawing.Point(171, 320);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(76, 40);
            this.Save.TabIndex = 20;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(130, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 36);
            this.label1.TabIndex = 21;
            this.label1.Text = "New record";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RosyBrown;
            this.label9.Location = new System.Drawing.Point(111, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "ID";
            // 
            // IDCustomer
            // 
            this.IDCustomer.BackColor = System.Drawing.Color.White;
            this.IDCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDCustomer.Location = new System.Drawing.Point(154, 137);
            this.IDCustomer.Name = "IDCustomer";
            this.IDCustomer.Size = new System.Drawing.Size(218, 26);
            this.IDCustomer.TabIndex = 11;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(432, 405);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.customerCustomer);
            this.Controls.Add(this.IDCustomer);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox customerCustomer;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IDCustomer;
    }
}