namespace Lab4
{
    partial class RegistrationForm
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
            groupBox1 = new GroupBox();
            label2 = new Label();
            registerButton = new Button();
            label1 = new Label();
            passwordRepeatTextBox = new TextBox();
            label6 = new Label();
            passwordTextBox = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            loginTextBox = new TextBox();
            emailTextBox = new TextBox();
            lastnameTextBox = new TextBox();
            firstnameTextBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(registerButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(passwordRepeatTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(passwordTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(loginTextBox);
            groupBox1.Controls.Add(emailTextBox);
            groupBox1.Controls.Add(lastnameTextBox);
            groupBox1.Controls.Add(firstnameTextBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 324);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rejestracja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 88);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // registerButton
            // 
            registerButton.Dock = DockStyle.Bottom;
            registerButton.Location = new Point(3, 287);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(312, 34);
            registerButton.TabIndex = 12;
            registerButton.Text = "Utwórz konto!";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 51);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 0;
            label1.Text = "Imie";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordRepeatTextBox
            // 
            passwordRepeatTextBox.Location = new Point(147, 233);
            passwordRepeatTextBox.Name = "passwordRepeatTextBox";
            passwordRepeatTextBox.PasswordChar = '*';
            passwordRepeatTextBox.Size = new Size(150, 31);
            passwordRepeatTextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 236);
            label6.Name = "label6";
            label6.Size = new Size(124, 25);
            label6.TabIndex = 7;
            label6.Text = "Powtórz hasło";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(147, 196);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(150, 31);
            passwordTextBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 199);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 4;
            label5.Text = "Hasło";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 162);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 2;
            label3.Text = "Login";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 125);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 3;
            label4.Text = "E-mail";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(147, 159);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(150, 31);
            loginTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(147, 122);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(150, 31);
            emailTextBox.TabIndex = 8;
            // 
            // lastnameTextBox
            // 
            lastnameTextBox.Location = new Point(147, 85);
            lastnameTextBox.Name = "lastnameTextBox";
            lastnameTextBox.Size = new Size(150, 31);
            lastnameTextBox.TabIndex = 6;
            // 
            // firstnameTextBox
            // 
            firstnameTextBox.Location = new Point(147, 48);
            firstnameTextBox.Name = "firstnameTextBox";
            firstnameTextBox.Size = new Size(150, 31);
            firstnameTextBox.TabIndex = 5;
            // 
            // RegistrationView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 324);
            Controls.Add(groupBox1);
            MaximumSize = new Size(340, 380);
            MinimumSize = new Size(340, 380);
            Name = "RegistrationView";
            Text = "Rejestracja";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label6;
        private TextBox firstnameTextBox;
        private TextBox lastnameTextBox;
        private TextBox emailTextBox;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
        private TextBox passwordRepeatTextBox;
        private Button registerButton;
    }
}