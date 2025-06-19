namespace TaskManager
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvTasks = new DataGridView();
            contextMenuStrip = new ContextMenuStrip(components);
            copyToolStripMenuItem = new ToolStripMenuItem();
            tlpMain = new TableLayoutPanel();
            tlpButtons = new TableLayoutPanel();
            flpButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            tlpSearch = new TableLayoutPanel();
            flpSearch = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            contextMenuStrip.SuspendLayout();
            tlpMain.SuspendLayout();
            tlpButtons.SuspendLayout();
            flpButtons.SuspendLayout();
            tlpSearch.SuspendLayout();
            flpSearch.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(3, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(929, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(938, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvTasks
            // 
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.AllowUserToDeleteRows = false;
            dgvTasks.AllowUserToOrderColumns = true;
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.ContextMenuStrip = contextMenuStrip;
            dgvTasks.Dock = DockStyle.Fill;
            dgvTasks.Location = new Point(3, 46);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.ReadOnly = true;
            dgvTasks.Size = new Size(1309, 467);
            dgvTasks.TabIndex = 0;
            dgvTasks.CellDoubleClick += dgvTasks_CellDoubleClick;
            dgvTasks.MouseDown += dgvTasks_MouseDown;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { copyToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(103, 26);
            contextMenuStrip.Click += contextMenuStrip_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(102, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(dgvTasks, 0, 1);
            tlpMain.Controls.Add(tlpButtons, 0, 2);
            tlpMain.Controls.Add(tlpSearch, 0, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.830314F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 84.488884F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 7.680806F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.Size = new Size(1315, 561);
            tlpMain.TabIndex = 9;
            // 
            // tlpButtons
            // 
            tlpButtons.ColumnCount = 3;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle());
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpButtons.Controls.Add(flpButtons, 1, 0);
            tlpButtons.Dock = DockStyle.Fill;
            tlpButtons.Location = new Point(3, 519);
            tlpButtons.Name = "tlpButtons";
            tlpButtons.RowCount = 1;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpButtons.Size = new Size(1309, 39);
            tlpButtons.TabIndex = 13;
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnAdd);
            flpButtons.Controls.Add(btnEdit);
            flpButtons.Controls.Add(btnDelete);
            flpButtons.Controls.Add(btnRefresh);
            flpButtons.Dock = DockStyle.Fill;
            flpButtons.Location = new Point(490, 3);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(328, 33);
            flpButtons.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(84, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(165, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(246, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // tlpSearch
            // 
            tlpSearch.ColumnCount = 3;
            tlpSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSearch.ColumnStyles.Add(new ColumnStyle());
            tlpSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSearch.Controls.Add(flpSearch, 1, 0);
            tlpSearch.Dock = DockStyle.Fill;
            tlpSearch.Location = new Point(3, 3);
            tlpSearch.Name = "tlpSearch";
            tlpSearch.RowCount = 1;
            tlpSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSearch.Size = new Size(1309, 37);
            tlpSearch.TabIndex = 14;
            // 
            // flpSearch
            // 
            flpSearch.Controls.Add(txtSearch);
            flpSearch.Controls.Add(btnSearch);
            flpSearch.Dock = DockStyle.Fill;
            flpSearch.Location = new Point(145, 3);
            flpSearch.Name = "flpSearch";
            flpSearch.Size = new Size(1018, 31);
            flpSearch.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1315, 561);
            Controls.Add(tlpMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Task Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            contextMenuStrip.ResumeLayout(false);
            tlpMain.ResumeLayout(false);
            tlpButtons.ResumeLayout(false);
            flpButtons.ResumeLayout(false);
            tlpSearch.ResumeLayout(false);
            flpSearch.ResumeLayout(false);
            flpSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvTasks;
        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpButtons;
        private FlowLayoutPanel flpButtons;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private TableLayoutPanel tlpSearch;
        private FlowLayoutPanel flpSearch;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem copyToolStripMenuItem;
    }
}
