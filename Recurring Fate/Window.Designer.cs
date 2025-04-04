namespace Recurring_Fate
{
	partial class RecurringFate
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
			tpEntries = new TabPage();
			dgvEntries = new DataGridView();
			dgvtbclEntriesTitle = new DataGridViewTextBoxColumn();
			dgvtbclEntriesStreakDayHour = new DataGridViewTextBoxColumn();
			dgvtbclEntriesCreatedOn = new DataGridViewTextBoxColumn();
			dgvbtnclEntriesShowEntry = new DataGridViewButtonColumn();
			dgvbtnclEntriesDeleteEntry = new DataGridViewButtonColumn();
			tpMain = new TabPage();
			lblMainDesc = new Label();
			lblMainSubtext = new Label();
			lblMainTitle = new Label();
			tcWindow = new TabControl();
			tpCreate = new TabPage();
			dtpCreateTimeOfEntry = new DateTimePicker();
			tbCreateDescEntry = new TextBox();
			btnCreateClear = new Button();
			btnCreateUpdateEntry = new Button();
			tbCreateTitleOfEntry = new TextBox();
			tpOptions = new TabPage();
			btnOptionsLoadEntries = new Button();
			btnOptionsSaveEntries = new Button();
			tpEntries.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvEntries).BeginInit();
			tpMain.SuspendLayout();
			tcWindow.SuspendLayout();
			tpCreate.SuspendLayout();
			tpOptions.SuspendLayout();
			SuspendLayout();
			// 
			// tpEntries
			// 
			tpEntries.Controls.Add(dgvEntries);
			tpEntries.Location = new Point(4, 27);
			tpEntries.Name = "tpEntries";
			tpEntries.Padding = new Padding(3);
			tpEntries.Size = new Size(496, 450);
			tpEntries.TabIndex = 3;
			tpEntries.Text = "Entries";
			tpEntries.UseVisualStyleBackColor = true;
			// 
			// dgvEntries
			// 
			dgvEntries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvEntries.Columns.AddRange(new DataGridViewColumn[] { dgvtbclEntriesTitle, dgvtbclEntriesStreakDayHour, dgvtbclEntriesCreatedOn, dgvbtnclEntriesShowEntry, dgvbtnclEntriesDeleteEntry });
			dgvEntries.Dock = DockStyle.Top;
			dgvEntries.Location = new Point(3, 3);
			dgvEntries.Name = "dgvEntries";
			dgvEntries.RowHeadersWidth = 20;
			dgvEntries.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dgvEntries.Size = new Size(490, 329);
			dgvEntries.TabIndex = 0;
			dgvEntries.CellContentClick += dgvEntries_CellContentClick;
			dgvEntries.ColumnHeaderMouseClick += dgvEntries_ColumnHeaderMouseClick;
			dgvEntries.KeyDown += KeyDownEvent;
			// 
			// dgvtbclEntriesTitle
			// 
			dgvtbclEntriesTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dgvtbclEntriesTitle.DataPropertyName = "Title";
			dgvtbclEntriesTitle.HeaderText = "Title";
			dgvtbclEntriesTitle.MaxInputLength = 50;
			dgvtbclEntriesTitle.Name = "dgvtbclEntriesTitle";
			dgvtbclEntriesTitle.ReadOnly = true;
			dgvtbclEntriesTitle.Resizable = DataGridViewTriState.False;
			// 
			// dgvtbclEntriesStreakDayHour
			// 
			dgvtbclEntriesStreakDayHour.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgvtbclEntriesStreakDayHour.DataPropertyName = "StreakDayHour";
			dgvtbclEntriesStreakDayHour.HeaderText = "Streak";
			dgvtbclEntriesStreakDayHour.Name = "dgvtbclEntriesStreakDayHour";
			dgvtbclEntriesStreakDayHour.ReadOnly = true;
			dgvtbclEntriesStreakDayHour.Width = 64;
			// 
			// dgvtbclEntriesCreatedOn
			// 
			dgvtbclEntriesCreatedOn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgvtbclEntriesCreatedOn.DataPropertyName = "CreatedOn";
			dgvtbclEntriesCreatedOn.HeaderText = "Created On";
			dgvtbclEntriesCreatedOn.Name = "dgvtbclEntriesCreatedOn";
			dgvtbclEntriesCreatedOn.ReadOnly = true;
			dgvtbclEntriesCreatedOn.Width = 92;
			// 
			// dgvbtnclEntriesShowEntry
			// 
			dgvbtnclEntriesShowEntry.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			dgvbtnclEntriesShowEntry.HeaderText = "Show Entry";
			dgvbtnclEntriesShowEntry.Name = "dgvbtnclEntriesShowEntry";
			dgvbtnclEntriesShowEntry.ReadOnly = true;
			dgvbtnclEntriesShowEntry.Width = 72;
			// 
			// dgvbtnclEntriesDeleteEntry
			// 
			dgvbtnclEntriesDeleteEntry.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
			dgvbtnclEntriesDeleteEntry.HeaderText = "Delete Entry";
			dgvbtnclEntriesDeleteEntry.Name = "dgvbtnclEntriesDeleteEntry";
			dgvbtnclEntriesDeleteEntry.ReadOnly = true;
			dgvbtnclEntriesDeleteEntry.Width = 76;
			// 
			// tpMain
			// 
			tpMain.Controls.Add(lblMainDesc);
			tpMain.Controls.Add(lblMainSubtext);
			tpMain.Controls.Add(lblMainTitle);
			tpMain.Location = new Point(4, 27);
			tpMain.Name = "tpMain";
			tpMain.Padding = new Padding(3);
			tpMain.RightToLeft = RightToLeft.No;
			tpMain.Size = new Size(496, 450);
			tpMain.TabIndex = 0;
			tpMain.Text = "Main";
			tpMain.UseVisualStyleBackColor = true;
			// 
			// lblMainDesc
			// 
			lblMainDesc.Font = new Font("Bahnschrift", 11F);
			lblMainDesc.Location = new Point(34, 221);
			lblMainDesc.Name = "lblMainDesc";
			lblMainDesc.Size = new Size(419, 86);
			lblMainDesc.TabIndex = 0;
			lblMainDesc.Text = "If you don't know what this is, then I advise you to turn back... \r\nbefore losing something important to you...\r\n\r\nOr perhaps you use this program for something else...\r\n\r\n";
			// 
			// lblMainSubtext
			// 
			lblMainSubtext.AutoSize = true;
			lblMainSubtext.Font = new Font("Bahnschrift", 15F);
			lblMainSubtext.Location = new Point(109, 176);
			lblMainSubtext.Name = "lblMainSubtext";
			lblMainSubtext.Size = new Size(276, 24);
			lblMainSubtext.TabIndex = 0;
			lblMainSubtext.Text = "Another Failed Attempt, Huh?";
			// 
			// lblMainTitle
			// 
			lblMainTitle.AutoSize = true;
			lblMainTitle.Font = new Font("Bahnschrift", 30F, FontStyle.Bold | FontStyle.Underline);
			lblMainTitle.Location = new Point(103, 117);
			lblMainTitle.Name = "lblMainTitle";
			lblMainTitle.Size = new Size(284, 48);
			lblMainTitle.TabIndex = 0;
			lblMainTitle.Text = "Recurring Fate";
			// 
			// tcWindow
			// 
			tcWindow.Appearance = TabAppearance.FlatButtons;
			tcWindow.Controls.Add(tpMain);
			tcWindow.Controls.Add(tpEntries);
			tcWindow.Controls.Add(tpCreate);
			tcWindow.Controls.Add(tpOptions);
			tcWindow.Dock = DockStyle.Fill;
			tcWindow.Location = new Point(0, 0);
			tcWindow.Multiline = true;
			tcWindow.Name = "tcWindow";
			tcWindow.SelectedIndex = 0;
			tcWindow.Size = new Size(504, 481);
			tcWindow.TabIndex = 0;
			tcWindow.SelectedIndexChanged += tcWindow_SelectedIndexChanged;
			tcWindow.KeyDown += KeyDownEvent;
			// 
			// tpCreate
			// 
			tpCreate.Controls.Add(dtpCreateTimeOfEntry);
			tpCreate.Controls.Add(tbCreateDescEntry);
			tpCreate.Controls.Add(btnCreateClear);
			tpCreate.Controls.Add(btnCreateUpdateEntry);
			tpCreate.Controls.Add(tbCreateTitleOfEntry);
			tpCreate.Location = new Point(4, 27);
			tpCreate.Name = "tpCreate";
			tpCreate.Padding = new Padding(3);
			tpCreate.Size = new Size(496, 450);
			tpCreate.TabIndex = 4;
			tpCreate.Text = "Create";
			tpCreate.UseVisualStyleBackColor = true;
			// 
			// dtpCreateTimeOfEntry
			// 
			dtpCreateTimeOfEntry.CalendarFont = new Font("Bahnschrift", 11F);
			dtpCreateTimeOfEntry.CustomFormat = "dd.mm.yyyy h/m";
			dtpCreateTimeOfEntry.Font = new Font("Bahnschrift", 11F);
			dtpCreateTimeOfEntry.Location = new Point(52, 87);
			dtpCreateTimeOfEntry.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
			dtpCreateTimeOfEntry.MinDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
			dtpCreateTimeOfEntry.Name = "dtpCreateTimeOfEntry";
			dtpCreateTimeOfEntry.Size = new Size(368, 25);
			dtpCreateTimeOfEntry.TabIndex = 2;
			// 
			// tbCreateDescEntry
			// 
			tbCreateDescEntry.Anchor = AnchorStyles.Left;
			tbCreateDescEntry.BackColor = SystemColors.Window;
			tbCreateDescEntry.Font = new Font("Bahnschrift", 10F);
			tbCreateDescEntry.Location = new Point(32, 121);
			tbCreateDescEntry.MaxLength = 500;
			tbCreateDescEntry.Multiline = true;
			tbCreateDescEntry.Name = "tbCreateDescEntry";
			tbCreateDescEntry.PlaceholderText = "Enter Description Here";
			tbCreateDescEntry.Size = new Size(407, 242);
			tbCreateDescEntry.TabIndex = 1;
			tbCreateDescEntry.Tag = "desc";
			tbCreateDescEntry.TextChanged += tbCreateTitleANdDescOfEntry_TextChanged;
			// 
			// btnCreateClear
			// 
			btnCreateClear.Anchor = AnchorStyles.Left;
			btnCreateClear.AutoSize = true;
			btnCreateClear.BackColor = SystemColors.AppWorkspace;
			btnCreateClear.Cursor = Cursors.Hand;
			btnCreateClear.Enabled = false;
			btnCreateClear.FlatStyle = FlatStyle.Popup;
			btnCreateClear.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnCreateClear.Location = new Point(317, 395);
			btnCreateClear.Name = "btnCreateClear";
			btnCreateClear.Size = new Size(122, 37);
			btnCreateClear.TabIndex = 4;
			btnCreateClear.Text = "Clear";
			btnCreateClear.UseVisualStyleBackColor = false;
			btnCreateClear.Click += btnCreateClear_Click;
			// 
			// btnCreateUpdateEntry
			// 
			btnCreateUpdateEntry.Anchor = AnchorStyles.Left;
			btnCreateUpdateEntry.AutoSize = true;
			btnCreateUpdateEntry.BackColor = SystemColors.AppWorkspace;
			btnCreateUpdateEntry.Cursor = Cursors.Hand;
			btnCreateUpdateEntry.Enabled = false;
			btnCreateUpdateEntry.FlatStyle = FlatStyle.Popup;
			btnCreateUpdateEntry.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnCreateUpdateEntry.Location = new Point(32, 395);
			btnCreateUpdateEntry.Name = "btnCreateUpdateEntry";
			btnCreateUpdateEntry.Size = new Size(122, 37);
			btnCreateUpdateEntry.TabIndex = 3;
			btnCreateUpdateEntry.Text = "Create Entry";
			btnCreateUpdateEntry.UseVisualStyleBackColor = false;
			btnCreateUpdateEntry.Click += btnCreateUpdateEntry_Click;
			// 
			// tbCreateTitleOfEntry
			// 
			tbCreateTitleOfEntry.Anchor = AnchorStyles.Left;
			tbCreateTitleOfEntry.BackColor = SystemColors.Window;
			tbCreateTitleOfEntry.Font = new Font("Bahnschrift", 11F);
			tbCreateTitleOfEntry.Location = new Point(52, 31);
			tbCreateTitleOfEntry.MaxLength = 30;
			tbCreateTitleOfEntry.Multiline = true;
			tbCreateTitleOfEntry.Name = "tbCreateTitleOfEntry";
			tbCreateTitleOfEntry.PlaceholderText = "Enter Title Here";
			tbCreateTitleOfEntry.Size = new Size(368, 50);
			tbCreateTitleOfEntry.TabIndex = 0;
			tbCreateTitleOfEntry.Tag = "title";
			tbCreateTitleOfEntry.TextChanged += tbCreateTitleANdDescOfEntry_TextChanged;
			// 
			// tpOptions
			// 
			tpOptions.Controls.Add(btnOptionsLoadEntries);
			tpOptions.Controls.Add(btnOptionsSaveEntries);
			tpOptions.Location = new Point(4, 27);
			tpOptions.Name = "tpOptions";
			tpOptions.Padding = new Padding(3);
			tpOptions.Size = new Size(496, 450);
			tpOptions.TabIndex = 5;
			tpOptions.Text = "Options";
			tpOptions.UseVisualStyleBackColor = true;
			// 
			// btnOptionsLoadEntries
			// 
			btnOptionsLoadEntries.Anchor = AnchorStyles.Left;
			btnOptionsLoadEntries.AutoSize = true;
			btnOptionsLoadEntries.BackColor = SystemColors.AppWorkspace;
			btnOptionsLoadEntries.Cursor = Cursors.Hand;
			btnOptionsLoadEntries.FlatStyle = FlatStyle.Popup;
			btnOptionsLoadEntries.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnOptionsLoadEntries.Location = new Point(264, 87);
			btnOptionsLoadEntries.Name = "btnOptionsLoadEntries";
			btnOptionsLoadEntries.Size = new Size(147, 37);
			btnOptionsLoadEntries.TabIndex = 4;
			btnOptionsLoadEntries.Text = "Load Entries...";
			btnOptionsLoadEntries.UseVisualStyleBackColor = false;
			btnOptionsLoadEntries.Click += btnOptionsLoadEntries_Click;
			// 
			// btnOptionsSaveEntries
			// 
			btnOptionsSaveEntries.Anchor = AnchorStyles.Left;
			btnOptionsSaveEntries.AutoSize = true;
			btnOptionsSaveEntries.BackColor = SystemColors.AppWorkspace;
			btnOptionsSaveEntries.Cursor = Cursors.Hand;
			btnOptionsSaveEntries.FlatStyle = FlatStyle.Popup;
			btnOptionsSaveEntries.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnOptionsSaveEntries.Location = new Point(52, 87);
			btnOptionsSaveEntries.Name = "btnOptionsSaveEntries";
			btnOptionsSaveEntries.Size = new Size(147, 37);
			btnOptionsSaveEntries.TabIndex = 4;
			btnOptionsSaveEntries.Text = "Save Entries...";
			btnOptionsSaveEntries.UseVisualStyleBackColor = false;
			btnOptionsSaveEntries.Click += btnOptionsSaveEntries_Click;
			// 
			// RecurringFate
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(504, 481);
			Controls.Add(tcWindow);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			MaximumSize = new Size(520, 520);
			MinimumSize = new Size(350, 520);
			Name = "RecurringFate";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Recurring Fate";
			FormClosing += RecurringFate_FormClosing;
			tpEntries.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvEntries).EndInit();
			tpMain.ResumeLayout(false);
			tpMain.PerformLayout();
			tcWindow.ResumeLayout(false);
			tpCreate.ResumeLayout(false);
			tpCreate.PerformLayout();
			tpOptions.ResumeLayout(false);
			tpOptions.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabPage tpEntries;
		private TabPage tpMain;
		private TabControl tcWindow;
		private TabPage tpCreate;
		private TabPage tpOptions;
		private Label lblMainSubtext;
		private Label lblMainTitle;
		private Label lblMainDesc;
		private DataGridView dgvEntries;
		private TextBox tbCreateTitleOfEntry;
		private Button btnCreateClear;
		private Button btnCreateUpdateEntry;
		private TextBox tbCreateDescEntry;
		private DataGridViewTextBoxColumn dgvtbclEntriesTitle;
		private DataGridViewTextBoxColumn dgvtbclEntriesStreakDayHour;
		private DataGridViewTextBoxColumn dgvtbclEntriesCreatedOn;
		private DataGridViewButtonColumn dgvbtnclEntriesShowEntry;
		private DataGridViewButtonColumn dgvbtnclEntriesDeleteEntry;
		private DateTimePicker dtpCreateTimeOfEntry;
		private Button btnOptionsSaveEntries;
		private Button btnOptionsLoadEntries;
	}
}
