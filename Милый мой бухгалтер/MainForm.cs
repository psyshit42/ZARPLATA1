﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Add = new AddWorker();
            var NewBranch = new Branch("VOVA");
            var Save = new Control();
            Save.SaveBranch(NewBranch);
            Add.Show();
        }
    }
}
