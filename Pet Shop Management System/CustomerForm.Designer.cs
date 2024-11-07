namespace Pet_Shop_Management_System
{
    partial class CustomerForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvCustomer = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel2 = new Panel();
            txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCustomer
            // 
            dgvCustomer.AllowUserToAddRows = false;
            dgvCustomer.BackgroundColor = SystemColors.Control;
            dgvCustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(3, 172, 220);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomer.ColumnHeadersHeight = 30;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Edit, Delete });
            dgvCustomer.Dock = DockStyle.Fill;
            dgvCustomer.EnableHeadersVisualStyles = false;
            dgvCustomer.Location = new Point(0, 75);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(1000, 225);
            dgvCustomer.TabIndex = 5;
            dgvCustomer.CellContentClick += dgvUser_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 62;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "ID";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 55;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Name";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 91;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Address";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Phone";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 94;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Role";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 75;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Day of Birth";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 137;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Password";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 117;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = (Image)resources.GetObject("Edit.Image");
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Width = 6;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Width = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_Search);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 55);
            panel2.TabIndex = 4;
            // 
            // txt_Search
            // 
            txt_Search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txt_Search.BackColor = Color.Transparent;
            txt_Search.BorderRadius = 20;
            txt_Search.CustomizableEdges = customizableEdges1;
            txt_Search.DefaultText = "";
            txt_Search.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_Search.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_Search.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_Search.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_Search.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Search.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Search.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_Search.IconLeft = (Image)resources.GetObject("txt_Search.IconLeft");
            txt_Search.Location = new Point(654, 5);
            txt_Search.Margin = new Padding(3, 5, 3, 5);
            txt_Search.Name = "txt_Search";
            txt_Search.PasswordChar = '\0';
            txt_Search.PlaceholderText = "Search Here";
            txt_Search.SelectedText = "";
            txt_Search.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txt_Search.Size = new Size(334, 45);
            txt_Search.TabIndex = 6;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.CustomizableEdges = customizableEdges3;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.Transparent;
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.ForeColor = Color.White;
            btnAdd.HoverState.BorderColor = Color.Transparent;
            btnAdd.HoverState.FillColor = Color.Transparent;
            btnAdd.HoverState.Image = (Image)resources.GetObject("resource.Image");
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.Location = new Point(12, 11);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAdd.Size = new Size(34, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.BackColor = Color.Transparent;
            txtSearch.BorderRadius = 20;
            txtSearch.CustomizableEdges = customizableEdges5;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = (Image)resources.GetObject("txtSearch.IconLeft");
            txtSearch.Location = new Point(1461, 5);
            txtSearch.Margin = new Padding(3, 5, 3, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search Here";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSearch.Size = new Size(334, 45);
            txtSearch.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 172, 220);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 20);
            panel1.TabIndex = 3;
            // 
            // CustomerForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1000, 300);
            Controls.Add(dgvCustomer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerForm";
            Text = "CUSTOMER";
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCustomer;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
    }
}