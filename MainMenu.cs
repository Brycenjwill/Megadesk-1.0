namespace Megadesk_1._0
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        private void AddNewQuoteButton_Click(object sender, EventArgs e)
        {
            Form newQuote = new AddQuote();
            newQuote.Show();
            this.Hide();
        }

        private void ViewQuotesButton_Click(object sender, EventArgs e)
        {
            Form viewAll = new ViewAllQuotes();
            viewAll.Show();
            this.Hide();
        }

        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            Form newSearch = new SearchQuotes();
            newSearch.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
