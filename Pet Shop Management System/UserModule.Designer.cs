namespace Pet_Shop_Management_System
{
    partial class UserModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserModule));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPass = new TextBox();
            lblPass = new Label();
            lbluid = new Label();
            cbRole = new ComboBox();
            dtDob = new DateTimePicker();
            btnSave = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 172, 220);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 15);
            panel1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(3, 172, 220);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(198, 27);
            label1.TabIndex = 1;
            label1.Text = "User Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 2;
            label2.Text = "Name :";
            // 
            // txtName
            // 
            txtName.Location = new Point(218, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(497, 28);
            txtName.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(218, 184);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(497, 28);
            txtPhone.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 191);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 4;
            label3.Text = "Phone :";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(218, 132);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(497, 28);
            txtAddress.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 139);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 6;
            label4.Text = "Address :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 243);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 8;
            label5.Text = "Role :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 295);
            label6.Name = "label6";
            label6.Size = new Size(124, 21);
            label6.TabIndex = 10;
            label6.Text = "Date of Birth :";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(218, 341);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(497, 28);
            txtPass.TabIndex = 5;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(12, 347);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(98, 21);
            lblPass.TabIndex = 12;
            lblPass.Text = "Password :";
            // 
            // lbluid
            // 
            lbluid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lbluid.AutoSize = true;
            lbluid.Location = new Point(12, 398);
            lbluid.Name = "lbluid";
            lbluid.Size = new Size(35, 21);
            lbluid.TabIndex = 14;
            lbluid.Text = "uid";
            lbluid.Visible = false;
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Administrator", "Cashier", "Employee" });
            cbRole.Location = new Point(218, 236);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(497, 29);
            cbRole.TabIndex = 3;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // dtDob
            // 
            dtDob.Location = new Point(218, 289);
            dtDob.Name = "dtDob";
            dtDob.Size = new Size(497, 28);
            dtDob.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(3, 172, 220);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(218, 390);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 52);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdate.Enabled = false;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(391, 390);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 52);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Silver;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(563, 390);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(152, 52);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
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
            btnClose.Location = new Point(714, 21);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(34, 29);
            btnClose.TabIndex = 9;
            btnClose.Click += btnClose_Click;
            // 
            // UserModule
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(748, 455);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dtDob);
            Controls.Add(cbRole);
            Controls.Add(lbluid);
            Controls.Add(txtPass);
            Controls.Add(lblPass);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserModule";
            Load += UserModule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label1;
        private Label lblPass;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        public TextBox txtPass;
        public TextBox txtAddress;
        public TextBox txtPhone;
        public TextBox txtName;
        public Button btnSave;
        public DateTimePicker dtDob;
        public ComboBox cbRole;
        public Label lbluid;
        public Button btnUpdate;
    }
}