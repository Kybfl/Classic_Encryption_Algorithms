namespace Cryptology_Project
{
    partial class Permutation_Cipher
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
            label1 = new Label();
            textbox_permutation_key2 = new TextBox();
            button_enc = new Button();
            textBox_transposition_enc = new TextBox();
            label2 = new Label();
            textBox_permutation_text = new TextBox();
            label3 = new Label();
            button_back = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // Main_Page_Label
            // 
            Main_Page_Label.AutoSize = true;
            Main_Page_Label.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Main_Page_Label.ForeColor = SystemColors.ButtonFace;
            Main_Page_Label.Location = new Point(184, 9);
            Main_Page_Label.Name = "Main_Page_Label";
            Main_Page_Label.Size = new Size(227, 41);
            Main_Page_Label.TabIndex = 12;
            Main_Page_Label.Text = "PERMUTATION";
            Main_Page_Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(134, 70);
            label1.Name = "label1";
            label1.Size = new Size(94, 24);
            label1.TabIndex = 15;
            label1.Text = "Key 1 :";
            // 
            // textbox_permutation_key2
            // 
            textbox_permutation_key2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textbox_permutation_key2.Location = new Point(234, 65);
            textbox_permutation_key2.Name = "textbox_permutation_key2";
            textbox_permutation_key2.Size = new Size(163, 29);
            textbox_permutation_key2.TabIndex = 16;
            // 
            // button_enc
            // 
            button_enc.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_enc.Location = new Point(234, 160);
            button_enc.Name = "button_enc";
            button_enc.Size = new Size(127, 45);
            button_enc.TabIndex = 21;
            button_enc.Text = "ENCRYPT";
            button_enc.UseVisualStyleBackColor = true;
            button_enc.Click += button_enc_Click;
            // 
            // textBox_transposition_enc
            // 
            textBox_transposition_enc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_transposition_enc.Location = new Point(170, 223);
            textBox_transposition_enc.Name = "textBox_transposition_enc";
            textBox_transposition_enc.ReadOnly = true;
            textBox_transposition_enc.Size = new Size(387, 29);
            textBox_transposition_enc.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 228);
            label2.Name = "label2";
            label2.Size = new Size(142, 24);
            label2.TabIndex = 30;
            label2.Text = "Encrypted :";
            // 
            // textBox_permutation_text
            // 
            textBox_permutation_text.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_permutation_text.Location = new Point(234, 112);
            textBox_permutation_text.Name = "textBox_permutation_text";
            textBox_permutation_text.Size = new Size(163, 29);
            textBox_permutation_text.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(146, 113);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 32;
            label3.Text = "Text :";
            // 
            // button_back
            // 
            button_back.Location = new Point(20, 17);
            button_back.Name = "button_back";
            button_back.Size = new Size(58, 33);
            button_back.TabIndex = 34;
            button_back.Text = "<--";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(403, 70);
            label4.Name = "label4";
            label4.Size = new Size(189, 19);
            label4.TabIndex = 15;
            label4.Text = "(Must Be An Integer)";
            // 
            // Permutation_Cipher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(595, 326);
            Controls.Add(button_back);
            Controls.Add(textBox_permutation_text);
            Controls.Add(label3);
            Controls.Add(textBox_transposition_enc);
            Controls.Add(label2);
            Controls.Add(button_enc);
            Controls.Add(textbox_permutation_key2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(Main_Page_Label);
            Name = "Permutation_Cipher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Permutation_Cipher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Main_Page_Label;
        private Label label1;
        private TextBox textbox_permutation_key2;
        private Button button_enc;
        private TextBox textBox_transposition_enc;
        private Label label2;
        private TextBox textBox_permutation_text;
        private Label label3;
        private Button button_back;
        private Label label4;
    }
}