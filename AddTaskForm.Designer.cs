namespace TaskManager
{
    partial class AddTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTaskForm));
            tlpAdd = new TableLayoutPanel();
            lblTitle = new Label();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            lblDesc = new Label();
            lblDue = new Label();
            dtpDueDate = new DateTimePicker();
            chkCompleted = new CheckBox();
            btnSave = new Button();
            btnCancel = new Button();
            tlpAdd.SuspendLayout();
            SuspendLayout();
            // 
            // tlpAdd
            // 
            tlpAdd.ColumnCount = 3;
            tlpAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.9265652F));
            tlpAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.125F));
            tlpAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37F));
            tlpAdd.Controls.Add(lblTitle, 0, 0);
            tlpAdd.Controls.Add(txtTitle, 1, 0);
            tlpAdd.Controls.Add(txtDescription, 1, 1);
            tlpAdd.Controls.Add(lblDesc, 0, 1);
            tlpAdd.Controls.Add(lblDue, 0, 2);
            tlpAdd.Controls.Add(dtpDueDate, 1, 2);
            tlpAdd.Controls.Add(chkCompleted, 2, 2);
            tlpAdd.Controls.Add(btnSave, 0, 3);
            tlpAdd.Controls.Add(btnCancel, 2, 3);
            tlpAdd.Dock = DockStyle.Fill;
            tlpAdd.Location = new Point(0, 0);
            tlpAdd.Name = "tlpAdd";
            tlpAdd.RowCount = 4;
            tlpAdd.RowStyles.Add(new RowStyle(SizeType.Percent, 31.858408F));
            tlpAdd.RowStyles.Add(new RowStyle(SizeType.Percent, 22.4188786F));
            tlpAdd.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0737457F));
            tlpAdd.RowStyles.Add(new RowStyle(SizeType.Percent, 20.6489677F));
            tlpAdd.Size = new Size(800, 450);
            tlpAdd.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(30, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(146, 3);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(354, 23);
            txtTitle.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(146, 146);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(354, 23);
            txtDescription.TabIndex = 2;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(3, 143);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(67, 15);
            lblDesc.TabIndex = 3;
            lblDesc.Text = "Description";
            // 
            // lblDue
            // 
            lblDue.AutoSize = true;
            lblDue.Location = new Point(3, 243);
            lblDue.Name = "lblDue";
            lblDue.Size = new Size(55, 15);
            lblDue.TabIndex = 4;
            lblDue.Text = "Due Date";
            // 
            // dtpDueDate
            // 
            dtpDueDate.CustomFormat = "dd/MM/yyyy";
            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.Location = new Point(146, 246);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(276, 23);
            dtpDueDate.TabIndex = 5;
            // 
            // chkCompleted
            // 
            chkCompleted.AutoSize = true;
            chkCompleted.Location = new Point(506, 246);
            chkCompleted.Name = "chkCompleted";
            chkCompleted.Size = new Size(85, 19);
            chkCompleted.TabIndex = 6;
            chkCompleted.Text = "Completed";
            chkCompleted.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(3, 358);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(506, 358);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(tlpAdd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddTaskForm";
            Text = "Add Task";
            tlpAdd.ResumeLayout(false);
            tlpAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpAdd;
        private Label lblTitle;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private Label lblDesc;
        private Label lblDue;
        private DateTimePicker dtpDueDate;
        private CheckBox chkCompleted;
        private Button btnSave;
        private Button btnCancel;
    }
}