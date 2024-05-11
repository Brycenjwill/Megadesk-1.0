namespace Megadesk_1._0
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddNewQuoteButton = new Button();
            SearchQuotesButton = new Button();
            ViewQuotesButton = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // AddNewQuoteButton
            // 
            AddNewQuoteButton.Location = new Point(12, 12);
            AddNewQuoteButton.Name = "AddNewQuoteButton";
            AddNewQuoteButton.Size = new Size(150, 50);
            AddNewQuoteButton.TabIndex = 0;
            AddNewQuoteButton.Text = "Add New Quote";
            AddNewQuoteButton.UseVisualStyleBackColor = true;
            AddNewQuoteButton.Click += AddNewQuoteButton_Click;
            // 
            // SearchQuotesButton
            // 
            SearchQuotesButton.Location = new Point(12, 138);
            SearchQuotesButton.Name = "SearchQuotesButton";
            SearchQuotesButton.Size = new Size(150, 50);
            SearchQuotesButton.TabIndex = 1;
            SearchQuotesButton.Text = "SearchQuotes";
            SearchQuotesButton.UseVisualStyleBackColor = true;
            SearchQuotesButton.Click += SearchQuotes_Click;
            // 
            // ViewQuotesButton
            // 
            ViewQuotesButton.Location = new Point(12, 75);
            ViewQuotesButton.Name = "ViewQuotesButton";
            ViewQuotesButton.Size = new Size(150, 50);
            ViewQuotesButton.TabIndex = 2;
            ViewQuotesButton.Text = "View Quotes";
            ViewQuotesButton.UseVisualStyleBackColor = true;
            ViewQuotesButton.Click += ViewQuotesButton_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(12, 199);
            Exit.Name = "Exit";
            Exit.Size = new Size(150, 50);
            Exit.TabIndex = 3;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(Exit);
            Controls.Add(ViewQuotesButton);
            Controls.Add(SearchQuotesButton);
            Controls.Add(AddNewQuoteButton);
            Name = "MainMenu";
            Text = "Megadesk 1.0";
            ResumeLayout(false);
        }

        #endregion

        private Button AddNewQuoteButton;
        private Button SearchQuotesButton;
        private Button ViewQuotesButton;
        private Button Exit;
    }
}
