namespace Pet_Shop_Management_System
{
    partial class CashProduct
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashProduct));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnCash = new Guna.UI2.WinForms.Guna2Button();
            txtSearch_ = new Guna.UI2.WinForms.Guna2TextBox();
            panel2 = new Panel();
            dgvProduct = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Select = new DataGridViewCheckBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 172, 220);
            panel1.Controls.Add(btnCash);
            panel1.Controls.Add(txtSearch_);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 356);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 94);
            panel1.TabIndex = 4;
            // 
            // btnCash
            // 
            btnCash.AutoRoundedCorners = true;
            btnCash.BorderRadius = 22;
            btnCash.CustomizableEdges = customizableEdges5;
            btnCash.DisabledState.BorderColor = Color.DarkGray;
            btnCash.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCash.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCash.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCash.FillColor = Color.White;
            btnCash.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCash.ForeColor = Color.FromArgb(3, 172, 220);
            btnCash.Location = new Point(599, 24);
            btnCash.Name = "btnCash";
            btnCash.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCash.Size = new Size(174, 47);
            btnCash.TabIndex = 13;
            btnCash.Text = "Submit";
            btnCash.Click += btnCash_Click;
            // 
            // txtSearch_
            // 
            txtSearch_.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch_.BackColor = Color.Transparent;
            txtSearch_.BorderRadius = 20;
            txtSearch_.CustomizableEdges = customizableEdges7;
            txtSearch_.DefaultText = "";
            txtSearch_.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch_.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch_.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch_.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch_.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch_.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch_.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch_.IconLeft = (Image)resources.GetObject("txtSearch_.IconLeft");
            txtSearch_.Location = new Point(179, 24);
            txtSearch_.Margin = new Padding(3, 5, 3, 5);
            txtSearch_.Name = "txtSearch_";
            txtSearch_.PasswordChar = '\0';
            txtSearch_.PlaceholderText = "Search Here";
            txtSearch_.SelectedText = "";
            txtSearch_.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSearch_.Size = new Size(385, 45);
            txtSearch_.TabIndex = 8;
            txtSearch_.TextChanged += txtSearch__TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(3, 172, 220);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 37);
            panel2.TabIndex = 5;
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.BackgroundColor = SystemColors.Control;
            dgvProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(3, 172, 220);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProduct.ColumnHeadersHeight = 30;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column7, Select });
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.Location = new Point(0, 37);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(800, 319);
            dgvProduct.TabIndex = 6;
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
            Column2.HeaderText = "Pcode";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 96;
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
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Type";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 80;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Category";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 123;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column7.DefaultCellStyle = dataGridViewCellStyle4;
            Column7.HeaderText = "Price";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 80;
            // 
            // Select
            // 
            Select.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Select.HeaderText = "Select";
            Select.MinimumWidth = 6;
            Select.Name = "Select";
            Select.Resizable = DataGridViewTriState.True;
            Select.Width = 69;
            // 
            // CashProduct
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProduct);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "CashProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashProduct";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvProduct;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch_;
        private Guna.UI2.WinForms.Guna2Button btnCash;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewCheckBoxColumn Select;
    }
}