namespace Cryptology_Project
{
    partial class Numeric_Key_Cipher
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
            textBox_numeric_text = new TextBox();
            label2 = new Label();
            numeric_enc_textBox = new TextBox();
            label1 = new Label();
            textBox_numeric_key = new TextBox();
            shift_key_label = new Label();
            button_enc = new Button();
            Main_Page_Label = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_back.Location = new Point(14, 16);
            button_back.Name = "button_back";
            button_back.Size = new Size(48, 33);
            button_back.TabIndex = 28;
            button_back.Text = "<--";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // textBox_numeric_text
            // 
            textBox_numeric_text.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_numeric_text.Location = new Point(281, 117);
            textBox_numeric_text.Name = "textBox_numeric_text";
            textBox_numeric_text.Size = new Size(163, 29);
            textBox_numeric_text.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(188, 118);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 26;
            label2.Text = "Text :";
            // 
            // numeric_enc_textBox
            // 
            numeric_enc_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            numeric_enc_textBox.Location = new Point(160, 252);
            numeric_enc_textBox.Name = "numeric_enc_textBox";
            numeric_enc_textBox.ReadOnly = true;
            numeric_enc_textBox.Size = new Size(463, 29);
            numeric_enc_textBox.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 252);
            label1.Name = "label1";
            label1.Size = new Size(142, 24);
            label1.TabIndex = 24;
            label1.Text = "Encrypted :";
            // 
            // textBox_numeric_key
            // 
            textBox_numeric_key.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_numeric_key.Location = new Point(281, 74);
            textBox_numeric_key.Name = "textBox_numeric_key";
            textBox_numeric_key.Size = new Size(163, 29);
            textBox_numeric_key.TabIndex = 23;
            // 
            // shift_key_label
            // 
            shift_key_label.AutoSize = true;
            shift_key_label.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            shift_key_label.ForeColor = Color.White;
            shift_key_label.Location = new Point(200, 75);
            shift_key_label.Name = "shift_key_label";
            shift_key_label.Size = new Size(70, 24);
            shift_key_label.TabIndex = 22;
            shift_key_label.Text = "Key :";
            // 
            // button_enc
            // 
            button_enc.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_enc.Location = new Point(243, 176);
            button_enc.Name = "button_enc";
            button_enc.Size = new Size(139, 45);
            button_enc.TabIndex = 21;
            button_enc.Text = "ENCRYPT";
            button_enc.UseVisualStyleBackColor = true;
            button_enc.Click += button_enc_Click;
            // 
            // Main_Page_Label
            // 
            Main_Page_Label.AutoSize = true;
            Main_Page_Label.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Main_Page_Label.ForeColor = SystemColors.ButtonFace;
            Main_Page_Label.Location = new Point(208, 9);
            Main_Page_Label.Name = "Main_Page_Label";
            Main_Page_Label.Size = new Size(227, 41);
            Main_Page_Label.TabIndex = 20;
            Main_Page_Label.Text = "NUMERIC KEY";
            Main_Page_Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(450, 80);
            label4.Name = "label4";
            label4.Size = new Size(189, 19);
            label4.TabIndex = 29;
            label4.Text = "(Must Be An Integer)";
            // 
            // Numeric_Key_Cipher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(642, 297);
            Controls.Add(label4);
            Controls.Add(button_back);
            Controls.Add(textBox_numeric_text);
            Controls.Add(label2);
            Controls.Add(numeric_enc_textBox);
            Controls.Add(label1);
            Controls.Add(textBox_numeric_key);
            Controls.Add(shift_key_label);
            Controls.Add(button_enc);
            Controls.Add(Main_Page_Label);
            Name = "Numeric_Key_Cipher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Numeric_Key_Cipher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_back;
        private TextBox textBox_numeric_text;
        private Label label2;
        private TextBox numeric_enc_textBox;
        private Label label1;
        private TextBox textBox_numeric_key;
        private Label shift_key_label;
        private Button button_enc;
        private Label Main_Page_Label;
        private Label label4;
    }
}