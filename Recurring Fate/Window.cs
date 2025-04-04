using Recurring_Fate.Properties;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Recurring_Fate
{
	public partial class RecurringFate : Form
	{
		/// <summary>
		/// Contains all enties of the current file the user loaded and or created
		/// </summary>
		BindingList<Entry> _entries;

		/// <summary>
		/// true, if the contents have changed. false, if the contents weren't changed or the file has been saved
		/// </summary>
		bool _fileContentsChanged;

		CreateState _createState;
		DateTime _earliestDate;

		/// <summary>
		/// Index of the current entry the user selected
		/// </summary>
		int _currentEntryIndex;
		string? _fileName;

		/// <summary>
		///  Is responsible for calling the save file dialog when user uses s + ctrl
		/// </summary>
		bool _isSavedFile;

		//Update the maxDate to the Date of the next entry if the entry isnt in the last spot
		//When creating an entry you should be able to pick the time too

		public RecurringFate()
		{
			InitializeComponent();
			_entries = new BindingList<Entry>();
			_createState = CreateState.Create;
			_earliestDate = new DateTime(2010, 1, 1);
			dgvEntries.DataSource = _entries;
		}

		void tbCreateTitleANdDescOfEntry_TextChanged(object sender, EventArgs e)
		{
			btnCreateClear.Enabled = !String.IsNullOrWhiteSpace(tbCreateDescEntry.Text) || !String.IsNullOrWhiteSpace(tbCreateTitleOfEntry.Text);
			btnCreateUpdateEntry.Enabled = !String.IsNullOrWhiteSpace(tbCreateDescEntry.Text) && !String.IsNullOrWhiteSpace(tbCreateTitleOfEntry.Text);
		}

		void btnCreateUpdateEntry_Click(object sender, EventArgs e)
		{
			if (_createState == CreateState.Create)
			{
				Entry newEntry = new Entry(tbCreateTitleOfEntry.Text, tbCreateDescEntry.Text, dtpCreateTimeOfEntry.Value);
				if (_entries.Count > 0)
				{
					newEntry.SetSteak(_entries.Last().CreatedOn);
				}
				_entries.Add(newEntry);
			}
			else
			{
				Entry entryToUpdate = _entries[_currentEntryIndex];
				entryToUpdate.Title = tbCreateTitleOfEntry.Text;
				entryToUpdate.Description = tbCreateDescEntry.Text;
				entryToUpdate.CreatedOn = dtpCreateTimeOfEntry.Value;
				if (_currentEntryIndex > 0)
				{
					entryToUpdate.SetSteak(_entries[_currentEntryIndex - 1].CreatedOn);
				}
			}
			tcWindow.SelectedIndex = 1;
			FileHasChanged();
			btnCreateClear_Click(sender, e);
		}

		void FileHasChanged()
		{
			this.Text = !String.IsNullOrEmpty(_fileName) ? string.Concat("Recurring Fate - ", _fileName, "*") : "Recurring Fate*";
			_fileContentsChanged = true;
		}

		void FileHasBeenSaved()
		{
			this.Text = string.Concat("Recurring Fate - ", _fileName);
			_fileContentsChanged = false;
			_isSavedFile = true;
		}

		void btnCreateClear_Click(object sender, EventArgs e)
		{
			dtpCreateTimeOfEntry.Value = DateTime.Now;
			dtpCreateTimeOfEntry.MinDate = _entries.Last().CreatedOn;

			tbCreateDescEntry.Text = string.Empty;
			tbCreateTitleOfEntry.Text = string.Empty;

			btnCreateUpdateEntry.Text = "Create Entry";
			btnCreateClear.Text = "Clear";
			_createState = CreateState.Create;
			_currentEntryIndex = 0;
		}

		void dgvEntries_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 0)
			{   //show entry button was clicked
				tcWindow.SelectedIndex = 2;
				tbCreateTitleOfEntry.Text = _entries[e.RowIndex].Title;
				tbCreateDescEntry.Text = _entries[e.RowIndex].Description;
				_currentEntryIndex = e.RowIndex;

				dgvEntries.Rows[e.RowIndex].Cells["dgvbtnclEntriesShowEntry"].Selected = false;
				_createState = CreateState.Update;

				btnCreateUpdateEntry.Text = "Update Entry";
				btnCreateClear.Text = "Cancel";
			}
			else if (e.ColumnIndex == 1)
			{   //delete entry button was clicked
				List<int> selectedCell = new List<int>();
				selectedCell.Add(GetSelectedCell().RowIndex);
				DeleteEntries(selectedCell);
			}
		}

		void tcWindow_SelectedIndexChanged(object sender, EventArgs e)
		{   //Are we on the create page?
			if (tpCreate.Name.Equals(tcWindow.TabPages[tcWindow.SelectedIndex].Name))
			{
				//int newWidth = tbCreateDescEntry.Right + 25 + 3;
				//this.Size = new Size(newWidth, 520);
				//DataGridViewCell cell = GetSelectedCell();
				//if (cell != null)
				//{	//event doesnt have cell data so we call it with that info
				//	dgvEntries_CellContentClick(sender, new DataGridViewCellEventArgs(cell.ColumnIndex, cell.RowIndex));
				//}

				//minimum date is the creation date of the previous entry
				dtpCreateTimeOfEntry.MinDate = _currentEntryIndex > 0 ? _entries[_currentEntryIndex - 1].CreatedOn : _earliestDate;
				if (_createState == CreateState.Update)
				{
					dtpCreateTimeOfEntry.Value = _entries[_currentEntryIndex].CreatedOn;
				}
			}
			else
			{
				this.Size = new Size(520, 520);
			}
		}

		void dgvEntries_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//rearrange the list by what the user clicked on
		}

		void KeyDownEvent(object sender, KeyEventArgs e)
		{
			switch (e.KeyData)
			{
				case Keys.S | Keys.Control:
					if (_isSavedFile)
					{
						SaveEntryData(Settings.Default.RecentSaveLocation, string.Concat(_fileName, ".json"));
					}
					else
					{
						OpenSaveFileDialog();
					}
				break;

				case Keys.O | Keys.Control:
					OpenEntryData();
				break;

				case Keys.Delete:
					if (sender.GetType() == dgvEntries.GetType())
					{
						List<int> indexes = new List<int>();
						foreach (DataGridViewRow selectedRow in dgvEntries.SelectedRows)
						{
							indexes.Add(selectedRow.Index);
						}
						DeleteEntries(indexes);
					}
				break;
			}
		}

		void OpenEntryData()
		{
			using (OpenFileDialog oFD = new OpenFileDialog())
			{
				oFD.Filter = "json files (*.json)|*.json";
				oFD.InitialDirectory = Settings.Default.RecentSaveLocation;
				if (oFD.ShowDialog() == DialogResult.OK)
				{
					_fileName = Path.GetFileNameWithoutExtension(oFD.FileName);
					Settings.Default.RecentSaveLocation = Path.GetDirectoryName(oFD.FileName);
					Settings.Default.Save();
					FileHasBeenSaved();

					string jsonData = File.ReadAllText(oFD.FileName);
					List<Entry> loadedEntries = new List<Entry>(JsonConvert.DeserializeObject<List<Entry>>(jsonData)!);
					_entries.Clear();
					foreach (Entry loadedEntry in loadedEntries)
					{
						_entries.Add(loadedEntry);
					}
				}
			}
		}

		void OpenSaveFileDialog()
		{
			using (SaveFileDialog sFD = new SaveFileDialog())
			{
				sFD.Filter = "json files (*.json)|*.json";
				sFD.FileName = _fileName ?? RetrieveDefaultFileName();

				if (sFD.ShowDialog() == DialogResult.OK)
				{
					_fileName = Path.GetFileNameWithoutExtension(sFD.FileName);
					SaveEntryData(Path.GetDirectoryName(sFD.FileName)!, Path.GetFileName(sFD.FileName));
				}
			}
		}

		void SaveEntryData(string myPath, string fileName)
		{
			this.Text = string.Concat("Recurring Fate - ", _fileName);

			Settings.Default.RecentSaveLocation = myPath;
			Settings.Default.Save();
			using (StreamWriter sW = File.CreateText(string.Concat(myPath, "\\", fileName)))
			{
				sW.Write(JsonConvert.SerializeObject(_entries, Formatting.Indented));
			}
		}

		String RetrieveDefaultFileName()
		{
			string res = "Entries1";
			int num = 1;
			while (File.Exists(string.Concat(Settings.Default.RecentSaveLocation, "\\", res, ".json")))
			{
				num++;
				res = "Entries" + num;
			}
			return res + ".json";
		}

		void DeleteEntries(List<int> selectedRowIndexes)
		{
			foreach (int row in selectedRowIndexes)
			{
				dgvEntries.Rows[row].Selected = true;
			}

			string title = string.Concat("Delete Entr", selectedRowIndexes.Count > 1 ? "ies" : "y");
			string text = string.Concat("Are You Sure You Want To Delete ", selectedRowIndexes.Count, " Entr", selectedRowIndexes.Count > 1 ? "ies?" : "y?");
			DialogResult rs = MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

			if (rs == DialogResult.Yes)
			{
				foreach (int index in selectedRowIndexes)
				{
					dgvEntries.Rows.RemoveAt(index);
				}

				if (_entries.Count > 0)
				{
					_entries.First().ResetStreak();
					_earliestDate = _entries.Last().CreatedOn;
				}
				else
				{
					_earliestDate = new DateTime(2010, 1, 1);
				}
				FileHasChanged();
			}
			else
			{
				dgvEntries.ClearSelection();
			}
		}

		DataGridViewCell GetSelectedCell()
		{
			foreach (DataGridViewRow row in dgvEntries.Rows)
			{
				foreach (DataGridViewButtonCell cell in row.Cells.OfType<DataGridViewButtonCell>())
				{
					if (cell.Selected)
					{
						cell.Selected = false;
						return cell;
					}
				}
			}
			return new DataGridViewButtonCell();
		}

		void btnOptionsSaveEntries_Click(object sender, EventArgs e)
		{
			OpenSaveFileDialog();
		}

		void btnOptionsLoadEntries_Click(object sender, EventArgs e)
		{
			OpenEntryData();
		}

		void RecurringFate_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_fileContentsChanged)
			{
				DialogResult res = MessageBox.Show("Youu still have unsaved changes! Do you really want to leave without saving?",
					"Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
				if (res == DialogResult.No)
				{
					e.Cancel = true;
				}
			}
		}

		enum CreateState
		{
			Create,
			Update
		}
	}
}