﻿namespace Railway_Management_System
{
    partial class Passenger_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passenger_Login));
            this.Back = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sign_Up_label = new System.Windows.Forms.Label();
            this.Sign_In = new System.Windows.Forms.Button();
            this.Password_Login = new System.Windows.Forms.TextBox();
            this.Username_Login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(63, 50);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 12;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.Sign_Up_label);
            this.groupBox1.Controls.Add(this.Sign_In);
            this.groupBox1.Controls.Add(this.Password_Login);
            this.groupBox1.Controls.Add(this.Username_Login);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(397, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 436);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Passenger Login";
            // 
            // Sign_Up_label
            // 
            this.Sign_Up_label.AutoSize = true;
            this.Sign_Up_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign_Up_label.Location = new System.Drawing.Point(18, 285);
            this.Sign_Up_label.Name = "Sign_Up_label";
            this.Sign_Up_label.Size = new System.Drawing.Size(324, 23);
            this.Sign_Up_label.TabIndex = 8;
            this.Sign_Up_label.Text = "Dont have an account? SIGN UP";
            this.Sign_Up_label.Click += new System.EventHandler(this.Sign_Up_label_Click);
            // 
            // Sign_In
            // 
            this.Sign_In.BackColor = System.Drawing.Color.Navy;
            this.Sign_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sign_In.ForeColor = System.Drawing.Color.White;
            this.Sign_In.Location = new System.Drawing.Point(82, 321);
            this.Sign_In.Name = "Sign_In";
            this.Sign_In.Size = new System.Drawing.Size(172, 49);
            this.Sign_In.TabIndex = 7;
            this.Sign_In.Text = "Sign In";
            this.Sign_In.UseVisualStyleBackColor = false;
            this.Sign_In.Click += new System.EventHandler(this.Sign_In_Click);
            // 
            // Password_Login
            // 
            this.Password_Login.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Login.Location = new System.Drawing.Point(45, 236);
            this.Password_Login.Name = "Password_Login";
            this.Password_Login.Size = new System.Drawing.Size(262, 36);
            this.Password_Login.TabIndex = 6;
            // 
            // Username_Login
            // 
            this.Username_Login.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Login.Location = new System.Drawing.Point(45, 118);
            this.Username_Login.Name = "Username_Login";
            this.Username_Login.Size = new System.Drawing.Size(262, 36);
            this.Username_Login.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(40, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(40, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // Passenger_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Passenger_Login";
            this.Text = "Passenger Login";
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Sign_Up_label;
        private System.Windows.Forms.Button Sign_In;
        private System.Windows.Forms.TextBox Password_Login;
        private System.Windows.Forms.TextBox Username_Login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}