namespace Railway_Management_System
{
    partial class Employee_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sign_In = new System.Windows.Forms.Button();
            this.Password_Text = new System.Windows.Forms.TextBox();
            this.Username_Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Restore_down = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restore_down)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Sign_In);
            this.groupBox1.Controls.Add(this.Password_Text);
            this.groupBox1.Controls.Add(this.Username_Text);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(389, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 425);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Login";
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
            // Password_Text
            // 
            this.Password_Text.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Text.Location = new System.Drawing.Point(45, 236);
            this.Password_Text.Name = "Password_Text";
            this.Password_Text.Size = new System.Drawing.Size(262, 36);
            this.Password_Text.TabIndex = 6;
            // 
            // Username_Text
            // 
            this.Username_Text.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Text.Location = new System.Drawing.Point(45, 118);
            this.Username_Text.Name = "Username_Text";
            this.Username_Text.Size = new System.Drawing.Size(262, 36);
            this.Username_Text.TabIndex = 5;
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
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.Black;
            this.Close.Location = new System.Drawing.Point(1106, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(64, 56);
            this.Close.TabIndex = 6;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.Black;
            this.Minimize.Location = new System.Drawing.Point(963, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(51, 40);
            this.Minimize.TabIndex = 9;
            this.Minimize.Text = "_";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Restore_down
            // 
            this.Restore_down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restore_down.Image = ((System.Drawing.Image)(resources.GetObject("Restore_down.Image")));
            this.Restore_down.Location = new System.Drawing.Point(1041, 12);
            this.Restore_down.Name = "Restore_down";
            this.Restore_down.Size = new System.Drawing.Size(59, 50);
            this.Restore_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restore_down.TabIndex = 8;
            this.Restore_down.TabStop = false;
            this.Restore_down.Click += new System.EventHandler(this.Restore_down_Click);
            // 
            // Employee_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Restore_down);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employee_Login";
            this.Text = "Employee_Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restore_down)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Sign_In;
        private System.Windows.Forms.TextBox Password_Text;
        private System.Windows.Forms.TextBox Username_Text;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.PictureBox Restore_down;
    }
}