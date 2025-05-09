namespace Cryptology_Project
{
    partial class Main_Page
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
            square_button = new Button();
            shift_button = new Button();
            linear_button = new Button();
            vigenere_button = new Button();
            transposition_button = new Button();
            permutation_button = new Button();
            numerickey_button = new Button();
            hill_button = new Button();
            railfence_button = new Button();
            rotation_button = new Button();
            Main_Page_Label = new Label();
            button_TR = new Button();
            button_EN = new Button();
            SuspendLayout();
            // 
            // square_button
            // 
            square_button.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            square_button.Location = new Point(858, 121);
            square_button.Name = "square_button";
            square_button.Size = new Size(139, 74);
            square_button.TabIndex = 0;
            square_button.Text = "4 Square";
            square_button.UseVisualStyleBackColor = true;
            square_button.Click += square_button_Click;
            // 
            // shift_button
            // 
            shift_button.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            shift_button.Location = new Point(30, 121);
            shift_button.Name = "shift_button";
            shift_button.Size = new Size(154, 74);
            shift_button.TabIndex = 1;
            shift_button.Text = "Shift";
            shift_button.UseVisualStyleBackColor = true;
            shift_button.Click += shift_button_Click;
            // 
            // linear_button
            // 
            linear_button.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            linear_button.Location = new Point(30, 219);
            linear_button.Name = "linear_button";
            linear_button.Size = new Size(154, 74);
            linear_button.TabIndex = 2;
            linear_button.Text = "Linear";
            linear_button.UseVisualStyleBackColor = true;
            linear_button.Click += linear_button_Click;
            // 
            // vigenere_button
            // 
            vigenere_button.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            vigenere_button.Location = new Point(660, 219);
            vigenere_button.Name = "vigenere_button";
            vigenere_button.Size = new Size(154, 74);
            vigenere_button.TabIndex = 3;
            vigenere_button.Text = "Vigenere";
            vigenere_button.UseVisualStyleBackColor = true;
            vigenere_button.Click += vigenere_button_Click;
            // 
            // transposition_button
            // 
            transposition_button.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            transposition_button.Location = new Point(213, 121);
            transposition_button.Name = "transposition_button";
            transposition_button.Size = new Size(192, 74);
            transposition_button.TabIndex = 4;
            transposition_button.Text = "Transposition";
            transposition_button.UseVisualStyleBackColor = true;
            transposition_button.Click += transposition_button_Click;
            // 
            // permutation_button
            // 
            permutation_button.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            permutation_button.Location = new Point(225, 219);
            permutation_button.Name = "permutation_button";
            permutation_button.Size = new Size(167, 74);
            permutation_button.TabIndex = 5;
            permutation_button.Text = "Permutation";
            permutation_button.UseVisualStyleBackColor = true;
            permutation_button.Click += permutation_button_Click;
            // 
            // numerickey_button
            // 
            numerickey_button.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            numerickey_button.Location = new Point(444, 121);
            numerickey_button.Name = "numerickey_button";
            numerickey_button.Size = new Size(167, 74);
            numerickey_button.TabIndex = 6;
            numerickey_button.Text = "Numeric Key";
            numerickey_button.UseVisualStyleBackColor = true;
            numerickey_button.Click += numerickey_button_Click;
            // 
            // hill_button
            // 
            hill_button.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            hill_button.Location = new Point(858, 224);
            hill_button.Name = "hill_button";
            hill_button.Size = new Size(139, 69);
            hill_button.TabIndex = 7;
            hill_button.Text = "Hill";
            hill_button.UseVisualStyleBackColor = true;
            hill_button.Click += hill_button_Click;
            // 
            // railfence_button
            // 
            railfence_button.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            railfence_button.Location = new Point(660, 121);
            railfence_button.Name = "railfence_button";
            railfence_button.Size = new Size(154, 74);
            railfence_button.TabIndex = 8;
            railfence_button.Text = "Rail Fence";
            railfence_button.UseVisualStyleBackColor = true;
            railfence_button.Click += railfence_button_Click;
            // 
            // rotation_button
            // 
            rotation_button.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rotation_button.Location = new Point(444, 219);
            rotation_button.Name = "rotation_button";
            rotation_button.Size = new Size(167, 74);
            rotation_button.TabIndex = 9;
            rotation_button.Text = "Rotation";
            rotation_button.UseVisualStyleBackColor = true;
            rotation_button.Click += rotation_button_Click;
            // 
            // Main_Page_Label
            // 
            Main_Page_Label.AutoSize = true;
            Main_Page_Label.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Main_Page_Label.ForeColor = SystemColors.ButtonFace;
            Main_Page_Label.Location = new Point(82, 62);
            Main_Page_Label.Name = "Main_Page_Label";
            Main_Page_Label.Size = new Size(873, 41);
            Main_Page_Label.TabIndex = 10;
            Main_Page_Label.Text = "Choose One Of The Encryption Algorithms Below";
            Main_Page_Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // button_TR
            // 
            button_TR.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_TR.Location = new Point(435, 22);
            button_TR.Name = "button_TR";
            button_TR.Size = new Size(75, 28);
            button_TR.TabIndex = 11;
            button_TR.Text = "TR";
            button_TR.UseVisualStyleBackColor = true;
            button_TR.Click += button_TR_Click;
            // 
            // button_EN
            // 
            button_EN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_EN.Location = new Point(516, 22);
            button_EN.Name = "button_EN";
            button_EN.Size = new Size(75, 28);
            button_EN.TabIndex = 11;
            button_EN.Text = "EN";
            button_EN.UseVisualStyleBackColor = true;
            button_EN.Click += button_EN_Click;
            // 
            // Main_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1026, 315);
            Controls.Add(button_EN);
            Controls.Add(button_TR);
            Controls.Add(Main_Page_Label);
            Controls.Add(rotation_button);
            Controls.Add(railfence_button);
            Controls.Add(hill_button);
            Controls.Add(numerickey_button);
            Controls.Add(permutation_button);
            Controls.Add(transposition_button);
            Controls.Add(vigenere_button);
            Controls.Add(linear_button);
            Controls.Add(shift_button);
            Controls.Add(square_button);
            Name = "Main_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main_Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button square_button;
        private Button shift_button;
        private Button linear_button;
        private Button vigenere_button;
        private Button transposition_button;
        private Button permutation_button;
        private Button numerickey_button;
        private Button hill_button;
        private Button railfence_button;
        private Button rotation_button;
        private Label Main_Page_Label;
        private Button button_TR;
        private Button button_EN;
    }
}