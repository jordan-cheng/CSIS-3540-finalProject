﻿namespace ClientServerProject
{
    partial class PaymentLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnUserBack = new System.Windows.Forms.Button();
            this.btnUserLog = new System.Windows.Forms.Button();
            this.txtUserPW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter Your Room Number and Password";
            // 
            // btnUserBack
            // 
            this.btnUserBack.Location = new System.Drawing.Point(280, 130);
            this.btnUserBack.Name = "btnUserBack";
            this.btnUserBack.Size = new System.Drawing.Size(75, 23);
            this.btnUserBack.TabIndex = 11;
            this.btnUserBack.Text = "Back";
            this.btnUserBack.UseVisualStyleBackColor = true;
            // 
            // btnUserLog
            // 
            this.btnUserLog.Location = new System.Drawing.Point(185, 130);
            this.btnUserLog.Name = "btnUserLog";
            this.btnUserLog.Size = new System.Drawing.Size(75, 23);
            this.btnUserLog.TabIndex = 10;
            this.btnUserLog.Text = "Login";
            this.btnUserLog.UseVisualStyleBackColor = true;
            // 
            // txtUserPW
            // 
            this.txtUserPW.Location = new System.Drawing.Point(230, 74);
            this.txtUserPW.Name = "txtUserPW";
            this.txtUserPW.Size = new System.Drawing.Size(141, 20);
            this.txtUserPW.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(230, 31);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(141, 20);
            this.txtUser.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "RoomNumber";
            // 
            // PaymentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUserBack);
            this.Controls.Add(this.btnUserLog);
            this.Controls.Add(this.txtUserPW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "PaymentLogin";
            this.Size = new System.Drawing.Size(539, 185);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUserBack;
        private System.Windows.Forms.Button btnUserLog;
        private System.Windows.Forms.TextBox txtUserPW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
    }
}
