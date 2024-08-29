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
            if (DataBank.FilePath == null)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                filePath = DataBank.FilePath;
            }
            if (File.Exists(filePath))
            {
                database.LoadFromJson(filePath);
                FreshUpdateDataGridRows();
            }
        }

        internal void ClearGridSelection(object sender, EventArgs e)
        {
            entriesGridView.ClearSelection();
        }

        private void AddEntryButton_Click(object sender, EventArgs e)
        {
            AddEntry();
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


        private void deleteEntryButton_Click(object sender, EventArgs e)
        {
            if (entriesGridView.Rows.Count == 0) 
                return;

            database.entries.RemoveAt(entriesGridView.CurrentCell.RowIndex);
            FreshUpdateDataGridRows();
        }

        private void SaveDatabase(string filePath)
        {
            database.SaveToJson(filePath);
        }

        private void saveEntryButton_Click(object sender, EventArgs e) => SaveDatabase(filePath);

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveDatabase(filePath);
            }
        }

        private void EditEntry()
        {
            int EntryID = entriesGridView.CurrentCell.RowIndex;
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
                entriesGridView.Rows.Add(entry.Title, entry.Login, entry.Password);
            }
        }
        private void entriesGridView_DoubleClick(object sender, EventArgs e) => EditEntry();

        private void editEntryButton_Click(object sender, EventArgs e) => EditEntry();
    }
}
//I hope I'll understand this shit tomorrow