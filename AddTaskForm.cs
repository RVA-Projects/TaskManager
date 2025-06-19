using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static TaskManager.MainForm;

namespace TaskManager
{
    public partial class AddTaskForm : Form
    {
        private int? taskId = null; //This allows the to load data from the DB even if it has not an ID yet, otherwise it may crash

        public AddTaskForm()
        {
            InitializeComponent();
            this.Text = "Add Task";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            
            using (SQLiteConnection conn = new SQLiteConnection(DbManager.ConnectionString))
            {
                conn.Open();

                if (taskId == null)
                {
                    // INSERT
                    string query = "INSERT INTO tasks (title, description, completed, created_at, due_date) VALUES (@title, @description, @completed, @created_at, @due_date)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@completed", chkCompleted.Checked);
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                        cmd.Parameters.AddWithValue("@due_date", dtpDueDate.Value);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Task added successfully!");
                }
                else
                {
                    // UPDATE
                    string query = "UPDATE tasks SET title=@title, description=@description, completed=@completed, due_date=@due_date WHERE id=@id";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@title", txtTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@completed", chkCompleted.Checked);
                        cmd.Parameters.AddWithValue("@due_date", dtpDueDate.Value);
                        cmd.Parameters.AddWithValue("@id", taskId);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Task updated successfully!");
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        //Constructor for Edit tasks button - uses the same form as Add button
        public AddTaskForm(DataRow row) 
        {
            InitializeComponent();
            this.Text = "Edit Task";

            // Safely assign ID
            if (row["id"] != DBNull.Value)
                taskId = Convert.ToInt32(row["id"]);

            // Safely assign Title
            txtTitle.Text = row["title"] != DBNull.Value ? row["title"].ToString() : string.Empty;

            // Safely assign Description
            txtDescription.Text = row["description"] != DBNull.Value ? row["description"].ToString() : string.Empty;

            // Safely assign Completed checkbox
            chkCompleted.Checked = row["completed"] != DBNull.Value && Convert.ToBoolean(row["completed"]);

            // Safely assign Due Date
            dtpDueDate.Value = row["due_date"] != DBNull.Value
                ? Convert.ToDateTime(row["due_date"])
                : DateTime.Today;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return false;
            }
            return true;
        }

    }

}
