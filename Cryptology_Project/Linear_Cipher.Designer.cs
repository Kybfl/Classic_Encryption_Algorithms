namespace Cryptology_Project
{
    partial class Linear_Cipher
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
            label2 = new Label();
            label1 = new Label();
            shift_key_label = new Label();
            Main_Page_Label = new Label();
            label3 = new Label();
            linear_enc_button = new Button();
            textBox_shift_enc = new TextBox();
            textBox_linear_text = new TextBox();
            textBox_key2 = new TextBox();
            textBox_key1 = new TextBox();
            button_back = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(157, 150);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 21;
            label2.Text = "Text :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 279);
            label1.Name = "label1";
            label1.Size = new Size(142, 24);
            label1.TabIndex = 20;
            label1.Text = "Encrypted :";
            // 
            // shift_key_label
            // 
            shift_key_label.AutoSize = true;
            shift_key_label.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            shift_key_label.ForeColor = Color.White;
            shift_key_label.Location = new Point(85, 80);
            shift_key_label.Name = "shift_key_label";
            shift_key_label.Size = new Size(154, 24);
            shift_key_label.TabIndex = 19;
            shift_key_label.Text = "Key 1 (a)  :";
            // 
            // Main_Page_Label
            // 
            Main_Page_Label.AutoSize = true;
            Main_Page_Label.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Main_Page_Label.ForeColor = SystemColors.ButtonFace;
            Main_Page_Label.Location = new Point(268, 14);
            Main_Page_Label.Name = "Main_Page_Label";
            Main_Page_Label.Size = new Size(132, 41);
            Main_Page_Label.TabIndex = 18;
            Main_Page_Label.Text = "LINEAR";
            Main_Page_Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(85, 116);
            label3.Name = "label3";
            label3.Size = new Size(154, 24);
            label3.TabIndex = 22;
            label3.Text = "Key 2 (b)  :";
            // 
            // linear_enc_button
            // 
            linear_enc_button.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            linear_enc_button.Location = new Point(265, 205);
            linear_enc_button.Name = "linear_enc_button";
            linear_enc_button.Size = new Size(139, 45);
            linear_enc_button.TabIndex = 23;
            linear_enc_button.Text = "ENCRYPT";
            linear_enc_button.UseVisualStyleBackColor = true;
            linear_enc_button.Click += linear_enc_button_Click;
            // 
            // textBox_shift_enc
            // 
            textBox_shift_enc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_shift_enc.Location = new Point(160, 278);
            textBox_shift_enc.Name = "textBox_shift_enc";
            textBox_shift_enc.ReadOnly = true;
            textBox_shift_enc.Size = new Size(496, 29);
            textBox_shift_enc.TabIndex = 24;
            // 
            // textBox_linear_text
            // 
            textBox_linear_text.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_linear_text.Location = new Point(245, 150);
            textBox_linear_text.Name = "textBox_linear_text";
            textBox_linear_text.Size = new Size(224, 29);
            textBox_linear_text.TabIndex = 25;
            // 
            // textBox_key2
            // 
            textBox_key2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_key2.Location = new Point(245, 115);
            textBox_key2.Name = "textBox_key2";
            textBox_key2.Size = new Size(224, 29);
            textBox_key2.TabIndex = 26;
            // 
            // textBox_key1
            // 
            textBox_key1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_key1.Location = new Point(245, 79);
            textBox_key1.Name = "textBox_key1";
            textBox_key1.Size = new Size(224, 29);
            textBox_key1.TabIndex = 27;
            // 
            // button_back
            // 
            button_back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_back.Location = new Point(12, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(57, 37);
            button_back.TabIndex = 28;
            button_back.Text = "<--";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(475, 85);
            label4.Name = "label4";
            label4.Size = new Size(189, 19);
            label4.TabIndex = 29;
            label4.Text = "(Must Be An Integer)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(475, 125);
            label5.Name = "label5";
            label5.Size = new Size(189, 19);
            label5.TabIndex = 30;
            label5.Text = "(Must Be An Integer)";
            // 
            // Linear_Cipher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(668, 340);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button_back);
            Controls.Add(textBox_key1);
            Controls.Add(textBox_key2);
            Controls.Add(textBox_linear_text);
            Controls.Add(textBox_shift_enc);
            Controls.Add(linear_enc_button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(shift_key_label);
            Controls.Add(Main_Page_Label);
            Name = "Linear_Cipher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Linear_Cipher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label shift_key_label;
        private Label Main_Page_Label;
        private Label label3;
        private Button linear_enc_button;
        private TextBox textBox_shift_enc;
        private TextBox textBox_linear_text;
        private TextBox textBox_key2;
        private TextBox textBox_key1;
        private Button button_back;
        private Label label4;
        private Label label5;
    }
}