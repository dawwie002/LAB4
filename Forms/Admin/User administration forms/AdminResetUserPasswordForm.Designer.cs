namespace Lab4.Forms.Admin
{
    partial class AdminResetUserPasswordForm
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
            removeUserButton = new Button();
            label3 = new Label();
            newUserPassword = new TextBox();
            label4 = new Label();
            repeatNewUserPassword = new TextBox();
            pickUserComboBox = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // removeUserButton
            // 
            removeUserButton.Location = new Point(393, 95);
            removeUserButton.Name = "removeUserButton";
            removeUserButton.Size = new Size(238, 93);
            removeUserButton.TabIndex = 20;
            removeUserButton.Text = "Zmien hasło";
            removeUserButton.UseVisualStyleBackColor = true;
            removeUserButton.Click += removeUserButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 113);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 23;
            label3.Text = "Nowe hasło:";
            // 
            // newUserPassword
            // 
            newUserPassword.Location = new Point(213, 110);
            newUserPassword.Name = "newUserPassword";
            newUserPassword.PasswordChar = '*';
            newUserPassword.Size = new Size(150, 31);
            newUserPassword.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 156);
            label4.Name = "label4";
            label4.Size = new Size(176, 25);
            label4.TabIndex = 25;
            label4.Text = "Powtórz nowe hasło:";
            // 
            // repeatNewUserPassword
            // 
            repeatNewUserPassword.Location = new Point(213, 153);
            repeatNewUserPassword.Name = "repeatNewUserPassword";
            repeatNewUserPassword.PasswordChar = '*';
            repeatNewUserPassword.Size = new Size(150, 31);
            repeatNewUserPassword.TabIndex = 26;
            // 
            // pickUserComboBox
            // 
            pickUserComboBox.FormattingEnabled = true;
            pickUserComboBox.Location = new Point(213, 44);
            pickUserComboBox.Name = "pickUserComboBox";
            pickUserComboBox.Size = new Size(150, 33);
            pickUserComboBox.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 47);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 27;
            label1.Text = "Wybierz użytkownika:";
            // 
            // AdminResetUserPasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 210);
            Controls.Add(pickUserComboBox);
            Controls.Add(label1);
            Controls.Add(repeatNewUserPassword);
            Controls.Add(label4);
            Controls.Add(newUserPassword);
            Controls.Add(label3);
            Controls.Add(removeUserButton);
            Name = "AdminResetUserPasswordForm";
            Text = "Resetuj hasło";
            Load += AdminResetUserPasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button removeUserButton;
        private Label label3;
        private TextBox newUserPassword;
        private Label label4;
        private TextBox repeatNewUserPassword;
        private ComboBox pickUserComboBox;
        private Label label1;
    }
}