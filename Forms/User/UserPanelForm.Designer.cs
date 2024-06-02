namespace Lab4
{
    partial class UserPanelForm
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
            participationTypeComboBox = new ComboBox();
            foodTypeComboBox = new ComboBox();
            label2 = new Label();
            eventComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            eventsDescriptionRTextBox = new RichTextBox();
            submitRequestButton = new Button();
            label5 = new Label();
            eventDateTextBox = new TextBox();
            groupbox1 = new GroupBox();
            userRequestsDGV = new DataGridView();
            groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userRequestsDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 135);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 0;
            label1.Text = "Typ uczestnictwa:";
            // 
            // participationTypeComboBox
            // 
            participationTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            participationTypeComboBox.FormattingEnabled = true;
            participationTypeComboBox.Items.AddRange(new object[] { "Sluchacz", "Autor", "Sponsor", "Organizator" });
            participationTypeComboBox.Location = new Point(12, 163);
            participationTypeComboBox.Name = "participationTypeComboBox";
            participationTypeComboBox.Size = new Size(316, 33);
            participationTypeComboBox.TabIndex = 1;
            // 
            // foodTypeComboBox
            // 
            foodTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            foodTypeComboBox.FormattingEnabled = true;
            foodTypeComboBox.Items.AddRange(new object[] { "Bez preferencji", "Wegetariańskie", "Bez glutenu" });
            foodTypeComboBox.Location = new Point(12, 227);
            foodTypeComboBox.Name = "foodTypeComboBox";
            foodTypeComboBox.Size = new Size(316, 33);
            foodTypeComboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 199);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 2;
            label2.Text = "Wyżywienie:";
            // 
            // eventComboBox
            // 
            eventComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            eventComboBox.FormattingEnabled = true;
            eventComboBox.Location = new Point(12, 37);
            eventComboBox.Name = "eventComboBox";
            eventComboBox.Size = new Size(316, 33);
            eventComboBox.TabIndex = 5;
            eventComboBox.SelectedIndexChanged += eventComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(161, 25);
            label3.TabIndex = 4;
            label3.Text = "Nazwa wydarzenia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 73);
            label4.Name = "label4";
            label4.Size = new Size(142, 25);
            label4.TabIndex = 7;
            label4.Text = "Data wydarzenia";
            // 
            // eventsDescriptionRTextBox
            // 
            eventsDescriptionRTextBox.Location = new Point(357, 37);
            eventsDescriptionRTextBox.Name = "eventsDescriptionRTextBox";
            eventsDescriptionRTextBox.Size = new Size(473, 281);
            eventsDescriptionRTextBox.TabIndex = 8;
            eventsDescriptionRTextBox.Text = "";
            // 
            // submitRequestButton
            // 
            submitRequestButton.Location = new Point(12, 275);
            submitRequestButton.Name = "submitRequestButton";
            submitRequestButton.Size = new Size(316, 34);
            submitRequestButton.TabIndex = 9;
            submitRequestButton.Text = "Zapisz na wydarzenie";
            submitRequestButton.UseVisualStyleBackColor = true;
            submitRequestButton.Click += submitRequestButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(357, 9);
            label5.Name = "label5";
            label5.Size = new Size(146, 25);
            label5.TabIndex = 10;
            label5.Text = "Opis wydarzenia:";
            // 
            // eventDateTextBox
            // 
            eventDateTextBox.Location = new Point(12, 101);
            eventDateTextBox.Name = "eventDateTextBox";
            eventDateTextBox.Size = new Size(316, 31);
            eventDateTextBox.TabIndex = 11;
            // 
            // groupbox1
            // 
            groupbox1.Controls.Add(userRequestsDGV);
            groupbox1.Location = new Point(12, 328);
            groupbox1.Name = "groupbox1";
            groupbox1.Size = new Size(819, 391);
            groupbox1.TabIndex = 12;
            groupbox1.TabStop = false;
            groupbox1.Text = "Twoje zapisy - przyjęcia i odrzucenia";
            // 
            // userRequestsDGV
            // 
            userRequestsDGV.AllowUserToAddRows = false;
            userRequestsDGV.AllowUserToDeleteRows = false;
            userRequestsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userRequestsDGV.Location = new Point(6, 30);
            userRequestsDGV.Name = "userRequestsDGV";
            userRequestsDGV.ReadOnly = true;
            userRequestsDGV.RowHeadersWidth = 62;
            userRequestsDGV.Size = new Size(802, 352);
            userRequestsDGV.TabIndex = 0;
            // 
            // UserPanelForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 731);
            Controls.Add(groupbox1);
            Controls.Add(eventDateTextBox);
            Controls.Add(label5);
            Controls.Add(submitRequestButton);
            Controls.Add(eventsDescriptionRTextBox);
            Controls.Add(label4);
            Controls.Add(eventComboBox);
            Controls.Add(label3);
            Controls.Add(foodTypeComboBox);
            Controls.Add(label2);
            Controls.Add(participationTypeComboBox);
            Controls.Add(label1);
            MinimumSize = new Size(826, 386);
            Name = "UserPanelForm";
            Text = "Wybierz wydarzenie";
            groupbox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userRequestsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
            Load += UserPanelForm_Load;
        }

        private void UserPanelForm_Load1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private ComboBox participationTypeComboBox;
        private ComboBox foodTypeComboBox;
        private Label label2;
        public ComboBox eventComboBox;
        private Label label3;
        private Label label4;
        private RichTextBox eventsDescriptionRTextBox;
        private Button submitRequestButton;
        private Label label5;
        private TextBox eventDateTextBox;
        private GroupBox groupbox1;
        public DataGridView userRequestsDGV;
    }
}