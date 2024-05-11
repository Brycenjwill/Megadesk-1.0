namespace Megadesk_1._0
{
    partial class AddQuote
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
            label2 = new Label();
            CustomerNameInput = new TextBox();
            label3 = new Label();
            W = new Label();
            label4 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            NumberOfDrawersInput = new NumericUpDown();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            MaterialInput = new TextBox();
            DepthInput = new TextBox();
            WidthInput = new TextBox();
            SubmitQuoteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)NumberOfDrawersInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // MainMenu
            // 
            MainMenu.Font = new Font("Segoe UI", 12F);
            MainMenu.Location = new Point(222, 199);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(150, 50);
            MainMenu.TabIndex = 1;
            MainMenu.Text = "Main Menu";
            MainMenu.UseVisualStyleBackColor = true;
            MainMenu.Click += MainMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 2;
            label1.Text = "Add A Quote";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 3;
            label2.Text = "Customer Name: ";
            label2.Click += label2_Click;
            // 
            // CustomerNameInput
            // 
            CustomerNameInput.Location = new Point(148, 60);
            CustomerNameInput.Name = "CustomerNameInput";
            CustomerNameInput.Size = new Size(224, 23);
            CustomerNameInput.TabIndex = 4;
            CustomerNameInput.TextChanged += NameInput_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 91);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 5;
            // 
            // W
            // 
            W.AutoSize = true;
            W.Font = new Font("Segoe UI", 12F);
            W.Location = new Point(13, 167);
            W.Name = "W";
            W.Size = new Size(82, 21);
            W.TabIndex = 6;
            W.Text = "Width (in):";
            W.Click += label4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(13, 129);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 7;
            label4.Text = "Depth (in):";
            // 
            // NumberOfDrawersInput
            // 
            NumberOfDrawersInput.Location = new Point(286, 132);
            NumberOfDrawersInput.Name = "NumberOfDrawersInput";
            NumberOfDrawersInput.Size = new Size(65, 23);
            NumberOfDrawersInput.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(198, 129);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 10;
            label5.Text = "Drawers:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(286, 167);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(65, 23);
            numericUpDown1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(176, 167);
            label6.Name = "label6";
            label6.Size = new Size(93, 21);
            label6.TabIndex = 12;
            label6.Text = "Rush Order:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(73, 91);
            label7.Name = "label7";
            label7.Size = new Size(70, 21);
            label7.TabIndex = 14;
            label7.Text = "Material:";
            // 
            // MaterialInput
            // 
            MaterialInput.Location = new Point(148, 91);
            MaterialInput.Name = "MaterialInput";
            MaterialInput.Size = new Size(224, 23);
            MaterialInput.TabIndex = 16;
            // 
            // DepthInput
            // 
            DepthInput.Location = new Point(101, 127);
            DepthInput.Name = "DepthInput";
            DepthInput.Size = new Size(65, 23);
            DepthInput.TabIndex = 17;
            DepthInput.KeyPress += DepthInput_Validation;
            // 
            // WidthInput
            // 
            WidthInput.Location = new Point(101, 169);
            WidthInput.Name = "WidthInput";
            WidthInput.Size = new Size(65, 23);
            WidthInput.TabIndex = 18;
            WidthInput.Validating += WidthInput_Validating;
            // 
            // SubmitQuoteButton
            // 
            SubmitQuoteButton.Font = new Font("Segoe UI", 12F);
            SubmitQuoteButton.Location = new Point(12, 199);
            SubmitQuoteButton.Name = "SubmitQuoteButton";
            SubmitQuoteButton.Size = new Size(200, 50);
            SubmitQuoteButton.TabIndex = 19;
            SubmitQuoteButton.Text = "Submit Quote";
            SubmitQuoteButton.UseVisualStyleBackColor = true;
            SubmitQuoteButton.Click += SubmitQuoteButton_Click;
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(SubmitQuoteButton);
            Controls.Add(WidthInput);
            Controls.Add(DepthInput);
            Controls.Add(MaterialInput);
            Controls.Add(label7);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(NumberOfDrawersInput);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(W);
            Controls.Add(label3);
            Controls.Add(CustomerNameInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MainMenu);
            Name = "AddQuote";
            Text = "Megadesk 1.0";
            ((System.ComponentModel.ISupportInitialize)NumberOfDrawersInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MainMenu;
        private Label label1;
        private Label label2;
        private TextBox CustomerNameInput;
        private Label label3;
        private Label W;
        private Label label4;
        private SaveFileDialog saveFileDialog1;
        private NumericUpDown NumberOfDrawersInput;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Label label7;
        private TextBox MaterialInput;
        private TextBox DepthInput;
        private TextBox WidthInput;
        private Button SubmitQuoteButton;
    }
}