namespace Pet_Shop_Management_System
{
    partial class ProductModule
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModule));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            cbCategory = new ComboBox();
            lblPcode = new Label();
            label6 = new Label();
            label5 = new Label();
            txtType = new TextBox();
            txtQty = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label4 = new Label();
            panel1 = new Panel();
            txtPrice = new TextBox();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.CustomizableEdges = customizableEdges1;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.Transparent;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = Color.White;
            btnClose.HoverState.BorderColor = Color.Transparent;
            btnClose.HoverState.FillColor = Color.Transparent;
            btnClose.HoverState.Image = (Image)resources.GetObject("resource.Image");
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(714, 27);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(34, 29);
            btnClose.TabIndex = 8;
            btnClose.Click += btnClose_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Silver;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(563, 362);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(152, 52);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdate.Enabled = false;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(391, 362);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 52);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(3, 172, 220);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(218, 362);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 52);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Dog", "Cat", "Birth", "Fish", "Food" });
            cbCategory.Location = new Point(218, 189);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(497, 29);
            cbCategory.TabIndex = 2;
            // 
            // lblPcode
            // 
            lblPcode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPcode.AutoSize = true;
            lblPcode.Location = new Point(12, 370);
            lblPcode.Name = "lblPcode";
            lblPcode.Size = new Size(70, 21);
            lblPcode.TabIndex = 33;
            lblPcode.Text = "pcode";
            lblPcode.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 301);
            label6.Name = "label6";
            label6.Size = new Size(63, 21);
            label6.TabIndex = 31;
            label6.Text = "Price :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 249);
            label5.Name = "label5";
            label5.Size = new Size(54, 21);
            label5.TabIndex = 29;
            label5.Text = "Qty :";
            // 
            // txtType
            // 
            txtType.Location = new Point(218, 138);
            txtType.Name = "txtType";
            txtType.Size = new Size(497, 30);
            txtType.TabIndex = 1;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(218, 240);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(497, 30);
            txtQty.TabIndex = 3;
            txtQty.KeyPress += txtQty_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 197);
            label3.Name = "label3";
            label3.Size = new Size(106, 21);
            label3.TabIndex = 23;
            label3.Text = "Category :";
            // 
            // txtName
            // 
            txtName.Location = new Point(218, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(497, 30);
            txtName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 20;
            label2.Text = "Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(3, 172, 220);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(240, 27);
            label1.TabIndex = 17;
            label1.Text = "Product Registration";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 145);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 26;
            label4.Text = "Type :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 172, 220);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 15);
            panel1.TabIndex = 15;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(218, 292);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(497, 30);
            txtPrice.TabIndex = 4;
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // ProductModule
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(748, 421);
            Controls.Add(txtPrice);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(cbCategory);
            Controls.Add(lblPcode);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtType);
            Controls.Add(txtQty);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductModule";
            Load += ProductModule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Button btnCancel;
        public Button btnUpdate;
        public Button btnSave;
        public ComboBox cbCategory;
        public Label lblPcode;
        private Label label6;
        private Label label5;
        public TextBox txtType;
        public TextBox txtQty;
        private Label label3;
        public TextBox txtName;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label4;
        private Panel panel1;
        public TextBox txtPrice;
    }
}