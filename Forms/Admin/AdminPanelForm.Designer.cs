namespace Lab4.Forms
{
    partial class AdminPanelForm
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
            refreshGridsButton = new Button();
            userDataGridView = new DataGridView();
            resetPasswordButton = new Button();
            addUserButton = new Button();
            removeUserButton = new Button();
            groupBox2 = new GroupBox();
            eventDataGridView = new DataGridView();
            modifyEventButton = new Button();
            removeEventButton = new Button();
            addEventButton = new Button();
            groupBox3 = new GroupBox();
            requestDataGridView = new DataGridView();
            confirmRequestButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eventDataGridView).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)requestDataGridView).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(refreshGridsButton);
            groupBox1.Controls.Add(userDataGridView);
            groupBox1.Controls.Add(resetPasswordButton);
            groupBox1.Controls.Add(addUserButton);
            groupBox1.Controls.Add(removeUserButton);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(842, 854);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Użytkownicy";
            // 
            // refreshGridsButton
            // 
            refreshGridsButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 238);
            refreshGridsButton.Location = new Point(722, 37);
            refreshGridsButton.Name = "refreshGridsButton";
            refreshGridsButton.Size = new Size(108, 59);
            refreshGridsButton.TabIndex = 4;
            refreshGridsButton.Text = "⟳";
            refreshGridsButton.UseVisualStyleBackColor = true;
            refreshGridsButton.Click += refreshGridsButton_Click;
            // 
            // userDataGridView
            // 
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(21, 103);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.RowHeadersWidth = 62;
            userDataGridView.Size = new Size(809, 736);
            userDataGridView.TabIndex = 3;
            // 
            // resetPasswordButton
            // 
            resetPasswordButton.Location = new Point(405, 38);
            resetPasswordButton.Name = "resetPasswordButton";
            resetPasswordButton.Size = new Size(186, 59);
            resetPasswordButton.TabIndex = 2;
            resetPasswordButton.Text = "Resetuj hasło";
            resetPasswordButton.UseVisualStyleBackColor = true;
            resetPasswordButton.Click += resetPasswordButton_Click;
            // 
            // addUserButton
            // 
            addUserButton.Location = new Point(21, 38);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(186, 59);
            addUserButton.TabIndex = 0;
            addUserButton.Text = "Dodaj użytkownika";
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // removeUserButton
            // 
            removeUserButton.Location = new Point(213, 38);
            removeUserButton.Name = "removeUserButton";
            removeUserButton.Size = new Size(186, 59);
            removeUserButton.TabIndex = 1;
            removeUserButton.Text = "Usuń użytkownika";
            removeUserButton.UseVisualStyleBackColor = true;
            removeUserButton.Click += removeUserButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(eventDataGridView);
            groupBox2.Controls.Add(modifyEventButton);
            groupBox2.Controls.Add(removeEventButton);
            groupBox2.Controls.Add(addEventButton);
            groupBox2.Location = new Point(860, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(985, 460);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Wydarzenia";
            // 
            // eventDataGridView
            // 
            eventDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eventDataGridView.Location = new Point(17, 103);
            eventDataGridView.Name = "eventDataGridView";
            eventDataGridView.RowHeadersWidth = 62;
            eventDataGridView.Size = new Size(953, 340);
            eventDataGridView.TabIndex = 4;
            // 
            // modifyEventButton
            // 
            modifyEventButton.Location = new Point(381, 38);
            modifyEventButton.Name = "modifyEventButton";
            modifyEventButton.Size = new Size(176, 59);
            modifyEventButton.TabIndex = 5;
            modifyEventButton.Text = "Edytuj wydarzenie";
            modifyEventButton.UseVisualStyleBackColor = true;
            modifyEventButton.Click += modifyEventButton_Click;
            // 
            // removeEventButton
            // 
            removeEventButton.Location = new Point(199, 38);
            removeEventButton.Name = "removeEventButton";
            removeEventButton.Size = new Size(176, 59);
            removeEventButton.TabIndex = 4;
            removeEventButton.Text = "Usuń wydarzenie";
            removeEventButton.UseVisualStyleBackColor = true;
            removeEventButton.Click += removeEventButton_Click;
            // 
            // addEventButton
            // 
            addEventButton.Location = new Point(17, 38);
            addEventButton.Name = "addEventButton";
            addEventButton.Size = new Size(176, 59);
            addEventButton.TabIndex = 0;
            addEventButton.Text = "Dodaj wydarzenie";
            addEventButton.UseVisualStyleBackColor = true;
            addEventButton.Click += addEventButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(requestDataGridView);
            groupBox3.Controls.Add(confirmRequestButton);
            groupBox3.Location = new Point(860, 478);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(985, 388);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Zapisy";
            // 
            // requestDataGridView
            // 
            requestDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestDataGridView.Location = new Point(17, 100);
            requestDataGridView.Name = "requestDataGridView";
            requestDataGridView.RowHeadersWidth = 62;
            requestDataGridView.Size = new Size(953, 273);
            requestDataGridView.TabIndex = 6;
            // 
            // confirmRequestButton
            // 
            confirmRequestButton.Location = new Point(17, 34);
            confirmRequestButton.Name = "confirmRequestButton";
            confirmRequestButton.Size = new Size(176, 59);
            confirmRequestButton.TabIndex = 0;
            confirmRequestButton.Text = "Zarządzaj zapisem";
            confirmRequestButton.UseVisualStyleBackColor = true;
            confirmRequestButton.Click += confirmRequestButton_Click;
            // 
            // AdminPanelForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1854, 874);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximumSize = new Size(1876, 930);
            MinimumSize = new Size(1876, 930);
            Name = "AdminPanelForm";
            Text = "Panel administratora";
            Load += AdminPanelForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)eventDataGridView).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)requestDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button addUserButton;
        private Button removeUserButton;
        private Button resetPasswordButton;
        private Button refreshGridsButton;
        private DataGridView userDataGridView;

        private GroupBox groupBox2;
        private Button addEventButton;
        private Button removeEventButton;
        private Button modifyEventButton;
        private DataGridView eventDataGridView;

        private GroupBox groupBox3;
        private Button confirmRequestButton;
        private DataGridView requestDataGridView;
    }
}