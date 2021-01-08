﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway_Management_System
{
    public partial class Employee_Form : Form
    {
        public Employee_Form()
        {
            InitializeComponent();
        }

        private void sparePartsButton_Click(object sender, EventArgs e)
        {
            if (sparePartsGroupBox.Visible == false)
                sparePartsGroupBox.Visible = true;

            if (scheduleGroupBox.Visible == true)
                scheduleGroupBox.Visible = false;
        }

        private void decrementButton_Click(object sender, EventArgs e)
        {
            //must select a spare part from datagridview

        }


        private void Employee_Form_Load(object sender, EventArgs e)
        {
            sparePartsGroupBox.Visible = true;
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            if (sparePartsGroupBox.Visible == true)
                sparePartsGroupBox.Visible = false;

            if (scheduleGroupBox.Visible == false)
                scheduleGroupBox.Visible = true;
        }
    }
}