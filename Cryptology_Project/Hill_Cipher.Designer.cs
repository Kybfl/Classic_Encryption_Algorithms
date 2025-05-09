namespace Cryptology_Project
{
    partial class Hill_Cipher
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
            textBox_hilltext = new TextBox();
            label2 = new Label();
            hill_textBox = new TextBox();
            label1 = new Label();
            textbox_rowkey = new TextBox();
            shift_key_label = new Label();
            ok_button = new Button();
            Main_Page_Label = new Label();
            label3 = new Label();
            textBox_columnkey = new TextBox();
            label4 = new Label();
            textBox_matris = new TextBox();
            button1 = new Button();
            button_enc = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button_back.Location = new Point(16, 17);
            button_back.Name = "button_back";
            button_back.Size = new Size(48, 33);
            button_back.TabIndex = 37;
            button_back.Text = "<--";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // textBox_hilltext
            // 
            textBox_hilltext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_hilltext.Location = new Point(223, 361);
            textBox_hilltext.Name = "textBox_hilltext";
            textBox_hilltext.Size = new Size(337, 29);
            textBox_hilltext.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(135, 362);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 35;
            label2.Text = "Text :";
            // 
            // hill_textBox
            // 
            hill_textBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            hill_textBox.Location = new Point(232, 474);
            hill_textBox.Name = "hill_textBox";
            hill_textBox.ReadOnly = true;
            hill_textBox.Size = new Size(337, 29);
            hill_textBox.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(84, 475);
            label1.Name = "label1";
            label1.Size = new Size(142, 24);
            label1.TabIndex = 33;
            label1.Text = "Encrypted :";
            // 
            // textbox_rowkey
            // 
            textbox_rowkey.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textbox_rowkey.Location = new Point(332, 74);
            textbox_rowkey.Name = "textbox_rowkey";
            textbox_rowkey.Size = new Size(163, 29);
            textbox_rowkey.TabIndex = 32;
            // 
            // shift_key_label
            // 
            shift_key_label.AutoSize = true;
            shift_key_label.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            shift_key_label.ForeColor = Color.White;
            shift_key_label.Location = new Point(52, 79);
            shift_key_label.Name = "shift_key_label";
            shift_key_label.Size = new Size(274, 24);
            shift_key_label.TabIndex = 31;
            shift_key_label.Text = "Key Matrix Row Length:";
            // 
            // ok_button
            // 
            ok_button.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ok_button.Location = new Point(277, 203);
            ok_button.Name = "ok_button";
            ok_button.Size = new Size(139, 45);
            ok_button.TabIndex = 30;
            ok_button.Text = "CHECK";
            ok_button.UseVisualStyleBackColor = true;
            ok_button.Click += ok_button_Click;
            // 
            // Main_Page_Label
            // 
            Main_Page_Label.AutoSize = true;
            Main_Page_Label.Font = new Font("Consolas", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Main_Page_Label.ForeColor = SystemColors.ButtonFace;
            Main_Page_Label.Location = new Point(299, 7);
            Main_Page_Label.Name = "Main_Page_Label";
            Main_Page_Label.Size = new Size(94, 41);
            Main_Page_Label.TabIndex = 29;
            Main_Page_Label.Text = "HILL";
            Main_Page_Label.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 115);
            label3.Name = "label3";
            label3.Size = new Size(310, 24);
            label3.TabIndex = 31;
            label3.Text = "Key Matrix Column Length:";
            // 
            // textBox_columnkey
            // 
            textBox_columnkey.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_columnkey.Location = new Point(332, 114);
            textBox_columnkey.Name = "textBox_columnkey";
            textBox_columnkey.Size = new Size(163, 29);
            textBox_columnkey.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(84, 160);
            label4.Name = "label4";
            label4.Size = new Size(154, 24);
            label4.TabIndex = 31;
            label4.Text = "Key Matrix :";
            // 
            // textBox_matris
            // 
            textBox_matris.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_matris.Location = new Point(244, 160);
            textBox_matris.Name = "textBox_matris";
            textBox_matris.Size = new Size(319, 29);
            textBox_matris.TabIndex = 32;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(185, 268);
            button1.Name = "button1";
            button1.Size = new Size(332, 69);
            button1.TabIndex = 30;
            button1.Text = "enter matrix elements with commas between them according to the matrix size you entered";
            button1.UseVisualStyleBackColor = true;
            button1.Click += hill_enc_button_Click;
            // 
            // button_enc
            // 
            button_enc.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_enc.Location = new Point(277, 410);
            button_enc.Name = "button_enc";
            button_enc.Size = new Size(139, 45);
            button_enc.TabIndex = 30;
            button_enc.Text = "ENCRYPT";
            button_enc.UseVisualStyleBackColor = true;
            button_enc.Click += hill_enc_button_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(501, 79);
            label5.Name = "label5";
            label5.Size = new Size(189, 19);
            label5.TabIndex = 38;
            label5.Text = "(Must Be An Integer)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.White;
            label6.Location = new Point(501, 119);
            label6.Name = "label6";
            label6.Size = new Size(189, 19);
            label6.TabIndex = 39;
            label6.Text = "(Must Be An Integer)";
            // 
            // Hill_Cipher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(692, 523);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button_back);
            Controls.Add(textBox_hilltext);
            Controls.Add(label2);
            Controls.Add(hill_textBox);
            Controls.Add(label1);
            Controls.Add(textBox_matris);
            Controls.Add(textBox_columnkey);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textbox_rowkey);
            Controls.Add(shift_key_label);
            Controls.Add(button1);
            Controls.Add(button_enc);
            Controls.Add(ok_button);
            Controls.Add(Main_Page_Label);
            Name = "Hill_Cipher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hill_Cipher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_back;
        private TextBox textBox_hilltext;
        private Label label2;
        private TextBox hill_textBox;
        private Label label1;
        private TextBox textbox_rowkey;
        private Label shift_key_label;
        private Button ok_button;
        private Label Main_Page_Label;
        private Label label3;
        private TextBox textBox_columnkey;
        private Label label4;
        private TextBox textBox_matris;
        private Button button1;
        private Button button_enc;
        private Label label5;
        private Label label6;
    }
}