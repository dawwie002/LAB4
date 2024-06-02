namespace Lab4.Forms.Admin
{
    partial class AdminRemoveUserForm
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
            pickUserComboBox = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // removeUserButton
            // 
            removeUserButton.Location = new Point(57, 86);
            removeUserButton.Name = "removeUserButton";
            removeUserButton.Size = new Size(238, 93);
            removeUserButton.TabIndex = 15;
            removeUserButton.Text = "Usuń użytkownika";
            removeUserButton.UseVisualStyleBackColor = true;
            removeUserButton.Click += removeUserButton_Click;
            // 
            // pickUserComboBox
            // 
            pickUserComboBox.FormattingEnabled = true;
            pickUserComboBox.Location = new Point(203, 34);
            pickUserComboBox.Name = "pickUserComboBox";
            pickUserComboBox.Size = new Size(150, 33);
            pickUserComboBox.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 37);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 29;
            label1.Text = "Wybierz użytkownika:";
            // 
            // AdminRemoveUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 217);
            Controls.Add(pickUserComboBox);
            Controls.Add(label1);
            Controls.Add(removeUserButton);
            Name = "AdminRemoveUserForm";
            Text = "Usuń użytkownika";
            Load += AdminRemoveUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button removeUserButton;
        private ComboBox pickUserComboBox;
        private Label label1;
    }
}