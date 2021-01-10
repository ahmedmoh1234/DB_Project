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
            this.decLabel = new System.Windows.Forms.Label();
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
            this.TrainNumberTextBox = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
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
            this.sparePartsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sparePartsButton.Name = "sparePartsButton";
            this.sparePartsButton.Size = new System.Drawing.Size(149, 278);
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
            this.scheduleButton.Location = new System.Drawing.Point(-1, 278);
            this.scheduleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(149, 278);
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
            this.sparePartsGroupBox.Location = new System.Drawing.Point(156, 15);
            this.sparePartsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sparePartsGroupBox.Name = "sparePartsGroupBox";
            this.sparePartsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sparePartsGroupBox.Size = new System.Drawing.Size(895, 508);
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
            this.orderGroupBox.Location = new System.Drawing.Point(48, 263);
            this.orderGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderGroupBox.Name = "orderGroupBox";
            this.orderGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderGroupBox.Size = new System.Drawing.Size(345, 220);
            this.orderGroupBox.TabIndex = 11;
            this.orderGroupBox.TabStop = false;
            this.orderGroupBox.Text = "Order";
            // 
            // orderPartNoLabel
            // 
            this.orderPartNoLabel.AutoSize = true;
            this.orderPartNoLabel.Location = new System.Drawing.Point(79, 31);
            this.orderPartNoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderPartNoLabel.Name = "orderPartNoLabel";
            this.orderPartNoLabel.Size = new System.Drawing.Size(173, 17);
            this.orderPartNoLabel.TabIndex = 13;
            this.orderPartNoLabel.Text = "Please select a spare part";
            // 
            // orderAmountLabel
            // 
            this.orderAmountLabel.AutoSize = true;
            this.orderAmountLabel.Location = new System.Drawing.Point(47, 75);
            this.orderAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderAmountLabel.Name = "orderAmountLabel";
            this.orderAmountLabel.Size = new System.Drawing.Size(64, 17);
            this.orderAmountLabel.TabIndex = 10;
            this.orderAmountLabel.Text = "Amount :";
            // 
            // orderAmountTextBox
            // 
            this.orderAmountTextBox.Location = new System.Drawing.Point(120, 70);
            this.orderAmountTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderAmountTextBox.Name = "orderAmountTextBox";
            this.orderAmountTextBox.Size = new System.Drawing.Size(132, 22);
            this.orderAmountTextBox.TabIndex = 7;
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.Navy;
            this.orderButton.FlatAppearance.BorderSize = 0;
            this.orderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.ForeColor = System.Drawing.Color.White;
            this.orderButton.Location = new System.Drawing.Point(75, 149);
            this.orderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(179, 46);
            this.orderButton.TabIndex = 8;
            this.orderButton.Text = "Order Spare Parts";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // decGroupBox
            // 
            this.decGroupBox.Controls.Add(this.decLabel);
            this.decGroupBox.Controls.Add(this.decAmountLabel);
            this.decGroupBox.Controls.Add(this.decAmountTextBox);
            this.decGroupBox.Controls.Add(this.decrementButton);
            this.decGroupBox.Location = new System.Drawing.Point(512, 263);
            this.decGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.decGroupBox.Name = "decGroupBox";
            this.decGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.decGroupBox.Size = new System.Drawing.Size(345, 220);
            this.decGroupBox.TabIndex = 10;
            this.decGroupBox.TabStop = false;
            this.decGroupBox.Text = "Decrement";
            // 
            // decLabel
            // 
            this.decLabel.AutoSize = true;
            this.decLabel.Location = new System.Drawing.Point(79, 31);
            this.decLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.decLabel.Name = "decLabel";
            this.decLabel.Size = new System.Drawing.Size(173, 17);
            this.decLabel.TabIndex = 14;
            this.decLabel.Text = "Please select a spare part";
            // 
            // decAmountLabel
            // 
            this.decAmountLabel.AutoSize = true;
            this.decAmountLabel.Location = new System.Drawing.Point(47, 75);
            this.decAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.decAmountLabel.Name = "decAmountLabel";
            this.decAmountLabel.Size = new System.Drawing.Size(64, 17);
            this.decAmountLabel.TabIndex = 10;
            this.decAmountLabel.Text = "Amount :";
            // 
            // decAmountTextBox
            // 
            this.decAmountTextBox.Location = new System.Drawing.Point(120, 70);
            this.decAmountTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.decAmountTextBox.Name = "decAmountTextBox";
            this.decAmountTextBox.Size = new System.Drawing.Size(132, 22);
            this.decAmountTextBox.TabIndex = 7;
            // 
            // decrementButton
            // 
            this.decrementButton.BackColor = System.Drawing.Color.Navy;
            this.decrementButton.FlatAppearance.BorderSize = 0;
            this.decrementButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.decrementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrementButton.ForeColor = System.Drawing.Color.White;
            this.decrementButton.Location = new System.Drawing.Point(75, 149);
            this.decrementButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.decrementButton.Name = "decrementButton";
            this.decrementButton.Size = new System.Drawing.Size(179, 46);
            this.decrementButton.TabIndex = 9;
            this.decrementButton.Text = "Decrement Spare Parts";
            this.decrementButton.UseVisualStyleBackColor = false;
            this.decrementButton.Click += new System.EventHandler(this.decrementButton_Click);
            // 
            // sparePartDataGridView
            // 
            this.sparePartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sparePartDataGridView.Location = new System.Drawing.Point(8, 37);
            this.sparePartDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sparePartDataGridView.Name = "sparePartDataGridView";
            this.sparePartDataGridView.RowHeadersWidth = 51;
            this.sparePartDataGridView.Size = new System.Drawing.Size(879, 201);
            this.sparePartDataGridView.TabIndex = 7;
            this.sparePartDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.sparePartDataGridView_RowHeaderMouseClick);
            // 
            // scheduleDataGridView
            // 
            this.scheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGridView.Location = new System.Drawing.Point(8, 37);
            this.scheduleDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scheduleDataGridView.Name = "scheduleDataGridView";
            this.scheduleDataGridView.RowHeadersWidth = 51;
            this.scheduleDataGridView.Size = new System.Drawing.Size(879, 201);
            this.scheduleDataGridView.TabIndex = 7;
            this.scheduleDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.scheduleDataGridView_RowHeaderMouseClick);
            // 
            // maintenanceGroupBox
            // 
            this.maintenanceGroupBox.Controls.Add(this.TrainNumberTextBox);
            this.maintenanceGroupBox.Controls.Add(this.label33);
            this.maintenanceGroupBox.Controls.Add(this.maintenanceDateTimePicker);
            this.maintenanceGroupBox.Controls.Add(this.label2);
            this.maintenanceGroupBox.Controls.Add(this.changeDateButton);
            this.maintenanceGroupBox.Location = new System.Drawing.Point(227, 281);
            this.maintenanceGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maintenanceGroupBox.Name = "maintenanceGroupBox";
            this.maintenanceGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maintenanceGroupBox.Size = new System.Drawing.Size(425, 220);
            this.maintenanceGroupBox.TabIndex = 10;
            this.maintenanceGroupBox.TabStop = false;
            this.maintenanceGroupBox.Text = "Maintenance";
            // 
            // maintenanceDateTimePicker
            // 
            this.maintenanceDateTimePicker.Location = new System.Drawing.Point(135, 98);
            this.maintenanceDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maintenanceDateTimePicker.Name = "maintenanceDateTimePicker";
            this.maintenanceDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.maintenanceDateTimePicker.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
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
            this.changeDateButton.Location = new System.Drawing.Point(133, 149);
            this.changeDateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.changeDateButton.Name = "changeDateButton";
            this.changeDateButton.Size = new System.Drawing.Size(179, 46);
            this.changeDateButton.TabIndex = 9;
            this.changeDateButton.Text = "Change Date";
            this.changeDateButton.UseVisualStyleBackColor = false;
            this.changeDateButton.Click += new System.EventHandler(this.changeDateButton_Click);
            // 
            // scheduleGroupBox
            // 
            this.scheduleGroupBox.Controls.Add(this.maintenanceGroupBox);
            this.scheduleGroupBox.Controls.Add(this.scheduleDataGridView);
            this.scheduleGroupBox.Location = new System.Drawing.Point(156, 15);
            this.scheduleGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scheduleGroupBox.Name = "scheduleGroupBox";
            this.scheduleGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scheduleGroupBox.Size = new System.Drawing.Size(895, 508);
            this.scheduleGroupBox.TabIndex = 12;
            this.scheduleGroupBox.TabStop = false;
            this.scheduleGroupBox.Text = "Schedule";
            this.scheduleGroupBox.Visible = false;
            // 
            // TrainNumberTextBox
            // 
            this.TrainNumberTextBox.Location = new System.Drawing.Point(173, 54);
            this.TrainNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrainNumberTextBox.Name = "TrainNumberTextBox";
            this.TrainNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.TrainNumberTextBox.TabIndex = 13;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(50, 57);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(95, 17);
            this.label33.TabIndex = 12;
            this.label33.Text = "Train Number";
            // 
            // Employee_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.scheduleButton);
            this.Controls.Add(this.sparePartsButton);
            this.Controls.Add(this.scheduleGroupBox);
            this.Controls.Add(this.sparePartsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label decLabel;
        private System.Windows.Forms.TextBox TrainNumberTextBox;
        private System.Windows.Forms.Label label33;
    }
}