namespace Cryptology_Project
{
    partial class Transposition_Cipher
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
            Main_Page_Label = new Label();
            button_enc = new Button();
            shift_key_label = new Label();
            textBox_transposition_text = new TextBox();
            label2 = new Label();
            textBox_transposition_enc = new TextBox();
            label1 = new Label();
            button_shuffle = new Button();
            listBox_key = new ListBox();
            button_back = new Button();
            SuspendLayout();
            // 
            // Main_Page_Label
            // 
            Main_Page_Label.AutoSize = true;
            Main_Page_Label.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Main_Page_Label.ForeColor = SystemColors.ButtonFace;
            Main_Page_Label.Location = new Point(241, 9);
            Main_Page_Label.Name = "Main_Page_Label";
            Main_Page_Label.Size = new Size(265, 41);
            Main_Page_Label.TabIndex = 19;
            Main_Page_Label.Text = "TRANSPOSITION";
            Main_Page_Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // button_enc
            // 
            button_enc.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_enc.Location = new Point(460, 115);
            button_enc.Name = "button_enc";
            button_enc.Size = new Size(127, 45);
            button_enc.TabIndex = 20;
            button_enc.Text = "ENCRYPT";
            button_enc.UseVisualStyleBackColor = true;
            button_enc.Click += button_enc_Click;
            // 
            // shift_key_label
            // 
            shift_key_label.AutoSize = true;
            shift_key_label.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            shift_key_label.ForeColor = Color.White;
            shift_key_label.Location = new Point(27, 67);
            shift_key_label.Name = "shift_key_label";
            shift_key_label.Size = new Size(70, 24);
            shift_key_label.TabIndex = 21;
            shift_key_label.Text = "Key :";
            // 
            // textBox_transposition_text
            // 
            textBox_transposition_text.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_transposition_text.Location = new Point(428, 71);
            textBox_transposition_text.Name = "textBox_transposition_text";
            textBox_transposition_text.Size = new Size(299, 29);
            textBox_transposition_text.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(340, 72);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 26;
            label2.Text = "Text :";
            // 
            // textBox_transposition_enc
            // 
            textBox_transposition_enc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_transposition_enc.Location = new Point(340, 213);
            textBox_transposition_enc.Name = "textBox_transposition_enc";
            textBox_transposition_enc.ReadOnly = true;
            textBox_transposition_enc.Size = new Size(387, 29);
            textBox_transposition_enc.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(460, 182);
            label1.Name = "label1";
            label1.Size = new Size(142, 24);
            label1.TabIndex = 28;
            label1.Text = "Encrypted :";
            // 
            // button_shuffle
            // 
            button_shuffle.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_shuffle.Location = new Point(157, 261);
            button_shuffle.Name = "button_shuffle";
            button_shuffle.Size = new Size(105, 31);
            button_shuffle.TabIndex = 30;
            button_shuffle.Text = "SHUFFLE";
            button_shuffle.UseVisualStyleBackColor = true;
            button_shuffle.Click += button_shuffle_Click;
            // 
            // listBox_key
            // 
            listBox_key.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listBox_key.FormattingEnabled = true;
            listBox_key.ItemHeight = 19;
            listBox_key.Items.AddRange(new object[] { "0 : a  ", "1 : b  ", "2 : c  ", "3 : ç  ", "4 : d  ", "5 : e  ", "6 : f  ", "7 : g  ", "8 : ğ  ", "9 : h  ", "10 : ı  ", "11 : i  ", "12 : j  ", "13 : k  ", "14 : l  ", "15 : m  ", "16 : n  ", "17 : o  ", "18 : ö  ", "19 : p  ", "20 : r  ", "21 : s  ", "22 : ş  ", "23 : t  ", "24 : u  ", "25 : ü  ", "26 : v  ", "27 : y  ", "28 : z" });
            listBox_key.Location = new Point(103, 67);
            listBox_key.Name = "listBox_key";
            listBox_key.Size = new Size(217, 175);
            listBox_key.TabIndex = 31;
            // 
            // button_back
            // 
            button_back.Location = new Point(12, 14);
            button_back.Name = "button_back";
            button_back.Size = new Size(50, 27);
            button_back.TabIndex = 32;
            button_back.Text = "<--";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // Transposition_Cipher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(747, 313);
            Controls.Add(button_back);
            Controls.Add(listBox_key);
            Controls.Add(button_shuffle);
            Controls.Add(textBox_transposition_enc);
            Controls.Add(label1);
            Controls.Add(textBox_transposition_text);
            Controls.Add(label2);
            Controls.Add(shift_key_label);
            Controls.Add(button_enc);
            Controls.Add(Main_Page_Label);
            Name = "Transposition_Cipher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tramsposition_Cipher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Main_Page_Label;
        private Button button_enc;
        private Label shift_key_label;
        private TextBox textBox_transposition_text;
        private Label label2;
        private TextBox textBox_transposition_enc;
        private Label label1;
        private Button button_shuffle;
        private ListBox listBox_key;
        private Button button_back;
    }
}