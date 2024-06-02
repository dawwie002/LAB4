namespace Lab4.Forms.Admin.Event_forms
{
    partial class AdminRemoveEventForm
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
            removeEventButton = new Button();
            label1 = new Label();
            pickEventComboBox = new ComboBox();
            SuspendLayout();
            // 
            // removeEventButton
            // 
            removeEventButton.Location = new Point(12, 65);
            removeEventButton.Name = "removeEventButton";
            removeEventButton.Size = new Size(367, 112);
            removeEventButton.TabIndex = 10;
            removeEventButton.Text = "Usuń wydarzenie";
            removeEventButton.UseVisualStyleBackColor = true;
            removeEventButton.Click += removeEventButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 8;
            label1.Text = "Wybierz wydarzenie:";
            // 
            // pickEventComboBox
            // 
            pickEventComboBox.FormattingEnabled = true;
            pickEventComboBox.Location = new Point(191, 12);
            pickEventComboBox.Name = "pickEventComboBox";
            pickEventComboBox.Size = new Size(182, 33);
            pickEventComboBox.TabIndex = 11;
            // 
            // AdminRemoveEventForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 189);
            Controls.Add(pickEventComboBox);
            Controls.Add(removeEventButton);
            Controls.Add(label1);
            Name = "AdminRemoveEventForm";
            Text = "Usuń wydarzenie";
            Load += AdminRemoveEventForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button removeEventButton;
        private Label label1;
        private ComboBox pickEventComboBox;
    }
}