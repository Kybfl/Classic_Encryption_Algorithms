namespace Cryptology_Project
{
    partial class Rail_Fence_Cipher
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
            textBox_railtext = new TextBox();
            label2 = new Label();
            rail_textBox = new TextBox();
            label1 = new Label();
            textbox_railkey = new TextBox();
            shift_key_label = new Label();
            rail_enc_button = new Button();
            Main_Page_Label = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_back.Location = new Point(15, 17);
            button_back.Name = "button_back";
            button_back.Size = new Size(48, 33);
            button_back.TabIndex = 28;
            button_back.Text = "<--";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // textBox_railtext
            // 
            textBox_railtext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_railtext.Location = new Point(274, 117);
            textBox_railtext.Name = "textBox_railtext";
            textBox_railtext.Size = new Size(163, 29);
            textBox_railtext.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(181, 118);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 26;
            label2.Text = "Text :";
            // 
            // rail_textBox
            // 
            rail_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rail_textBox.Location = new Point(163, 245);
            rail_textBox.Name = "rail_textBox";
            rail_textBox.ReadOnly = true;
            rail_textBox.Size = new Size(463, 29);
            rail_textBox.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 246);
            label1.Name = "label1";
            label1.Size = new Size(142, 24);
            label1.TabIndex = 24;
            label1.Text = "Encrypted :";
            // 
            // textbox_railkey
            // 
            textbox_railkey.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textbox_railkey.Location = new Point(274, 74);
            textbox_railkey.Name = "textbox_railkey";
            textbox_railkey.Size = new Size(163, 29);
            textbox_railkey.TabIndex = 23;
            // 
            // shift_key_label
            // 
            shift_key_label.AutoSize = true;
            shift_key_label.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            shift_key_label.ForeColor = Color.White;
            shift_key_label.Location = new Point(193, 75);
            shift_key_label.Name = "shift_key_label";
            shift_key_label.Size = new Size(70, 24);
            shift_key_label.TabIndex = 22;
            shift_key_label.Text = "Key :";
            // 
            // rail_enc_button
            // 
            rail_enc_button.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            rail_enc_button.Location = new Point(239, 172);
            rail_enc_button.Name = "rail_enc_button";
            rail_enc_button.Size = new Size(139, 45);
            rail_enc_button.TabIndex = 21;
            rail_enc_button.Text = "ENCRYPT";
            rail_enc_button.UseVisualStyleBackColor = true;
            rail_enc_button.Click += rail_enc_button_Click;
            // 
            // Main_Page_Label
            // 
            Main_Page_Label.AutoSize = true;
            Main_Page_Label.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Main_Page_Label.ForeColor = SystemColors.ButtonFace;
            Main_Page_Label.Location = new Point(239, 9);
            Main_Page_Label.Name = "Main_Page_Label";
            Main_Page_Label.Size = new Size(208, 41);
            Main_Page_Label.TabIndex = 20;
            Main_Page_Label.Text = "RAIL FENCE";
            Main_Page_Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(443, 79);
            label4.Name = "label4";
            label4.Size = new Size(189, 19);
            label4.TabIndex = 29;
            label4.Text = "(Must Be An Integer)";
            // 
            // Rail_Fence_Cipher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(641, 298);
            Controls.Add(label4);
            Controls.Add(button_back);
            Controls.Add(textBox_railtext);
            Controls.Add(label2);
            Controls.Add(rail_textBox);
            Controls.Add(label1);
            Controls.Add(textbox_railkey);
            Controls.Add(shift_key_label);
            Controls.Add(rail_enc_button);
            Controls.Add(Main_Page_Label);
            Name = "Rail_Fence_Cipher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rail_Fence_Cipher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_back;
        private TextBox textBox_railtext;
        private Label label2;
        private TextBox rail_textBox;
        private Label label1;
        private TextBox textbox_railkey;
        private Label shift_key_label;
        private Button rail_enc_button;
        private Label Main_Page_Label;
        private Label label4;
    }
}