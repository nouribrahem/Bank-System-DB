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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BranchNumber = new System.Windows.Forms.TextBox();
            this.EmployeeName = new System.Windows.Forms.TextBox();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel7.Controls.Add(this.SignUpEmployeeFinish);
            this.panel7.Location = new System.Drawing.Point(465, 587);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(317, 71);
            this.panel7.TabIndex = 58;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // SignUpEmployeeFinish
            // 
            this.SignUpEmployeeFinish.AutoSize = true;
            this.SignUpEmployeeFinish.Font = new System.Drawing.Font("Microsoft Uighur", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpEmployeeFinish.ForeColor = System.Drawing.Color.White;
            this.SignUpEmployeeFinish.Location = new System.Drawing.Point(84, 15);
            this.SignUpEmployeeFinish.Name = "SignUpEmployeeFinish";
            this.SignUpEmployeeFinish.Size = new System.Drawing.Size(138, 56);
            this.SignUpEmployeeFinish.TabIndex = 0;
            this.SignUpEmployeeFinish.Text = "Sign Up";
            this.SignUpEmployeeFinish.Click += new System.EventHandler(this.SignUpEmployeeFinish_Click);
            // 
            // BankCode
            // 
            this.BankCode.AutoSize = true;
            this.BankCode.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankCode.ForeColor = System.Drawing.Color.Black;
            this.BankCode.Location = new System.Drawing.Point(255, 523);
            this.BankCode.Name = "BankCode";
            this.BankCode.Size = new System.Drawing.Size(213, 39);
            this.BankCode.TabIndex = 64;
            this.BankCode.Text = "Confirm Password :";
            // 
            // EmployeeConfirmPassword
            // 
            this.EmployeeConfirmPassword.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeConfirmPassword.Location = new System.Drawing.Point(484, 525);
            this.EmployeeConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeConfirmPassword.Name = "EmployeeConfirmPassword";
            this.EmployeeConfirmPassword.Size = new System.Drawing.Size(417, 37);
            this.EmployeeConfirmPassword.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(345, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 39);
            this.label5.TabIndex = 62;
            this.label5.Text = "Password :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(316, 386);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 39);
            this.label12.TabIndex = 61;
            this.label12.Text = "Employee ID:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // EmployeePassword
            // 
            this.EmployeePassword.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeePassword.Location = new System.Drawing.Point(484, 454);
            this.EmployeePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeePassword.Name = "EmployeePassword";
            this.EmployeePassword.Size = new System.Drawing.Size(417, 37);
            this.EmployeePassword.TabIndex = 60;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeID.Location = new System.Drawing.Point(484, 386);
            this.EmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(417, 37);
            this.EmployeeID.TabIndex = 59;
            this.EmployeeID.TextChanged += new System.EventHandler(this.EmployeeID_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(465, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(281, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 39);
            this.label1.TabIndex = 69;
            this.label1.Text = "Branch Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(278, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 39);
            this.label2.TabIndex = 68;
            this.label2.Text = "Employee Name :";
            // 
            // BranchNumber
            // 
            this.BranchNumber.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchNumber.Location = new System.Drawing.Point(484, 314);
            this.BranchNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BranchNumber.Name = "BranchNumber";
            this.BranchNumber.Size = new System.Drawing.Size(417, 37);
            this.BranchNumber.TabIndex = 67;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeName.Location = new System.Drawing.Point(484, 246);
            this.EmployeeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Size = new System.Drawing.Size(417, 37);
            this.EmployeeName.TabIndex = 66;
            // 
            // EmployeeSignUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1239, 732);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BranchNumber);
            this.Controls.Add(this.EmployeeName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.BankCode);
            this.Controls.Add(this.EmployeeConfirmPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.EmployeePassword);
            this.Controls.Add(this.EmployeeID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeSignUP";
            this.Text = "EmployeeSignUP";
            this.Load += new System.EventHandler(this.EmployeeSignUP_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
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
        private Label label1;
        private Label label2;
        private TextBox BranchNumber;
        private TextBox EmployeeName;
    }
}