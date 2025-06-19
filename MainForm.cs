using System.Data;
using System.Data.SQLite;
using System.Reflection;


namespace TaskManager
{
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            InitializeComponent();
            txtSearch.KeyDown += txtSearch_KeyDown;
            LoadTasks();

            //Allows to copy from the data loaded and showed into the table
            dgvTasks.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvTasks.MultiSelect = true; //Allow selecting multiple cells
            dgvTasks.SelectionMode = DataGridViewSelectionMode.CellSelect;
            
        }

        //Class to manage the conection to the DB embedded so it generate a single independent .exe file
        public static class DbManager
        {
            public static string ConnectionString { get; private set; }

            public static void Initialize()
            {
                string tempDbPath = Path.Combine(Path.GetTempPath(), "tasks.db");

                if (!File.Exists(tempDbPath))
                {
                    using Stream resource = Assembly
                        .GetExecutingAssembly()
                        .GetManifestResourceStream("TaskManager.db.tasks.db");

                    using FileStream file = new FileStream(tempDbPath, FileMode.Create, FileAccess.Write);
                    resource.CopyTo(file);
                }

                ConnectionString = $"Data Source={tempDbPath};Version=3;";
            }
        }

        private void LoadTasks(string searchTerm = "") //Load data from database
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(DbManager.ConnectionString))
            {
                conn.Open();
                string query = "SELECT id, title, description, completed, created_at, due_date FROM tasks";

                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    query += " WHERE title LIKE @search";
                }
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    if (!string.IsNullOrWhiteSpace(searchTerm))
                        cmd.Parameters.AddWithValue("@search", $"%{searchTerm}%");

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            dgvTasks.DataSource = dt;
            if (dgvTasks.Columns["id"] != null)
                dgvTasks.Columns["id"].Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e) //Button to add new entry - connects to AddTaskForm
        {
            AddTaskForm addForm = new AddTaskForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadTasks(); // refresh task list
            }
        }

        private void btnEdit_Click(object sender, EventArgs e) //Button to edit entry
        {
            if (dgvTasks.CurrentRow != null)
            {
                DataRowView rowView = dgvTasks.CurrentRow.DataBoundItem as DataRowView;
                if (rowView != null)
                {
                    DataRow row = rowView.Row;
                    using (AddTaskForm editForm = new AddTaskForm(row))
                    {
                        if (editForm.ShowDialog() == DialogResult.OK)
                        {
                            LoadTasks(); // Refresh after editing
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a task to edit.");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            LoadTasks(searchTerm);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadTasks(); // Reload all tasks
        }
        private void btnDelete_Click(object sender, EventArgs e) //Button to delete entry
        {
            if (dgvTasks.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a task to delete (any cell in the row).");
                return;
            }

            // Get the row of the first selected cell
            DataGridViewCell selectedCell = dgvTasks.SelectedCells[0];
            DataGridViewRow row = dgvTasks.Rows[selectedCell.RowIndex];

            // Get ID from the hidden "id" column
            if (row.Cells["id"].Value == null)
            {
                MessageBox.Show("Could not retrieve task ID.");
                return;
            }

            int taskId = Convert.ToInt32(row.Cells["id"].Value);

            var confirm = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            using (SQLiteConnection conn = new SQLiteConnection(DbManager.ConnectionString))
            {
                conn.Open();
                string query = "DELETE FROM tasks WHERE id = @id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", taskId);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadTasks(); // Refresh task list
            MessageBox.Show("Task deleted successfully.");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e) // This allows the user to use enter key to search, not only clicking the search button
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dgvTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Allows double click to edit a row
        {
            if (e.RowIndex >= 0) // Ensure it's not header row
            {
                DataRowView rowView = (DataRowView)dgvTasks.Rows[e.RowIndex].DataBoundItem;
                DataRow row = rowView.Row;

                AddTaskForm editForm = new AddTaskForm(row);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadTasks(); // Refresh after edit
                }
            }
        }

       

        

        private void contextMenuStrip_Click(object sender, EventArgs e) //Right click generic for copy - implement where is needed
        {
            if (dgvTasks.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                DataObject dataObj = dgvTasks.GetClipboardContent();
                if (dataObj != null)
                {
                    Clipboard.SetDataObject(dataObj);
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) // Right click to copy from the table
        {
            if (dgvTasks.GetCellCount(DataGridViewElementStates.Selected) > 0)
            {
                DataObject dataObj = dgvTasks.GetClipboardContent();
                if (dataObj != null)
                {
                    Clipboard.SetDataObject(dataObj);
                }
            }
        }

        private void dgvTasks_MouseDown(object sender, MouseEventArgs e) // Right click on the table cell selects it so you can copy that one instead of another one selected
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dgvTasks.HitTest(e.X, e.Y);
                if (hit.Type == DataGridViewHitTestType.Cell)
                {
                    // Only select the cell if it's NOT already selected
                    DataGridViewCell clickedCell = dgvTasks[hit.ColumnIndex, hit.RowIndex];
                    if (!clickedCell.Selected)
                    {
                        dgvTasks.ClearSelection();
                        clickedCell.Selected = true;
                        dgvTasks.CurrentCell = clickedCell;
                    }
                }
            }
        }
    }
}
