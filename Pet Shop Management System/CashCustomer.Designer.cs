namespace Pet_Shop_Management_System
{
    partial class CashCustomer
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashCustomer));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtSearch_ = new Guna.UI2.WinForms.Guna2TextBox();
            dgvCustomer = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Choice = new DataGridViewImageColumn();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 172, 220);
            panel1.Controls.Add(txtSearch_);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 356);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 94);
            panel1.TabIndex = 7;
            // 
            // txtSearch_
            // 
            txtSearch_.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch_.BackColor = Color.Transparent;
            txtSearch_.BorderRadius = 20;
            txtSearch_.CustomizableEdges = customizableEdges1;
            txtSearch_.DefaultText = "";
            txtSearch_.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch_.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch_.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch_.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch_.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch_.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch_.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch_.IconLeft = (Image)resources.GetObject("txtSearch_.IconLeft");
            txtSearch_.Location = new Point(171, 24);
            txtSearch_.Margin = new Padding(3, 5, 3, 5);
            txtSearch_.Name = "txtSearch_";
            txtSearch_.PasswordChar = '\0';
            txtSearch_.PlaceholderText = "Search Here";
            txtSearch_.SelectedText = "";
            txtSearch_.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch_.Size = new Size(385, 45);
            txtSearch_.TabIndex = 8;
            txtSearch_.TextChanged += txtSearch__TextChanged;
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
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Choice });
            dgvCustomer.Dock = DockStyle.Fill;
            dgvCustomer.EnableHeadersVisualStyles = false;
            dgvCustomer.Location = new Point(0, 37);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersVisible = false;
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(800, 413);
            dgvCustomer.TabIndex = 9;
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
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
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Name";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Phone";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 94;
            // 
            // Choice
            // 
            Choice.HeaderText = "Choice";
            Choice.MinimumWidth = 6;
            Choice.Name = "Choice";
            Choice.Width = 125;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(3, 172, 220);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 37);
            panel2.TabIndex = 8;
            // 
            // CashCustomer
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dgvCustomer);
            Controls.Add(panel2);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CashCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashCustomer";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch_;
        private DataGridView dgvCustomer;
        private Panel panel2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Choice;
    }
}