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
            this.GroupBox_Login = new System.Windows.Forms.GroupBox();
            this.Sign_Up_label = new System.Windows.Forms.Label();
            this.Sign_In = new System.Windows.Forms.Button();
            this.Password_Login = new System.Windows.Forms.TextBox();
            this.Username_Login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupBox_SignUp = new System.Windows.Forms.GroupBox();
            this.Error_phone_Number = new System.Windows.Forms.Label();
            this.X_Phone_Number = new System.Windows.Forms.PictureBox();
            this.Phone_Number_Text = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Error_Password = new System.Windows.Forms.Label();
            this.Error_Username = new System.Windows.Forms.Label();
            this.Error_SSN = new System.Windows.Forms.Label();
            this.Error_Lname = new System.Windows.Forms.Label();
            this.Error_Minit = new System.Windows.Forms.Label();
            this.Error_Fname = new System.Windows.Forms.Label();
            this.X_Password = new System.Windows.Forms.PictureBox();
            this.X_Minit = new System.Windows.Forms.PictureBox();
            this.X_Lname = new System.Windows.Forms.PictureBox();
            this.X_SSN = new System.Windows.Forms.PictureBox();
            this.X_UserName = new System.Windows.Forms.PictureBox();
            this.X_Fname = new System.Windows.Forms.PictureBox();
            this.Back_To_login = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SSN_Text = new System.Windows.Forms.TextBox();
            this.Lname_Text = new System.Windows.Forms.TextBox();
            this.Minit_Text = new System.Windows.Forms.TextBox();
            this.Fname_Text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sign_Up = new System.Windows.Forms.Button();
            this.Password_SignUp_Text = new System.Windows.Forms.TextBox();
            this.Username_Signup_Text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.GroupBox_Login.SuspendLayout();
            this.GroupBox_SignUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.X_Phone_Number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_Minit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_Lname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_SSN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_UserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_Fname)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.Location = new System.Drawing.Point(12, 7);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(63, 50);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 12;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // GroupBox_Login
            // 
            this.GroupBox_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupBox_Login.Controls.Add(this.Sign_Up_label);
            this.GroupBox_Login.Controls.Add(this.Sign_In);
            this.GroupBox_Login.Controls.Add(this.Password_Login);
            this.GroupBox_Login.Controls.Add(this.Username_Login);
            this.GroupBox_Login.Controls.Add(this.label4);
            this.GroupBox_Login.Controls.Add(this.label2);
            this.GroupBox_Login.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Login.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GroupBox_Login.Location = new System.Drawing.Point(283, 117);
            this.GroupBox_Login.Name = "GroupBox_Login";
            this.GroupBox_Login.Size = new System.Drawing.Size(374, 436);
            this.GroupBox_Login.TabIndex = 10;
            this.GroupBox_Login.TabStop = false;
            this.GroupBox_Login.Text = "Passenger Login";
            // 
            // Sign_Up_label
            // 
            this.Sign_Up_label.AutoSize = true;
            this.Sign_Up_label.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.Sign_In.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.Password_Login.TabIndex = 1;
            // 
            // Username_Login
            // 
            this.Username_Login.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Login.Location = new System.Drawing.Point(45, 118);
            this.Username_Login.Name = "Username_Login";
            this.Username_Login.Size = new System.Drawing.Size(262, 36);
            this.Username_Login.TabIndex = 0;
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
            // GroupBox_SignUp
            // 
            this.GroupBox_SignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupBox_SignUp.Controls.Add(this.Error_phone_Number);
            this.GroupBox_SignUp.Controls.Add(this.X_Phone_Number);
            this.GroupBox_SignUp.Controls.Add(this.Phone_Number_Text);
            this.GroupBox_SignUp.Controls.Add(this.label11);
            this.GroupBox_SignUp.Controls.Add(this.Error_Password);
            this.GroupBox_SignUp.Controls.Add(this.Error_Username);
            this.GroupBox_SignUp.Controls.Add(this.Error_SSN);
            this.GroupBox_SignUp.Controls.Add(this.Error_Lname);
            this.GroupBox_SignUp.Controls.Add(this.Error_Minit);
            this.GroupBox_SignUp.Controls.Add(this.Error_Fname);
            this.GroupBox_SignUp.Controls.Add(this.X_Password);
            this.GroupBox_SignUp.Controls.Add(this.X_Minit);
            this.GroupBox_SignUp.Controls.Add(this.X_Lname);
            this.GroupBox_SignUp.Controls.Add(this.X_SSN);
            this.GroupBox_SignUp.Controls.Add(this.X_UserName);
            this.GroupBox_SignUp.Controls.Add(this.X_Fname);
            this.GroupBox_SignUp.Controls.Add(this.Back_To_login);
            this.GroupBox_SignUp.Controls.Add(this.dateTimePicker1);
            this.GroupBox_SignUp.Controls.Add(this.comboBox1);
            this.GroupBox_SignUp.Controls.Add(this.SSN_Text);
            this.GroupBox_SignUp.Controls.Add(this.Lname_Text);
            this.GroupBox_SignUp.Controls.Add(this.Minit_Text);
            this.GroupBox_SignUp.Controls.Add(this.Fname_Text);
            this.GroupBox_SignUp.Controls.Add(this.label10);
            this.GroupBox_SignUp.Controls.Add(this.label9);
            this.GroupBox_SignUp.Controls.Add(this.label8);
            this.GroupBox_SignUp.Controls.Add(this.label7);
            this.GroupBox_SignUp.Controls.Add(this.label6);
            this.GroupBox_SignUp.Controls.Add(this.label1);
            this.GroupBox_SignUp.Controls.Add(this.Sign_Up);
            this.GroupBox_SignUp.Controls.Add(this.Password_SignUp_Text);
            this.GroupBox_SignUp.Controls.Add(this.Username_Signup_Text);
            this.GroupBox_SignUp.Controls.Add(this.label3);
            this.GroupBox_SignUp.Controls.Add(this.label5);
            this.GroupBox_SignUp.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_SignUp.ForeColor = System.Drawing.Color.MidnightBlue;
            this.GroupBox_SignUp.Location = new System.Drawing.Point(283, 117);
            this.GroupBox_SignUp.Name = "GroupBox_SignUp";
            this.GroupBox_SignUp.Size = new System.Drawing.Size(862, 578);
            this.GroupBox_SignUp.TabIndex = 13;
            this.GroupBox_SignUp.TabStop = false;
            this.GroupBox_SignUp.Text = "Passenger SIGNUP";
            this.GroupBox_SignUp.Visible = false;
            // 
            // Error_phone_Number
            // 
            this.Error_phone_Number.AutoSize = true;
            this.Error_phone_Number.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_phone_Number.ForeColor = System.Drawing.Color.Red;
            this.Error_phone_Number.Location = new System.Drawing.Point(529, 267);
            this.Error_phone_Number.Name = "Error_phone_Number";
            this.Error_phone_Number.Size = new System.Drawing.Size(322, 19);
            this.Error_phone_Number.TabIndex = 36;
            this.Error_phone_Number.Text = "Phone number must consist of 11Digits";
            this.Error_phone_Number.Visible = false;
            // 
            // X_Phone_Number
            // 
            this.X_Phone_Number.Image = ((System.Drawing.Image)(resources.GetObject("X_Phone_Number.Image")));
            this.X_Phone_Number.Location = new System.Drawing.Point(482, 260);
            this.X_Phone_Number.Name = "X_Phone_Number";
            this.X_Phone_Number.Size = new System.Drawing.Size(41, 32);
            this.X_Phone_Number.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.X_Phone_Number.TabIndex = 35;
            this.X_Phone_Number.TabStop = false;
            this.X_Phone_Number.Visible = false;
            // 
            // Phone_Number_Text
            // 
            this.Phone_Number_Text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_Number_Text.Location = new System.Drawing.Point(197, 254);
            this.Phone_Number_Text.Name = "Phone_Number_Text";
            this.Phone_Number_Text.Size = new System.Drawing.Size(262, 32);
            this.Phone_Number_Text.TabIndex = 7;
            this.Phone_Number_Text.TextChanged += new System.EventHandler(this.Phone_Number_Text_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(36, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 23);
            this.label11.TabIndex = 33;
            this.label11.Text = "Phone Number";
            // 
            // Error_Password
            // 
            this.Error_Password.AutoSize = true;
            this.Error_Password.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Password.ForeColor = System.Drawing.Color.Red;
            this.Error_Password.Location = new System.Drawing.Point(529, 353);
            this.Error_Password.Name = "Error_Password";
            this.Error_Password.Size = new System.Drawing.Size(313, 19);
            this.Error_Password.TabIndex = 32;
            this.Error_Password.Text = "Password must be at least 7char long";
            this.Error_Password.Visible = false;
            // 
            // Error_Username
            // 
            this.Error_Username.AutoSize = true;
            this.Error_Username.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Username.ForeColor = System.Drawing.Color.Red;
            this.Error_Username.Location = new System.Drawing.Point(529, 309);
            this.Error_Username.Name = "Error_Username";
            this.Error_Username.Size = new System.Drawing.Size(322, 19);
            this.Error_Username.TabIndex = 31;
            this.Error_Username.Text = "Username must be at least 5 char long";
            this.Error_Username.Visible = false;
            // 
            // Error_SSN
            // 
            this.Error_SSN.AutoSize = true;
            this.Error_SSN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_SSN.ForeColor = System.Drawing.Color.Red;
            this.Error_SSN.Location = new System.Drawing.Point(529, 220);
            this.Error_SSN.Name = "Error_SSN";
            this.Error_SSN.Size = new System.Drawing.Size(237, 19);
            this.Error_SSN.TabIndex = 30;
            this.Error_SSN.Text = "SSN must consist of 14 digits";
            this.Error_SSN.Visible = false;
            // 
            // Error_Lname
            // 
            this.Error_Lname.AutoSize = true;
            this.Error_Lname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Lname.ForeColor = System.Drawing.Color.Red;
            this.Error_Lname.Location = new System.Drawing.Point(529, 171);
            this.Error_Lname.Name = "Error_Lname";
            this.Error_Lname.Size = new System.Drawing.Size(210, 19);
            this.Error_Lname.TabIndex = 29;
            this.Error_Lname.Text = "Lname cannot be empty";
            this.Error_Lname.Visible = false;
            // 
            // Error_Minit
            // 
            this.Error_Minit.AutoSize = true;
            this.Error_Minit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Minit.ForeColor = System.Drawing.Color.Red;
            this.Error_Minit.Location = new System.Drawing.Point(529, 121);
            this.Error_Minit.Name = "Error_Minit";
            this.Error_Minit.Size = new System.Drawing.Size(173, 19);
            this.Error_Minit.TabIndex = 28;
            this.Error_Minit.Text = "Minit must be 1 char";
            this.Error_Minit.Visible = false;
            // 
            // Error_Fname
            // 
            this.Error_Fname.AutoSize = true;
            this.Error_Fname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Fname.ForeColor = System.Drawing.Color.Red;
            this.Error_Fname.Location = new System.Drawing.Point(529, 72);
            this.Error_Fname.Name = "Error_Fname";
            this.Error_Fname.Size = new System.Drawing.Size(211, 19);
            this.Error_Fname.TabIndex = 27;
            this.Error_Fname.Text = "Fname cannot be empty";
            this.Error_Fname.Visible = false;
            // 
            // X_Password
            // 
            this.X_Password.Image = ((System.Drawing.Image)(resources.GetObject("X_Password.Image")));
            this.X_Password.Location = new System.Drawing.Point(482, 347);
            this.X_Password.Name = "X_Password";
            this.X_Password.Size = new System.Drawing.Size(41, 32);
            this.X_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.X_Password.TabIndex = 26;
            this.X_Password.TabStop = false;
            this.X_Password.Visible = false;
            // 
            // X_Minit
            // 
            this.X_Minit.Image = ((System.Drawing.Image)(resources.GetObject("X_Minit.Image")));
            this.X_Minit.Location = new System.Drawing.Point(482, 114);
            this.X_Minit.Name = "X_Minit";
            this.X_Minit.Size = new System.Drawing.Size(41, 32);
            this.X_Minit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.X_Minit.TabIndex = 25;
            this.X_Minit.TabStop = false;
            this.X_Minit.Visible = false;
            // 
            // X_Lname
            // 
            this.X_Lname.Image = ((System.Drawing.Image)(resources.GetObject("X_Lname.Image")));
            this.X_Lname.Location = new System.Drawing.Point(482, 164);
            this.X_Lname.Name = "X_Lname";
            this.X_Lname.Size = new System.Drawing.Size(41, 32);
            this.X_Lname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.X_Lname.TabIndex = 24;
            this.X_Lname.TabStop = false;
            this.X_Lname.Visible = false;
            // 
            // X_SSN
            // 
            this.X_SSN.Image = ((System.Drawing.Image)(resources.GetObject("X_SSN.Image")));
            this.X_SSN.Location = new System.Drawing.Point(482, 214);
            this.X_SSN.Name = "X_SSN";
            this.X_SSN.Size = new System.Drawing.Size(41, 32);
            this.X_SSN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.X_SSN.TabIndex = 23;
            this.X_SSN.TabStop = false;
            this.X_SSN.Visible = false;
            // 
            // X_UserName
            // 
            this.X_UserName.Image = ((System.Drawing.Image)(resources.GetObject("X_UserName.Image")));
            this.X_UserName.Location = new System.Drawing.Point(482, 302);
            this.X_UserName.Name = "X_UserName";
            this.X_UserName.Size = new System.Drawing.Size(41, 32);
            this.X_UserName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.X_UserName.TabIndex = 22;
            this.X_UserName.TabStop = false;
            this.X_UserName.Visible = false;
            // 
            // X_Fname
            // 
            this.X_Fname.Image = ((System.Drawing.Image)(resources.GetObject("X_Fname.Image")));
            this.X_Fname.Location = new System.Drawing.Point(482, 66);
            this.X_Fname.Name = "X_Fname";
            this.X_Fname.Size = new System.Drawing.Size(41, 32);
            this.X_Fname.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.X_Fname.TabIndex = 21;
            this.X_Fname.TabStop = false;
            this.X_Fname.Visible = false;
            // 
            // Back_To_login
            // 
            this.Back_To_login.AutoSize = true;
            this.Back_To_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_To_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_To_login.Location = new System.Drawing.Point(425, 529);
            this.Back_To_login.Name = "Back_To_login";
            this.Back_To_login.Size = new System.Drawing.Size(153, 23);
            this.Back_To_login.TabIndex = 20;
            this.Back_To_login.Text = "Back_To_Login";
            this.Back_To_login.Click += new System.EventHandler(this.Back_To_login_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(188, 448);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 23);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBox1.Location = new System.Drawing.Point(197, 396);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 31);
            this.comboBox1.TabIndex = 10;
            // 
            // SSN_Text
            // 
            this.SSN_Text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSN_Text.Location = new System.Drawing.Point(197, 214);
            this.SSN_Text.Name = "SSN_Text";
            this.SSN_Text.Size = new System.Drawing.Size(262, 32);
            this.SSN_Text.TabIndex = 6;
            this.SSN_Text.TextChanged += new System.EventHandler(this.SSN_Text_TextChanged);
            // 
            // Lname_Text
            // 
            this.Lname_Text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname_Text.Location = new System.Drawing.Point(197, 164);
            this.Lname_Text.Name = "Lname_Text";
            this.Lname_Text.Size = new System.Drawing.Size(262, 32);
            this.Lname_Text.TabIndex = 5;
            this.Lname_Text.TextChanged += new System.EventHandler(this.Lname_Text_TextChanged);
            // 
            // Minit_Text
            // 
            this.Minit_Text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minit_Text.Location = new System.Drawing.Point(197, 114);
            this.Minit_Text.Name = "Minit_Text";
            this.Minit_Text.Size = new System.Drawing.Size(262, 32);
            this.Minit_Text.TabIndex = 4;
            this.Minit_Text.TextChanged += new System.EventHandler(this.Minit_Text_TextChanged);
            // 
            // Fname_Text
            // 
            this.Fname_Text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname_Text.Location = new System.Drawing.Point(197, 66);
            this.Fname_Text.Name = "Fname_Text";
            this.Fname_Text.Size = new System.Drawing.Size(262, 32);
            this.Fname_Text.TabIndex = 3;
            this.Fname_Text.TextChanged += new System.EventHandler(this.Fname_Text_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(40, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Gender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(40, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Date Of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(40, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Minit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(40, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Lname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(40, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(40, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "SSN";
            // 
            // Sign_Up
            // 
            this.Sign_Up.BackColor = System.Drawing.Color.Navy;
            this.Sign_Up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sign_Up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sign_Up.ForeColor = System.Drawing.Color.White;
            this.Sign_Up.Location = new System.Drawing.Point(197, 514);
            this.Sign_Up.Name = "Sign_Up";
            this.Sign_Up.Size = new System.Drawing.Size(172, 49);
            this.Sign_Up.TabIndex = 7;
            this.Sign_Up.Text = "Sign_Up";
            this.Sign_Up.UseVisualStyleBackColor = false;
            this.Sign_Up.Click += new System.EventHandler(this.Sign_Up_Click);
            // 
            // Password_SignUp_Text
            // 
            this.Password_SignUp_Text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_SignUp_Text.Location = new System.Drawing.Point(197, 347);
            this.Password_SignUp_Text.Name = "Password_SignUp_Text";
            this.Password_SignUp_Text.Size = new System.Drawing.Size(262, 32);
            this.Password_SignUp_Text.TabIndex = 9;
            this.Password_SignUp_Text.TextChanged += new System.EventHandler(this.Password_SignUp_Text_TextChanged);
            // 
            // Username_Signup_Text
            // 
            this.Username_Signup_Text.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Signup_Text.Location = new System.Drawing.Point(197, 302);
            this.Username_Signup_Text.Name = "Username_Signup_Text";
            this.Username_Signup_Text.Size = new System.Drawing.Size(262, 32);
            this.Username_Signup_Text.TabIndex = 8;
            this.Username_Signup_Text.TextChanged += new System.EventHandler(this.Username_Signup_Text_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(40, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(40, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.Back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 57);
            this.panel1.TabIndex = 14;
            // 
            // Passenger_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GroupBox_SignUp);
            this.Controls.Add(this.GroupBox_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Passenger_Login";
            this.Text = "Passenger Login";
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.GroupBox_Login.ResumeLayout(false);
            this.GroupBox_Login.PerformLayout();
            this.GroupBox_SignUp.ResumeLayout(false);
            this.GroupBox_SignUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.X_Phone_Number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_Minit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_Lname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_SSN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_UserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_Fname)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.GroupBox GroupBox_Login;
        private System.Windows.Forms.Label Sign_Up_label;
        private System.Windows.Forms.Button Sign_In;
        private System.Windows.Forms.TextBox Password_Login;
        private System.Windows.Forms.TextBox Username_Login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GroupBox_SignUp;
        private System.Windows.Forms.Label Error_phone_Number;
        private System.Windows.Forms.PictureBox X_Phone_Number;
        private System.Windows.Forms.TextBox Phone_Number_Text;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Error_Password;
        private System.Windows.Forms.Label Error_Username;
        private System.Windows.Forms.Label Error_SSN;
        private System.Windows.Forms.Label Error_Lname;
        private System.Windows.Forms.Label Error_Minit;
        private System.Windows.Forms.Label Error_Fname;
        private System.Windows.Forms.PictureBox X_Password;
        private System.Windows.Forms.PictureBox X_Minit;
        private System.Windows.Forms.PictureBox X_Lname;
        private System.Windows.Forms.PictureBox X_SSN;
        private System.Windows.Forms.PictureBox X_UserName;
        private System.Windows.Forms.PictureBox X_Fname;
        private System.Windows.Forms.Label Back_To_login;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox SSN_Text;
        private System.Windows.Forms.TextBox Lname_Text;
        private System.Windows.Forms.TextBox Minit_Text;
        private System.Windows.Forms.TextBox Fname_Text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sign_Up;
        private System.Windows.Forms.TextBox Password_SignUp_Text;
        private System.Windows.Forms.TextBox Username_Signup_Text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}