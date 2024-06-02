namespace Lab4.Forms.Admin.Event_forms
{
    partial class AdminModifyEventForm
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
            eventTimePicker = new DateTimePicker();
            addEventButton = new Button();
            label2 = new Label();
            label3 = new Label();
            eventDescriptionRTextBox = new RichTextBox();
            eventDatePicker = new DateTimePicker();
            label4 = new Label();
            eventNameTextBox = new TextBox();
            pickEventComboBox = new ComboBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(eventTimePicker);
            groupBox1.Controls.Add(addEventButton);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(eventDescriptionRTextBox);
            groupBox1.Controls.Add(eventDatePicker);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(eventNameTextBox);
            groupBox1.Location = new Point(12, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 301);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nowe wartości";
            // 
            // eventTimePicker
            // 
            eventTimePicker.Format = DateTimePickerFormat.Time;
            eventTimePicker.Location = new Point(203, 126);
            eventTimePicker.Name = "eventTimePicker";
            eventTimePicker.ShowUpDown = true;
            eventTimePicker.Size = new Size(117, 31);
            eventTimePicker.TabIndex = 7;
            eventTimePicker.Value = new DateTime(2024, 5, 25, 12, 0, 0, 0);
            // 
            // addEventButton
            // 
            addEventButton.Location = new Point(10, 163);
            addEventButton.Name = "addEventButton";
            addEventButton.Size = new Size(314, 124);
            addEventButton.TabIndex = 6;
            addEventButton.Text = "Zapisz zmiany";
            addEventButton.UseVisualStyleBackColor = true;
            addEventButton.Click += addEventButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 36);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 0;
            label2.Text = "Nazwa wydarzenia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 36);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 2;
            label3.Text = "Opis wydarzenia";
            // 
            // eventDescriptionRTextBox
            // 
            eventDescriptionRTextBox.Location = new Point(336, 64);
            eventDescriptionRTextBox.Name = "eventDescriptionRTextBox";
            eventDescriptionRTextBox.Size = new Size(432, 223);
            eventDescriptionRTextBox.TabIndex = 3;
            eventDescriptionRTextBox.Text = "";
            // 
            // eventDatePicker
            // 
            eventDatePicker.CustomFormat = "dd.MM.yyyy";
            eventDatePicker.Format = DateTimePickerFormat.Custom;
            eventDatePicker.Location = new Point(16, 126);
            eventDatePicker.Name = "eventDatePicker";
            eventDatePicker.Size = new Size(181, 31);
            eventDatePicker.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 98);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 5;
            label4.Text = "Data wydarzenia";
            // 
            // eventNameTextBox
            // 
            eventNameTextBox.Location = new Point(16, 64);
            eventNameTextBox.Name = "eventNameTextBox";
            eventNameTextBox.Size = new Size(304, 31);
            eventNameTextBox.TabIndex = 1;
            // 
            // pickEventComboBox
            // 
            pickEventComboBox.FormattingEnabled = true;
            pickEventComboBox.Location = new Point(201, 34);
            pickEventComboBox.Name = "pickEventComboBox";
            pickEventComboBox.Size = new Size(396, 33);
            pickEventComboBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 37);
            label6.Name = "label6";
            label6.Size = new Size(173, 25);
            label6.TabIndex = 12;
            label6.Text = "Wybierz wydarzenie:";
            // 
            // AdminModifyEventForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 403);
            Controls.Add(pickEventComboBox);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Name = "AdminModifyEventForm";
            Text = "Edytuj wydarzenie";
            Load += AdminModifyEventForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Button addEventButton;
        private Label label2;
        private Label label3;
        private RichTextBox eventDescriptionRTextBox;
        private DateTimePicker eventDatePicker;
        private Label label4;
        private TextBox eventNameTextBox;
        private ComboBox pickEventComboBox;
        private Label label6;
        private DateTimePicker eventTimePicker;
    }
}