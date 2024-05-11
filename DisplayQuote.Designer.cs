namespace Megadesk_1._0
{
    partial class DisplayQuote
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
            MainMenu = new Button();
            label1 = new Label();
            QuotePrice = new Label();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.Location = new Point(222, 199);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(150, 50);
            MainMenu.TabIndex = 3;
            MainMenu.Text = "Main Menu";
            MainMenu.UseVisualStyleBackColor = true;
            MainMenu.Click += MainMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(132, 30);
            label1.TabIndex = 4;
            label1.Text = "Quote Price:";
            // 
            // QuotePrice
            // 
            QuotePrice.AutoSize = true;
            QuotePrice.Font = new Font("Segoe UI", 16F);
            QuotePrice.Location = new Point(150, 22);
            QuotePrice.Name = "QuotePrice";
            QuotePrice.Size = new Size(0, 30);
            QuotePrice.TabIndex = 5;
            // 
            // DisplayQuote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(QuotePrice);
            Controls.Add(label1);
            Controls.Add(MainMenu);
            Name = "DisplayQuote";
            Text = "DisplayQuote";
            Load += DisplayQuote_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MainMenu;
        private Label label1;
        private Label QuotePrice;
    }
}