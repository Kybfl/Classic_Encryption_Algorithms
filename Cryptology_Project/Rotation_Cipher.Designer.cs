namespace Cryptology_Project
{
    partial class Rotation_Cipher
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
            textBox_rotation_text = new TextBox();
            label2 = new Label();
            rotation_enc_textBox = new TextBox();
            label1 = new Label();
            textBox_rotation_key = new TextBox();
            shift_key_label = new Label();
            button_enc = new Button();
            Main_Page_Label = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_back.Location = new Point(17, 16);
            button_back.Name = "button_back";
            button_back.Size = new Size(48, 33);
            button_back.TabIndex = 37;
            button_back.Text = "<--";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // textBox_rotation_text
            // 
            textBox_rotation_text.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_rotation_text.Location = new Point(284, 117);
            textBox_rotation_text.Name = "textBox_rotation_text";
            textBox_rotation_text.Size = new Size(163, 29);
            textBox_rotation_text.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(191, 118);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 35;
            label2.Text = "Text :";
            // 
            // rotation_enc_textBox
            // 
            rotation_enc_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rotation_enc_textBox.Location = new Point(164, 225);
            rotation_enc_textBox.Name = "rotation_enc_textBox";
            rotation_enc_textBox.ReadOnly = true;
            rotation_enc_textBox.Size = new Size(463, 29);
            rotation_enc_textBox.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(17, 230);
            label1.Name = "label1";
            label1.Size = new Size(142, 24);
            label1.TabIndex = 33;
            label1.Text = "Encrypted :";
            // 
            // textBox_rotation_key
            // 
            textBox_rotation_key.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_rotation_key.Location = new Point(284, 74);
            textBox_rotation_key.Name = "textBox_rotation_key";
            textBox_rotation_key.Size = new Size(163, 29);
            textBox_rotation_key.TabIndex = 32;
            // 
            // shift_key_label
            // 
            shift_key_label.AutoSize = true;
            shift_key_label.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            shift_key_label.ForeColor = Color.White;
            shift_key_label.Location = new Point(203, 75);
            shift_key_label.Name = "shift_key_label";
            shift_key_label.Size = new Size(70, 24);
            shift_key_label.TabIndex = 31;
            shift_key_label.Text = "Key :";
            // 
            // button_enc
            // 
            button_enc.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_enc.Location = new Point(237, 163);
            button_enc.Name = "button_enc";
            button_enc.Size = new Size(139, 45);
            button_enc.TabIndex = 30;
            button_enc.Text = "ENCRYPT";
            button_enc.UseVisualStyleBackColor = true;
            button_enc.Click += button_enc_Click;
            // 
            // Main_Page_Label
            // 
            Main_Page_Label.AutoSize = true;
            Main_Page_Label.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Main_Page_Label.ForeColor = SystemColors.ButtonFace;
            Main_Page_Label.Location = new Point(206, 9);
            Main_Page_Label.Name = "Main_Page_Label";
            Main_Page_Label.Size = new Size(170, 41);
            Main_Page_Label.TabIndex = 29;
            Main_Page_Label.Text = "ROTATION";
            Main_Page_Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(453, 79);
            label4.Name = "label4";
            label4.Size = new Size(189, 19);
            label4.TabIndex = 38;
            label4.Text = "(Must Be An Integer)";
            // 
            // Rotation_Cipher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(647, 270);
            Controls.Add(label4);
            Controls.Add(button_back);
            Controls.Add(textBox_rotation_text);
            Controls.Add(label2);
            Controls.Add(rotation_enc_textBox);
            Controls.Add(label1);
            Controls.Add(textBox_rotation_key);
            Controls.Add(shift_key_label);
            Controls.Add(button_enc);
            Controls.Add(Main_Page_Label);
            Name = "Rotation_Cipher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rotation_Cipher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_back;
        private TextBox textBox_rotation_text;
        private Label label2;
        private TextBox rotation_enc_textBox;
        private Label label1;
        private TextBox textBox_rotation_key;
        private Label shift_key_label;
        private Button button_enc;
        private Label Main_Page_Label;
        private Label label4;
    }
}