using System;
using System.Windows.Forms;

namespace BankSystemProject
{
    partial class EmployeeSignUP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSignUP));
            this.panel7 = new System.Windows.Forms.Panel();
            this.SignUpEmployeeFinish = new System.Windows.Forms.Label();
            this.BankCode = new System.Windows.Forms.Label();
            this.EmployeeConfirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EmployeePassword = new System.Windows.Forms.TextBox();
            this.EmployeeID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel7.Controls.Add(this.SignUpEmployeeFinish);
            this.panel7.Location = new System.Drawing.Point(349, 477);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(238, 58);
            this.panel7.TabIndex = 58;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // SignUpEmployeeFinish
            // 
            this.SignUpEmployeeFinish.AutoSize = true;
            this.SignUpEmployeeFinish.Font = new System.Drawing.Font("Microsoft Uighur", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpEmployeeFinish.ForeColor = System.Drawing.Color.White;
            this.SignUpEmployeeFinish.Location = new System.Drawing.Point(63, 12);
            this.SignUpEmployeeFinish.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SignUpEmployeeFinish.Name = "SignUpEmployeeFinish";
            this.SignUpEmployeeFinish.Size = new System.Drawing.Size(114, 46);
            this.SignUpEmployeeFinish.TabIndex = 0;
            this.SignUpEmployeeFinish.Text = "Sign Up";
            this.SignUpEmployeeFinish.Click += new System.EventHandler(this.SignUpEmployeeFinish_Click);
            // 
            // BankCode
            // 
            this.BankCode.AutoSize = true;
            this.BankCode.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankCode.ForeColor = System.Drawing.Color.Black;
            this.BankCode.Location = new System.Drawing.Point(191, 350);
            this.BankCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BankCode.Name = "BankCode";
            this.BankCode.Size = new System.Drawing.Size(177, 34);
            this.BankCode.TabIndex = 64;
            this.BankCode.Text = "Confirm Password :";
            // 
            // EmployeeConfirmPassword
            // 
            this.EmployeeConfirmPassword.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeConfirmPassword.Location = new System.Drawing.Point(363, 352);
            this.EmployeeConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeConfirmPassword.Name = "EmployeeConfirmPassword";
            this.EmployeeConfirmPassword.Size = new System.Drawing.Size(314, 31);
            this.EmployeeConfirmPassword.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(259, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 34);
            this.label5.TabIndex = 62;
            this.label5.Text = "Password :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(237, 202);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 34);
            this.label12.TabIndex = 61;
            this.label12.Text = "Employee ID:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // EmployeePassword
            // 
            this.EmployeePassword.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeePassword.Location = new System.Drawing.Point(363, 276);
            this.EmployeePassword.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeePassword.Name = "EmployeePassword";
            this.EmployeePassword.Size = new System.Drawing.Size(314, 31);
            this.EmployeePassword.TabIndex = 60;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeID.Location = new System.Drawing.Point(363, 202);
            this.EmployeeID.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(314, 31);
            this.EmployeeID.TabIndex = 59;
            this.EmployeeID.TextChanged += new System.EventHandler(this.EmployeeID_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(349, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // EmployeeSignUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(929, 595);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.BankCode);
            this.Controls.Add(this.EmployeeConfirmPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.EmployeePassword);
            this.Controls.Add(this.EmployeeID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeSignUP";
            this.Text = "EmployeeSignUP";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label SignUpEmployeeFinish;
        private System.Windows.Forms.Label BankCode;
        private System.Windows.Forms.TextBox EmployeeConfirmPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EmployeePassword;
        private System.Windows.Forms.TextBox EmployeeID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}