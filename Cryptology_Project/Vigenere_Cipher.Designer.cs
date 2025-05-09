namespace Cryptology_Project
{
    partial class Vigenere_Cipher
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
            textBox_vigeneretext = new TextBox();
            label2 = new Label();
            vigenere_textBox = new TextBox();
            label1 = new Label();
            textBox_vigenere_key = new TextBox();
            shift_key_label = new Label();
            vigenre_enc_button = new Button();
            Main_Page_Label = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_back.Location = new Point(16, 17);
            button_back.Name = "button_back";
            button_back.Size = new Size(48, 33);
            button_back.TabIndex = 28;
            button_back.Text = "<--";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // textBox_vigeneretext
            // 
            textBox_vigeneretext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_vigeneretext.Location = new Point(275, 117);
            textBox_vigeneretext.Name = "textBox_vigeneretext";
            textBox_vigeneretext.Size = new Size(163, 29);
            textBox_vigeneretext.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(182, 118);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 26;
            label2.Text = "Text :";
            // 
            // vigenere_textBox
            // 
            vigenere_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            vigenere_textBox.Location = new Point(164, 241);
            vigenere_textBox.Name = "vigenere_textBox";
            vigenere_textBox.ReadOnly = true;
            vigenere_textBox.Size = new Size(546, 29);
            vigenere_textBox.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 242);
            label1.Name = "label1";
            label1.Size = new Size(142, 24);
            label1.TabIndex = 24;
            label1.Text = "Encrypted :";
            // 
            // textBox_vigenere_key
            // 
            textBox_vigenere_key.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_vigenere_key.Location = new Point(275, 74);
            textBox_vigenere_key.Name = "textBox_vigenere_key";
            textBox_vigenere_key.Size = new Size(163, 29);
            textBox_vigenere_key.TabIndex = 23;
            // 
            // shift_key_label
            // 
            shift_key_label.AutoSize = true;
            shift_key_label.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            shift_key_label.ForeColor = Color.White;
            shift_key_label.Location = new Point(194, 75);
            shift_key_label.Name = "shift_key_label";
            shift_key_label.Size = new Size(70, 24);
            shift_key_label.TabIndex = 22;
            shift_key_label.Text = "Key :";
            // 
            // vigenre_enc_button
            // 
            vigenre_enc_button.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            vigenre_enc_button.Location = new Point(281, 168);
            vigenre_enc_button.Name = "vigenre_enc_button";
            vigenre_enc_button.Size = new Size(139, 45);
            vigenre_enc_button.TabIndex = 21;
            vigenre_enc_button.Text = "ENCRYPT";
            vigenre_enc_button.UseVisualStyleBackColor = true;
            vigenre_enc_button.Click += vigenre_enc_button_Click;
            // 
            // Main_Page_Label
            // 
            Main_Page_Label.AutoSize = true;
            Main_Page_Label.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Main_Page_Label.ForeColor = SystemColors.ButtonFace;
            Main_Page_Label.Location = new Point(281, 9);
            Main_Page_Label.Name = "Main_Page_Label";
            Main_Page_Label.Size = new Size(170, 41);
            Main_Page_Label.TabIndex = 20;
            Main_Page_Label.Text = "VIGENERE";
            Main_Page_Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(444, 79);
            label3.Name = "label3";
            label3.Size = new Size(315, 19);
            label3.TabIndex = 22;
            label3.Text = "(Must Consist Of Turkish Letters) ";
            // 
            // Vigenere_Cipher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(752, 298);
            Controls.Add(button_back);
            Controls.Add(textBox_vigeneretext);
            Controls.Add(label2);
            Controls.Add(vigenere_textBox);
            Controls.Add(label1);
            Controls.Add(textBox_vigenere_key);
            Controls.Add(label3);
            Controls.Add(shift_key_label);
            Controls.Add(vigenre_enc_button);
            Controls.Add(Main_Page_Label);
            Name = "Vigenere_Cipher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vigenere_Cipher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_back;
        private TextBox textBox_vigeneretext;
        private Label label2;
        private TextBox vigenere_textBox;
        private Label label1;
        private TextBox textBox_vigenere_key;
        private Label shift_key_label;
        private Button vigenre_enc_button;
        private Label Main_Page_Label;
        private Label label3;
    }
}