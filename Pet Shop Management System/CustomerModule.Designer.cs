namespace Pet_Shop_Management_System
{
    partial class CustomerModule
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerModule));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            lblcid = new Label();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label4 = new Label();
            panel1 = new Panel();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.Silver;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(563, 247);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(152, 52);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(255, 128, 0);
            btnUpdate.Enabled = false;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(391, 247);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 52);
            btnUpdate.TabIndex = 27;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(3, 172, 220);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(218, 247);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(152, 52);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblcid
            // 
            lblcid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblcid.AutoSize = true;
            lblcid.Location = new Point(12, 255);
            lblcid.Name = "lblcid";
            lblcid.Size = new Size(36, 21);
            lblcid.TabIndex = 33;
            lblcid.Text = "uid";
            lblcid.Visible = false;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(218, 138);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(497, 30);
            txtAddress.TabIndex = 18;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(218, 190);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(497, 30);
            txtPhone.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 197);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 23;
            label3.Text = "Phone :";
            // 
            // txtName
            // 
            txtName.Location = new Point(218, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(497, 30);
            txtName.TabIndex = 16;
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
            label1.Size = new Size(260, 27);
            label1.TabIndex = 17;
            label1.Text = "Customer Registration";
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
            label4.Size = new Size(90, 21);
            label4.TabIndex = 26;
            label4.Text = "Address :";
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
            // btnClose
            // 
            btnClose.CustomizableEdges = customizableEdges3;
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
            btnClose.Location = new Point(714, 18);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnClose.Size = new Size(34, 29);
            btnClose.TabIndex = 34;
            btnClose.Click += btnClose_Click;
            // 
            // CustomerModule
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(748, 306);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(lblcid);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerModel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancel;
        public Button btnUpdate;
        public Button btnSave;
        public Label lblcid;
        public TextBox txtAddress;
        public TextBox txtPhone;
        private Label label3;
        public TextBox txtName;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label4;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}