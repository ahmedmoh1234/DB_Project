namespace Railway_Management_System
{
    partial class Employee_Form
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
            this.sparePartsButton = new System.Windows.Forms.Button();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.sparePartsGroupBox = new System.Windows.Forms.GroupBox();
            this.orderGroupBox = new System.Windows.Forms.GroupBox();
            this.orderPartNoLabel = new System.Windows.Forms.Label();
            this.orderAmountLabel = new System.Windows.Forms.Label();
            this.orderAmountTextBox = new System.Windows.Forms.TextBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.decGroupBox = new System.Windows.Forms.GroupBox();
            this.decAmountLabel = new System.Windows.Forms.Label();
            this.decAmountTextBox = new System.Windows.Forms.TextBox();
            this.decrementButton = new System.Windows.Forms.Button();
            this.sparePartDataGridView = new System.Windows.Forms.DataGridView();
            this.scheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.maintenanceGroupBox = new System.Windows.Forms.GroupBox();
            this.maintenanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.changeDateButton = new System.Windows.Forms.Button();
            this.scheduleGroupBox = new System.Windows.Forms.GroupBox();
            this.sparePartsGroupBox.SuspendLayout();
            this.orderGroupBox.SuspendLayout();
            this.decGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).BeginInit();
            this.maintenanceGroupBox.SuspendLayout();
            this.scheduleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sparePartsButton
            // 
            this.sparePartsButton.BackColor = System.Drawing.Color.Navy;
            this.sparePartsButton.FlatAppearance.BorderSize = 0;
            this.sparePartsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.sparePartsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sparePartsButton.ForeColor = System.Drawing.Color.White;
            this.sparePartsButton.Location = new System.Drawing.Point(-1, 0);
            this.sparePartsButton.Name = "sparePartsButton";
            this.sparePartsButton.Size = new System.Drawing.Size(112, 226);
            this.sparePartsButton.TabIndex = 3;
            this.sparePartsButton.Text = "Spare Parts";
            this.sparePartsButton.UseVisualStyleBackColor = false;
            this.sparePartsButton.Click += new System.EventHandler(this.sparePartsButton_Click);
            // 
            // scheduleButton
            // 
            this.scheduleButton.BackColor = System.Drawing.Color.Navy;
            this.scheduleButton.FlatAppearance.BorderSize = 0;
            this.scheduleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.scheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scheduleButton.ForeColor = System.Drawing.Color.White;
            this.scheduleButton.Location = new System.Drawing.Point(-1, 226);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(112, 226);
            this.scheduleButton.TabIndex = 5;
            this.scheduleButton.Text = "Schedule";
            this.scheduleButton.UseVisualStyleBackColor = false;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // sparePartsGroupBox
            // 
            this.sparePartsGroupBox.Controls.Add(this.orderGroupBox);
            this.sparePartsGroupBox.Controls.Add(this.decGroupBox);
            this.sparePartsGroupBox.Controls.Add(this.sparePartDataGridView);
            this.sparePartsGroupBox.Location = new System.Drawing.Point(117, 12);
            this.sparePartsGroupBox.Name = "sparePartsGroupBox";
            this.sparePartsGroupBox.Size = new System.Drawing.Size(671, 413);
            this.sparePartsGroupBox.TabIndex = 6;
            this.sparePartsGroupBox.TabStop = false;
            this.sparePartsGroupBox.Text = "Spare Parts";
            this.sparePartsGroupBox.Visible = false;
            // 
            // orderGroupBox
            // 
            this.orderGroupBox.Controls.Add(this.orderPartNoLabel);
            this.orderGroupBox.Controls.Add(this.orderAmountLabel);
            this.orderGroupBox.Controls.Add(this.orderAmountTextBox);
            this.orderGroupBox.Controls.Add(this.orderButton);
            this.orderGroupBox.Location = new System.Drawing.Point(36, 214);
            this.orderGroupBox.Name = "orderGroupBox";
            this.orderGroupBox.Size = new System.Drawing.Size(259, 179);
            this.orderGroupBox.TabIndex = 11;
            this.orderGroupBox.TabStop = false;
            this.orderGroupBox.Text = "Order";
            // 
            // orderPartNoLabel
            // 
            this.orderPartNoLabel.AutoSize = true;
            this.orderPartNoLabel.Location = new System.Drawing.Point(59, 25);
            this.orderPartNoLabel.Name = "orderPartNoLabel";
            this.orderPartNoLabel.Size = new System.Drawing.Size(129, 13);
            this.orderPartNoLabel.TabIndex = 13;
            this.orderPartNoLabel.Text = "Please select a spare part";
            // 
            // orderAmountLabel
            // 
            this.orderAmountLabel.AutoSize = true;
            this.orderAmountLabel.Location = new System.Drawing.Point(35, 61);
            this.orderAmountLabel.Name = "orderAmountLabel";
            this.orderAmountLabel.Size = new System.Drawing.Size(49, 13);
            this.orderAmountLabel.TabIndex = 10;
            this.orderAmountLabel.Text = "Amount :";
            // 
            // orderAmountTextBox
            // 
            this.orderAmountTextBox.Location = new System.Drawing.Point(90, 57);
            this.orderAmountTextBox.Name = "orderAmountTextBox";
            this.orderAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderAmountTextBox.TabIndex = 7;
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.Navy;
            this.orderButton.FlatAppearance.BorderSize = 0;
            this.orderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.ForeColor = System.Drawing.Color.White;
            this.orderButton.Location = new System.Drawing.Point(56, 121);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(134, 37);
            this.orderButton.TabIndex = 8;
            this.orderButton.Text = "Order Spare Parts";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // decGroupBox
            // 
            this.decGroupBox.Controls.Add(this.decAmountLabel);
            this.decGroupBox.Controls.Add(this.decAmountTextBox);
            this.decGroupBox.Controls.Add(this.decrementButton);
            this.decGroupBox.Location = new System.Drawing.Point(384, 214);
            this.decGroupBox.Name = "decGroupBox";
            this.decGroupBox.Size = new System.Drawing.Size(259, 179);
            this.decGroupBox.TabIndex = 10;
            this.decGroupBox.TabStop = false;
            this.decGroupBox.Text = "Decrement";
            // 
            // decAmountLabel
            // 
            this.decAmountLabel.AutoSize = true;
            this.decAmountLabel.Location = new System.Drawing.Point(35, 61);
            this.decAmountLabel.Name = "decAmountLabel";
            this.decAmountLabel.Size = new System.Drawing.Size(49, 13);
            this.decAmountLabel.TabIndex = 10;
            this.decAmountLabel.Text = "Amount :";
            // 
            // decAmountTextBox
            // 
            this.decAmountTextBox.Location = new System.Drawing.Point(90, 57);
            this.decAmountTextBox.Name = "decAmountTextBox";
            this.decAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.decAmountTextBox.TabIndex = 7;
            // 
            // decrementButton
            // 
            this.decrementButton.BackColor = System.Drawing.Color.Navy;
            this.decrementButton.FlatAppearance.BorderSize = 0;
            this.decrementButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.decrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrementButton.ForeColor = System.Drawing.Color.White;
            this.decrementButton.Location = new System.Drawing.Point(56, 121);
            this.decrementButton.Name = "decrementButton";
            this.decrementButton.Size = new System.Drawing.Size(134, 37);
            this.decrementButton.TabIndex = 9;
            this.decrementButton.Text = "Decrement Spare Parts";
            this.decrementButton.UseVisualStyleBackColor = false;
            this.decrementButton.Click += new System.EventHandler(this.decrementButton_Click);
            // 
            // sparePartDataGridView
            // 
            this.sparePartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sparePartDataGridView.Location = new System.Drawing.Point(6, 30);
            this.sparePartDataGridView.Name = "sparePartDataGridView";
            this.sparePartDataGridView.RowHeadersWidth = 51;
            this.sparePartDataGridView.Size = new System.Drawing.Size(659, 163);
            this.sparePartDataGridView.TabIndex = 7;
            this.sparePartDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sparePartDataGridView_RowHeaderMouseClick);
            // 
            // scheduleDataGridView
            // 
            this.scheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGridView.Location = new System.Drawing.Point(6, 30);
            this.scheduleDataGridView.Name = "scheduleDataGridView";
            this.scheduleDataGridView.RowHeadersWidth = 51;
            this.scheduleDataGridView.Size = new System.Drawing.Size(659, 163);
            this.scheduleDataGridView.TabIndex = 7;
            // 
            // maintenanceGroupBox
            // 
            this.maintenanceGroupBox.Controls.Add(this.maintenanceDateTimePicker);
            this.maintenanceGroupBox.Controls.Add(this.label2);
            this.maintenanceGroupBox.Controls.Add(this.changeDateButton);
            this.maintenanceGroupBox.Location = new System.Drawing.Point(170, 228);
            this.maintenanceGroupBox.Name = "maintenanceGroupBox";
            this.maintenanceGroupBox.Size = new System.Drawing.Size(319, 179);
            this.maintenanceGroupBox.TabIndex = 10;
            this.maintenanceGroupBox.TabStop = false;
            this.maintenanceGroupBox.Text = "Maintenance";
            // 
            // maintenanceDateTimePicker
            // 
            this.maintenanceDateTimePicker.Location = new System.Drawing.Point(100, 57);
            this.maintenanceDateTimePicker.Name = "maintenanceDateTimePicker";
            this.maintenanceDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.maintenanceDateTimePicker.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "New Date :";
            // 
            // changeDateButton
            // 
            this.changeDateButton.BackColor = System.Drawing.Color.Navy;
            this.changeDateButton.FlatAppearance.BorderSize = 0;
            this.changeDateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.changeDateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeDateButton.ForeColor = System.Drawing.Color.White;
            this.changeDateButton.Location = new System.Drawing.Point(100, 121);
            this.changeDateButton.Name = "changeDateButton";
            this.changeDateButton.Size = new System.Drawing.Size(134, 37);
            this.changeDateButton.TabIndex = 9;
            this.changeDateButton.Text = "Change Date";
            this.changeDateButton.UseVisualStyleBackColor = false;
            // 
            // scheduleGroupBox
            // 
            this.scheduleGroupBox.Controls.Add(this.maintenanceGroupBox);
            this.scheduleGroupBox.Controls.Add(this.scheduleDataGridView);
            this.scheduleGroupBox.Location = new System.Drawing.Point(117, 12);
            this.scheduleGroupBox.Name = "scheduleGroupBox";
            this.scheduleGroupBox.Size = new System.Drawing.Size(671, 413);
            this.scheduleGroupBox.TabIndex = 12;
            this.scheduleGroupBox.TabStop = false;
            this.scheduleGroupBox.Text = "Schedule";
            this.scheduleGroupBox.Visible = false;
            // 
            // Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scheduleButton);
            this.Controls.Add(this.sparePartsButton);
            this.Controls.Add(this.sparePartsGroupBox);
            this.Controls.Add(this.scheduleGroupBox);
            this.Name = "Employee_Form";
            this.Text = "Employee_Form";
            this.Load += new System.EventHandler(this.Employee_Form_Load);
            this.sparePartsGroupBox.ResumeLayout(false);
            this.orderGroupBox.ResumeLayout(false);
            this.orderGroupBox.PerformLayout();
            this.decGroupBox.ResumeLayout(false);
            this.decGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sparePartDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).EndInit();
            this.maintenanceGroupBox.ResumeLayout(false);
            this.maintenanceGroupBox.PerformLayout();
            this.scheduleGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button sparePartsButton;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.GroupBox sparePartsGroupBox;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.DataGridView sparePartDataGridView;
        private System.Windows.Forms.Button decrementButton;
        private System.Windows.Forms.GroupBox orderGroupBox;
        private System.Windows.Forms.Label orderAmountLabel;
        private System.Windows.Forms.TextBox orderAmountTextBox;
        private System.Windows.Forms.GroupBox decGroupBox;
        private System.Windows.Forms.Label decAmountLabel;
        private System.Windows.Forms.TextBox decAmountTextBox;
        private System.Windows.Forms.DataGridView scheduleDataGridView;
        private System.Windows.Forms.GroupBox maintenanceGroupBox;
        private System.Windows.Forms.DateTimePicker maintenanceDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changeDateButton;
        private System.Windows.Forms.GroupBox scheduleGroupBox;
        private System.Windows.Forms.Label orderPartNoLabel;
    }
}