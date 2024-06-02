namespace Lab4.Forms.Admin.Request_administration_forms
{
    partial class AdminRequestManagerForm
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
            confirmRequestButton = new Button();
            label3 = new Label();
            decisionComboBox = new ComboBox();
            pickRequestComboBox = new ComboBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            UserNameTextBox = new TextBox();
            eventNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // confirmRequestButton
            // 
            confirmRequestButton.Location = new Point(491, 12);
            confirmRequestButton.Name = "confirmRequestButton";
            confirmRequestButton.Size = new Size(240, 152);
            confirmRequestButton.TabIndex = 29;
            confirmRequestButton.Text = "Zatwierdź";
            confirmRequestButton.UseVisualStyleBackColor = true;
            confirmRequestButton.Click += confirmRequestButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(232, 25);
            label3.TabIndex = 32;
            label3.Text = "Czy akceptujesz zgłoszenie?";
            // 
            // decisionComboBox
            // 
            decisionComboBox.FormattingEnabled = true;
            decisionComboBox.Items.AddRange(new object[] { "Tak", "Nie" });
            decisionComboBox.Location = new Point(250, 131);
            decisionComboBox.Name = "decisionComboBox";
            decisionComboBox.Size = new Size(226, 33);
            decisionComboBox.TabIndex = 33;
            // 
            // pickRequestComboBox
            // 
            pickRequestComboBox.FormattingEnabled = true;
            pickRequestComboBox.Location = new Point(250, 18);
            pickRequestComboBox.Name = "pickRequestComboBox";
            pickRequestComboBox.Size = new Size(226, 33);
            pickRequestComboBox.TabIndex = 35;
            pickRequestComboBox.SelectedIndexChanged += pickRequestComboBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 21);
            label6.Name = "label6";
            label6.Size = new Size(224, 25);
            label6.TabIndex = 34;
            label6.Text = "Wybierz numer zgłoszenia:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 60);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 36;
            label1.Text = "Nazwa użytkownika";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 37;
            label2.Text = "Nazwa wydarzenia:";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(250, 57);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(226, 31);
            UserNameTextBox.TabIndex = 38;
            // 
            // eventNameTextBox
            // 
            eventNameTextBox.Location = new Point(250, 94);
            eventNameTextBox.Name = "eventNameTextBox";
            eventNameTextBox.Size = new Size(226, 31);
            eventNameTextBox.TabIndex = 39;
            // 
            // AdminRequestManagerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 177);
            Controls.Add(eventNameTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pickRequestComboBox);
            Controls.Add(label6);
            Controls.Add(decisionComboBox);
            Controls.Add(label3);
            Controls.Add(confirmRequestButton);
            Name = "AdminRequestManagerForm";
            Text = "Zaakceptuj / Odrzuć zgłoszenia";
            Load += AdminRequestManagerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button confirmRequestButton;
        private Label label3;
        private ComboBox decisionComboBox;
        private ComboBox pickRequestComboBox;
        private Label label6;
        private Label label1;
        private Label label2;
        private TextBox UserNameTextBox;
        private TextBox eventNameTextBox;
    }
}