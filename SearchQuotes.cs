﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Megadesk_1._0
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            this.Close();
            main.Show();
        }
    }
}
