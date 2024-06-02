using System.Windows.Forms;

namespace Lab4.Forms.Admin
{
    partial class AdminAddEventForm
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
            label1 = new Label();
            eventNameTextBox = new TextBox();
            label2 = new Label();
            eventDescriptionRTextBox = new RichTextBox();
            groupBox1 = new GroupBox();
            eventTimePicker = new DateTimePicker();
            addEventButton = new Button();
            eventDatePicker = new DateTimePicker();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 36);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 0;
            label1.Text = "Nazwa wydarzenia";
            // 
            // eventNameTextBox
            // 
            eventNameTextBox.Location = new Point(16, 64);
            eventNameTextBox.Name = "eventNameTextBox";
            eventNameTextBox.Size = new Size(304, 31);
            eventNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 36);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 2;
            label2.Text = "Opis wydarzenia";
            // 
            // eventDescriptionRTextBox
            // 
            eventDescriptionRTextBox.Location = new Point(336, 64);
            eventDescriptionRTextBox.Name = "eventDescriptionRTextBox";
            eventDescriptionRTextBox.Size = new Size(432, 223);
            eventDescriptionRTextBox.TabIndex = 3;
            eventDescriptionRTextBox.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(eventTimePicker);
            groupBox1.Controls.Add(addEventButton);
            groupBox1.Controls.Add(eventDatePicker);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(eventDescriptionRTextBox);
            groupBox1.Controls.Add(eventNameTextBox);
            groupBox1.Location = new Point(12, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 301);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // eventTimePicker
            // 
            eventTimePicker.Format = DateTimePickerFormat.Time;
            eventTimePicker.Location = new Point(203, 126);
            eventTimePicker.Name = "eventTimePicker";
            eventTimePicker.ShowUpDown = true;
            eventTimePicker.Size = new Size(117, 31);
            eventTimePicker.TabIndex = 10;
            eventTimePicker.Value = new DateTime(2024, 5, 25, 12, 0, 0, 0);
            // 
            // addEventButton
            // 
            addEventButton.Location = new Point(10, 163);
            addEventButton.Name = "addEventButton";
            addEventButton.Size = new Size(314, 124);
            addEventButton.TabIndex = 6;
            addEventButton.Text = "Dodaj wydarzenie";
            addEventButton.UseVisualStyleBackColor = true;
            addEventButton.Click += addEventButton_Click;
            // 
            // eventDatePicker
            // 
            eventDatePicker.CustomFormat = "dd.MM.yyyy";
            eventDatePicker.Format = DateTimePickerFormat.Custom;
            eventDatePicker.Location = new Point(16, 126);
            eventDatePicker.Name = "eventDatePicker";
            eventDatePicker.Size = new Size(181, 31);
            eventDatePicker.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 98);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 9;
            label4.Text = "Data wydarzenia";
            // 
            // AdminAddEventForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 310);
            Controls.Add(groupBox1);
            Name = "AdminAddEventForm";
            Text = "Dodaj wydarzenie";
            Load += AdminAddEventForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox eventNameTextBox;
        private Label label2;
        private RichTextBox eventDescriptionRTextBox;
        private GroupBox groupBox1;
        private Button addEventButton;
        private DateTimePicker eventTimePicker;
        private DateTimePicker eventDatePicker;
        private Label label4;
    }
}