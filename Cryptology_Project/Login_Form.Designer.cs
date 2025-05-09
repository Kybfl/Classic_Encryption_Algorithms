namespace Cryptology_Project
{
    partial class Login_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            topic_label = new Label();
            button_exit = new Button();
            button_login = new Button();
            username_label = new Label();
            password_label = new Label();
            username_textbox = new TextBox();
            password_textbox = new TextBox();
            SuspendLayout();
            // 
            // topic_label
            // 
            topic_label.Anchor = AnchorStyles.Top;
            topic_label.AutoSize = true;
            topic_label.Font = new Font("Consolas", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            topic_label.ForeColor = Color.Snow;
            topic_label.Location = new Point(122, 8);
            topic_label.Name = "topic_label";
            topic_label.Size = new Size(382, 75);
            topic_label.TabIndex = 0;
            topic_label.Text = "CRYPTOLOGY";
            topic_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // button_exit
            // 
            button_exit.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_exit.Location = new Point(122, 282);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(174, 41);
            button_exit.TabIndex = 1;
            button_exit.Text = "EXIT";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += Exit;
            // 
            // button_login
            // 
            button_login.Font = new Font("Consolas", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_login.Location = new Point(330, 282);
            button_login.Name = "button_login";
            button_login.Size = new Size(174, 41);
            button_login.TabIndex = 2;
            button_login.Text = "LOGIN";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += Login;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            username_label.ForeColor = Color.White;
            username_label.Location = new Point(146, 131);
            username_label.Name = "username_label";
            username_label.Size = new Size(130, 24);
            username_label.TabIndex = 3;
            username_label.Text = "Username :";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            password_label.ForeColor = Color.White;
            password_label.Location = new Point(146, 190);
            password_label.Name = "password_label";
            password_label.Size = new Size(130, 24);
            password_label.TabIndex = 4;
            password_label.Text = "Password :";
            // 
            // username_textbox
            // 
            username_textbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            username_textbox.Location = new Point(282, 131);
            username_textbox.Name = "username_textbox";
            username_textbox.Size = new Size(163, 29);
            username_textbox.TabIndex = 5;
            // 
            // password_textbox
            // 
            password_textbox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            password_textbox.Location = new Point(282, 190);
            password_textbox.Name = "password_textbox";
            password_textbox.PasswordChar = '*';
            password_textbox.Size = new Size(163, 29);
            password_textbox.TabIndex = 6;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(622, 364);
            Controls.Add(password_textbox);
            Controls.Add(username_textbox);
            Controls.Add(password_label);
            Controls.Add(username_label);
            Controls.Add(button_login);
            Controls.Add(button_exit);
            Controls.Add(topic_label);
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRYPTOLOGY PROJECT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label topic_label;
        private Button button_exit;
        private Button button_login;
        private Label username_label;
        private Label password_label;
        private TextBox username_textbox;
        private TextBox password_textbox;
    }
}
