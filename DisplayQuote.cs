using System;
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

    public partial class DisplayQuote : Form
    {
        public static float quote; // The quote passed in
        public DisplayQuote(int Price)
        {
            quote = Price;
            InitializeComponent();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            try
            {
                QuotePrice.Text = quote + "$";
            }
            catch {
                Console.WriteLine("There was an error with the computed quote price.");
            }
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            this.Close();
            main.Show();
        }
    }
}
