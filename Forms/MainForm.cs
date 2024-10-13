using System;
using System.IO;
using System.Windows.Forms;
using WinPasser.Forms;
using WinPasser.Scripts;

namespace WinPasser
{
    public partial class MainForm : Form
    {
        private readonly string filePath;
        private readonly Database database = new Database();

        public MainForm()
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(DataBank.FilePath))
            {
                using (StartForm startForm = new StartForm())
                {
                    if (startForm.ShowDialog() == DialogResult.OK)
                            filePath = DataBank.FilePath;
                    else
                            DataBank.NeedToExit = true;
                }
            }
            if (File.Exists(filePath))
            {
                if (database.TryDecryptJson(filePath))
                {
                    database.LoadFromJson(filePath);
                    FreshUpdateDataGridRows();
                }
            }
        }


        private void ExitIfNeeded()
        {
            if (DataBank.NeedToExit)
            {
                Application.Exit();
            }
        }

        private void ClearGridSelection()
        {
            entriesGridView.ClearSelection();
        }


        private void AddEntry()
        {
            DataBank.ActiveEntry = new Entry();
            using (EditEntryForm editEntryForm = new EditEntryForm())
            {
                if (editEntryForm.ShowDialog() == DialogResult.OK)
                {
                    Entry newEntry = DataBank.ActiveEntry;
                    database.entries.Add(newEntry);
                    FreshUpdateDataGridRows();
                }
            }
        }


        private void SaveDatabase(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                return;

            database.SaveToJson(filePath);
        }

        private Entry GetSelectedEntry()
        {
            if (entriesGridView.SelectedRows.Count == 0)
                return null;
            
            return database.entries[entriesGridView.CurrentCell.RowIndex + 1];
        }

        private void CopyPassword()
        {
            Entry selectedEntry = GetSelectedEntry();
            if (selectedEntry != null)
            {
                Clipboard.SetText(selectedEntry.Password);
            }
        }

        private void EditEntry()
        {
            if (entriesGridView.Rows.Count <= 0)
                return;

            int EntryID = entriesGridView.CurrentCell.RowIndex + 1;
            DataBank.ActiveEntry = database.entries[EntryID];
            EditEntryForm editEntryForm = new EditEntryForm();
            if (editEntryForm.ShowDialog() == DialogResult.OK)
            {
                Entry changedEntry = DataBank.ActiveEntry;
                database.entries[EntryID] = changedEntry;
                FreshUpdateDataGridRows();
            }
        }

        private void FreshUpdateDataGridRows()
        {
            entriesGridView.Rows.Clear();
            foreach (Entry entry in database.entries)
            {
                if (!entry.Invisible)
                    entriesGridView.Rows.Add(entry.Title, entry.Login, "••••••••••••••••");
            }
        }

        #region Events
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveDatabase(filePath);
            }
            if (e.Control && e.KeyCode == Keys.C)
            {
                CopyPassword();
            }
        }

        internal void OnLoad(object sender, EventArgs e)
        {
            ExitIfNeeded();
            ClearGridSelection();
        }
        private void deleteEntryButton_Click(object sender, EventArgs e)
        {
            if (entriesGridView.Rows.Count <= 0) 
                return;

            database.entries.RemoveAt(entriesGridView.CurrentCell.RowIndex);
            FreshUpdateDataGridRows();
        }

        private void AddEntryButton_Click(object sender, EventArgs e) => AddEntry();

        private void saveEntryButton_Click(object sender, EventArgs e) => SaveDatabase(filePath);

        private void entriesGridView_DoubleClick(object sender, EventArgs e) => EditEntry();

        private void editEntryButton_Click(object sender, EventArgs e) => EditEntry();

        private void copyPasswordButton_Click(object sender, EventArgs e) => CopyPassword();
        #endregion
    }
}
//I hope I'll understand this shit tomorrow