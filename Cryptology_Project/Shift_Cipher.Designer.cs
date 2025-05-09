namespace Cryptology_Project
{
    partial class Shift_Cipher
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
            shift_enc_button = new Button();
            textbox_shiftkey = new TextBox();
            shift_key_label = new Label();
            label1 = new Label();
            shift_textBox = new TextBox();
            textBox_shifttext = new TextBox();
            label2 = new Label();
            button_back = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // Main_Page_Label
            // 
            Main_Page_Label.AutoSize = true;
            Main_Page_Label.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Main_Page_Label.ForeColor = SystemColors.ButtonFace;
            Main_Page_Label.Location = new Point(236, 9);
            Main_Page_Label.Name = "Main_Page_Label";
            Main_Page_Label.Size = new Size(113, 41);
            Main_Page_Label.TabIndex = 11;
            Main_Page_Label.Text = "SHIFT";
            Main_Page_Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // shift_enc_button
            // 
            shift_enc_button.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            shift_enc_button.Location = new Point(236, 172);
            shift_enc_button.Name = "shift_enc_button";
            shift_enc_button.Size = new Size(139, 45);
            shift_enc_button.TabIndex = 12;
            shift_enc_button.Text = "ENCRYPT";
            shift_enc_button.UseVisualStyleBackColor = true;
            shift_enc_button.Click += shift_enc_button_Click;
            // 
            // textbox_shiftkey
            // 
            textbox_shiftkey.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textbox_shiftkey.Location = new Point(271, 74);
            textbox_shiftkey.Name = "textbox_shiftkey";
            textbox_shiftkey.Size = new Size(163, 29);
            textbox_shiftkey.TabIndex = 14;
            // 
            // shift_key_label
            // 
            shift_key_label.AutoSize = true;
            shift_key_label.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            shift_key_label.ForeColor = Color.White;
            shift_key_label.Location = new Point(178, 75);
            shift_key_label.Name = "shift_key_label";
            shift_key_label.Size = new Size(70, 24);
            shift_key_label.TabIndex = 13;
            shift_key_label.Text = "Key :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 246);
            label1.Name = "label1";
            label1.Size = new Size(142, 24);
            label1.TabIndex = 15;
            label1.Text = "Encrypted :";
            // 
            // shift_textBox
            // 
            shift_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            shift_textBox.Location = new Point(160, 245);
            shift_textBox.Name = "shift_textBox";
            shift_textBox.ReadOnly = true;
            shift_textBox.Size = new Size(463, 29);
            shift_textBox.TabIndex = 16;
            // 
            // textBox_shifttext
            // 
            textBox_shifttext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_shifttext.Location = new Point(271, 117);
            textBox_shifttext.Name = "textBox_shifttext";
            textBox_shifttext.Size = new Size(163, 29);
            textBox_shifttext.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(178, 118);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 17;
            label2.Text = "Text :";
            // 
            // button_back
            // 
            button_back.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_back.Location = new Point(12, 17);
            button_back.Name = "button_back";
            button_back.Size = new Size(48, 33);
            button_back.TabIndex = 19;
            button_back.Text = "<--";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(440, 79);
            label4.Name = "label4";
            label4.Size = new Size(189, 19);
            label4.TabIndex = 39;
            label4.Text = "(Must Be An Integer)";
            // 
            // Shift_Cipher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(635, 302);
            Controls.Add(label4);
            Controls.Add(button_back);
            Controls.Add(textBox_shifttext);
            Controls.Add(label2);
            Controls.Add(shift_textBox);
            Controls.Add(label1);
            Controls.Add(textbox_shiftkey);
            Controls.Add(shift_key_label);
            Controls.Add(shift_enc_button);
            Controls.Add(Main_Page_Label);
            Name = "Shift_Cipher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shift_Cipher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Main_Page_Label;
        private Button shift_enc_button;
        private TextBox textbox_shiftkey;
        private Label shift_key_label;
        private Label label1;
        private TextBox shift_textBox;
        private TextBox textBox_shifttext;
        private Label label2;
        private Button button_back;
        private Label label4;
    }
}