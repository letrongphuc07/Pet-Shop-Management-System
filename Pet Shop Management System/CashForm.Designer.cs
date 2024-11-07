namespace Pet_Shop_Management_System
{
    partial class CashForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvCash = new DataGridView();
            panel2 = new Panel();
            btnCash = new Guna.UI2.WinForms.Guna2Button();
            lblTotal = new Label();
            lblTransno = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            panel1 = new Panel();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Increase = new DataGridViewImageColumn();
            Decrease = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCash).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCash
            // 
            dgvCash.AllowUserToAddRows = false;
            dgvCash.BackgroundColor = SystemColors.Control;
            dgvCash.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(3, 172, 220);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCash.ColumnHeadersHeight = 30;
            dgvCash.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCash.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column6, Column3, Column4, Column5, Column7, Column8, Column9, Increase, Decrease, Delete });
            dgvCash.Dock = DockStyle.Fill;
            dgvCash.EnableHeadersVisualStyles = false;
            dgvCash.Location = new Point(0, 75);
            dgvCash.Name = "dgvCash";
            dgvCash.RowHeadersVisible = false;
            dgvCash.RowHeadersWidth = 51;
            dgvCash.Size = new Size(1000, 225);
            dgvCash.TabIndex = 5;
            dgvCash.CellContentClick += dgvCash_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCash);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(lblTransno);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 55);
            panel2.TabIndex = 4;
            // 
            // btnCash
            // 
            btnCash.AutoRoundedCorners = true;
            btnCash.BorderRadius = 24;
            btnCash.CustomizableEdges = customizableEdges1;
            btnCash.DisabledState.BorderColor = Color.DarkGray;
            btnCash.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCash.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCash.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCash.FillColor = Color.FromArgb(3, 172, 220);
            btnCash.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCash.ForeColor = Color.White;
            btnCash.Location = new Point(820, 3);
            btnCash.Name = "btnCash";
            btnCash.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCash.Size = new Size(174, 50);
            btnCash.TabIndex = 12;
            btnCash.Text = "Cash";
            btnCash.Click += btnCash_Click;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(665, 14);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(115, 25);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTransno
            // 
            lblTransno.Location = new Point(329, 16);
            lblTransno.Name = "lblTransno";
            lblTransno.Size = new Size(115, 25);
            lblTransno.TabIndex = 10;
            lblTransno.Text = "0000000000";
            lblTransno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(3, 172, 220);
            label3.Location = new Point(555, 16);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 9;
            label3.Text = "Total Price $";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(3, 172, 220);
            label2.Location = new Point(189, 16);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 8;
            label2.Text = "Transaction no:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(3, 172, 220);
            label1.Location = new Point(41, 16);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 7;
            label1.Text = "Product";
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
            Column2.HeaderText = "CashId";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Visible = false;
            Column2.Width = 99;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column6.DefaultCellStyle = dataGridViewCellStyle2;
            Column6.HeaderText = "Pcode";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 96;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Name";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Qty";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column5.DefaultCellStyle = dataGridViewCellStyle3;
            Column5.HeaderText = "Price";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 80;
            // 
            // Column7
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column7.DefaultCellStyle = dataGridViewCellStyle4;
            Column7.HeaderText = "Total";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Customer Name";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 182;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.HeaderText = "Cashier";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 102;
            // 
            // Increase
            // 
            Increase.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Increase.HeaderText = "";
            Increase.MinimumWidth = 6;
            Increase.Name = "Increase";
            Increase.Resizable = DataGridViewTriState.True;
            Increase.Width = 6;
            // 
            // Decrease
            // 
            Decrease.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Decrease.HeaderText = "";
            Decrease.MinimumWidth = 6;
            Decrease.Name = "Decrease";
            Decrease.Resizable = DataGridViewTriState.True;
            Decrease.Width = 6;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.Width = 6;
            // 
            // CashForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1000, 300);
            Controls.Add(dgvCash);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "CashForm";
            Text = "CASH";
            ((System.ComponentModel.ISupportInitialize)dgvCash).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCash;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnCash;
        private Label lblTotal;
        public Label lblTransno;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewImageColumn Increase;
        private DataGridViewImageColumn Decrease;
        private DataGridViewImageColumn Delete;
    }
}