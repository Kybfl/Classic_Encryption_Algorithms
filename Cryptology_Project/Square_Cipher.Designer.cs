namespace Cryptology_Project
{
    partial class Square_Cipher
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
            button_back = new Button();
            textBox_squaretext = new TextBox();
            label2 = new Label();
            square_textBox = new TextBox();
            label1 = new Label();
            shift_key_label = new Label();
            square_enc_button = new Button();
            Main_Page_Label = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox_key3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            listBox_leftdown = new ListBox();
            button_createkeys = new Button();
            listBox_rightup = new ListBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_back.Location = new Point(14, 17);
            button_back.Name = "button_back";
            button_back.Size = new Size(48, 33);
            button_back.TabIndex = 37;
            button_back.Text = "<--";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // textBox_squaretext
            // 
            textBox_squaretext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_squaretext.Location = new Point(658, 256);
            textBox_squaretext.Name = "textBox_squaretext";
            textBox_squaretext.Size = new Size(310, 29);
            textBox_squaretext.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(570, 261);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 35;
            label2.Text = "Text :";
            // 
            // square_textBox
            // 
            square_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            square_textBox.Location = new Point(658, 388);
            square_textBox.Name = "square_textBox";
            square_textBox.ReadOnly = true;
            square_textBox.Size = new Size(310, 29);
            square_textBox.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(510, 393);
            label1.Name = "label1";
            label1.Size = new Size(142, 24);
            label1.TabIndex = 33;
            label1.Text = "Encrypted :";
            // 
            // shift_key_label
            // 
            shift_key_label.AutoSize = true;
            shift_key_label.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            shift_key_label.ForeColor = Color.White;
            shift_key_label.Location = new Point(62, 131);
            shift_key_label.Name = "shift_key_label";
            shift_key_label.Size = new Size(214, 24);
            shift_key_label.TabIndex = 31;
            shift_key_label.Text = "Key 1 (Right Up):";
            // 
            // square_enc_button
            // 
            square_enc_button.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            square_enc_button.Location = new Point(715, 310);
            square_enc_button.Name = "square_enc_button";
            square_enc_button.Size = new Size(139, 45);
            square_enc_button.TabIndex = 30;
            square_enc_button.Text = "ENCRYPT";
            square_enc_button.UseVisualStyleBackColor = true;
            square_enc_button.Click += square_enc_button_Click;
            // 
            // Main_Page_Label
            // 
            Main_Page_Label.AutoSize = true;
            Main_Page_Label.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Main_Page_Label.ForeColor = SystemColors.ButtonFace;
            Main_Page_Label.Location = new Point(423, 7);
            Main_Page_Label.Name = "Main_Page_Label";
            Main_Page_Label.Size = new Size(170, 41);
            Main_Page_Label.TabIndex = 29;
            Main_Page_Label.Text = "4 SQUARE";
            Main_Page_Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(62, 321);
            label3.Name = "label3";
            label3.Size = new Size(226, 24);
            label3.TabIndex = 31;
            label3.Text = "Key 2 (Left Down):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(587, 130);
            label4.Name = "label4";
            label4.Size = new Size(94, 24);
            label4.TabIndex = 31;
            label4.Text = "Key 3 :";
            // 
            // textBox_key3
            // 
            textBox_key3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_key3.Location = new Point(699, 131);
            textBox_key3.Name = "textBox_key3";
            textBox_key3.Size = new Size(219, 29);
            textBox_key3.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(26, 85);
            label5.Name = "label5";
            label5.Size = new Size(262, 24);
            label5.TabIndex = 35;
            label5.Text = "Mixed Alphabet Keys :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.White;
            label6.Location = new Point(534, 85);
            label6.Name = "label6";
            label6.Size = new Size(430, 24);
            label6.TabIndex = 35;
            label6.Text = "Number Of Rows (6 Is Recommended) :";
            // 
            // listBox_leftdown
            // 
            listBox_leftdown.Font = new Font("Consolas", 12F, FontStyle.Bold);
            listBox_leftdown.FormattingEnabled = true;
            listBox_leftdown.ItemHeight = 19;
            listBox_leftdown.Location = new Point(294, 321);
            listBox_leftdown.Name = "listBox_leftdown";
            listBox_leftdown.Size = new Size(174, 137);
            listBox_leftdown.TabIndex = 38;
            // 
            // button_createkeys
            // 
            button_createkeys.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_createkeys.Location = new Point(114, 491);
            button_createkeys.Name = "button_createkeys";
            button_createkeys.Size = new Size(307, 45);
            button_createkeys.TabIndex = 30;
            button_createkeys.Text = "CREATE ALPHABET KEYS";
            button_createkeys.UseVisualStyleBackColor = true;
            button_createkeys.Click += button_createkeys_Click;
            // 
            // listBox_rightup
            // 
            listBox_rightup.Font = new Font("Consolas", 12F, FontStyle.Bold);
            listBox_rightup.FormattingEnabled = true;
            listBox_rightup.ItemHeight = 19;
            listBox_rightup.Location = new Point(294, 131);
            listBox_rightup.Name = "listBox_rightup";
            listBox_rightup.Size = new Size(174, 137);
            listBox_rightup.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.White;
            label7.Location = new Point(715, 173);
            label7.Name = "label7";
            label7.Size = new Size(189, 19);
            label7.TabIndex = 39;
            label7.Text = "(Must Be An Integer)";
            // 
            // Square_Cipher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1033, 567);
            Controls.Add(label7);
            Controls.Add(listBox_rightup);
            Controls.Add(listBox_leftdown);
            Controls.Add(button_back);
            Controls.Add(textBox_key3);
            Controls.Add(textBox_squaretext);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(square_textBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(shift_key_label);
            Controls.Add(button_createkeys);
            Controls.Add(square_enc_button);
            Controls.Add(Main_Page_Label);
            Name = "Square_Cipher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Square_Cipher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_back;
        private TextBox textBox_squaretext;
        private Label label2;
        private TextBox square_textBox;
        private Label label1;
        private Label shift_key_label;
        private Button square_enc_button;
        private Label Main_Page_Label;
        private Label label3;
        private Label label4;
        private TextBox textBox_key3;
        private Label label5;
        private Label label6;
        private ListBox listBox_leftdown;
        private Button button_createkeys;
        private ListBox listBox_rightup;
        private Label label7;
    }
}