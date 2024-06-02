namespace Lab4
{
    partial class LoginForm
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
            groupBox1 = new GroupBox();
            loginButton = new Button();
            regLink = new Label();
            passTextBox = new TextBox();
            loginTextBox = new TextBox();
            label1 = new Label();
            showPassButton = new CheckBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(loginButton);
            groupBox1.Controls.Add(regLink);
            groupBox1.Controls.Add(passTextBox);
            groupBox1.Controls.Add(loginTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(showPassButton);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.MaximumSize = new Size(360, 240);
            groupBox1.MinimumSize = new Size(360, 240);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 240);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Logowanie";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(185, 80);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(132, 31);
            loginButton.TabIndex = 7;
            loginButton.Text = "Zaloguj";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // regLink
            // 
            regLink.AutoSize = true;
            regLink.BackColor = SystemColors.Control;
            regLink.Cursor = Cursors.Hand;
            regLink.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            regLink.ForeColor = SystemColors.MenuHighlight;
            regLink.Location = new Point(29, 176);
            regLink.Name = "regLink";
            regLink.Size = new Size(94, 25);
            regLink.TabIndex = 6;
            regLink.Text = "Rejestracja";
            regLink.Click += regLink_Click;
            // 
            // passTextBox
            // 
            passTextBox.Location = new Point(29, 142);
            passTextBox.Name = "passTextBox";
            passTextBox.PasswordChar = '*';
            passTextBox.Size = new Size(150, 31);
            passTextBox.TabIndex = 4;
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(29, 80);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(150, 31);
            loginTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 52);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // showPassButton
            // 
            showPassButton.AutoSize = true;
            showPassButton.Cursor = Cursors.Hand;
            showPassButton.Location = new Point(185, 144);
            showPassButton.Name = "showPassButton";
            showPassButton.Size = new Size(132, 29);
            showPassButton.TabIndex = 2;
            showPassButton.Text = "Pokaż hasło";
            showPassButton.UseVisualStyleBackColor = true;
            showPassButton.CheckedChanged += showPassButton_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 114);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 1;
            label2.Text = "Hasło";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 254);
            Controls.Add(groupBox1);
            MaximumSize = new Size(396, 310);
            MinimumSize = new Size(396, 310);
            Name = "LoginForm";
            Text = "Logowanie";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox passTextBox;
        private TextBox loginTextBox;
        private Label label1;
        private CheckBox showPassButton;
        private Label label2;
        private Label regLink;
        private Button loginButton;
    }
}
