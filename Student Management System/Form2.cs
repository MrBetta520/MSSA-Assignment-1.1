﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Student_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEnterSystem_Click(object sender, EventArgs e)
        {
            this.Hide();

            fStudentManagement f1 = new fStudentManagement();
            f1.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
