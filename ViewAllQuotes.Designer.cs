namespace Megadesk_1._0
{
    partial class ViewAllQuotes
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
            // ViewAllQuotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(MainMenu);
            Name = "ViewAllQuotes";
            Text = "Megadesk 1.0";
            Load += ViewAllQuotes_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button MainMenu;
    }
}