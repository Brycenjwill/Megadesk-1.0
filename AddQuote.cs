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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            this.Close();
            main.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void DepthInput_ValueChanged(object sender, EventArgs e)
        {

        }


        private void WidthInput_Validating(object sender, CancelEventArgs e)
        {
            int input = Convert.ToInt32(WidthInput.Text);
            if (input <= 12 || input >= 48) // When the inputted value is out of range. . .
            {

                WidthInput.ForeColor = Color.Red;
                WidthInput.Focus();

            }
            else
            {
                WidthInput.ForeColor = Color.Black;
            }
        }

        private void DepthInput_Validation(object sender, KeyPressEventArgs e)
        {
            {
                char input = e.KeyChar;

                if (Char.IsControl(input) == true || Char.IsDigit(input) == false)
                {
                    DepthInput.ForeColor = Color.Red;

                }
                else
                {
                    DepthInput.ForeColor = Color.Black;
                }
            }
        }

        private void SubmitQuoteButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            int price = 200;
            price += Convert.ToInt32(50 * NumberOfDrawersInput.Value);
            //Create new desk with all data gotten so far
            int area = Convert.ToInt32(DepthInput.Text) * Convert.ToInt32(WidthInput.Text);
            if(area > 1000)
            {
                price += (area - 1000);
            }
            DisplayQuote displayQuote = new DisplayQuote(price);
            displayQuote.Show();
        }
    }
}
