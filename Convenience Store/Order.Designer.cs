namespace Convenience_Store
{
    partial class Order
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
            dgvOrder = new DataGridView();
            lblTotal = new Label();
            pnlHeader = new Panel();
            lblOrderTitle = new Label();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            pnlFooter = new Panel();
            lblOrderFooter = new Label();
            btnExit = new Button();
            txtTotal = new TextBox();
            lblDollarSign = new Label();
            btnExport = new Button();
            btnFinish = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnMerchandise = new Button();
            pnlCurrentEm = new Panel();
            lblMerId = new Label();
            txtMerId = new TextBox();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            lblRole = new Label();
            txtRole = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            lblName = new Label();
            lblId = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            pnlCurrentEm.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.AllowUserToDeleteRows = false;
            dgvOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(675, 67);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 62;
            dgvOrder.RowTemplate.Height = 33;
            dgvOrder.Size = new Size(683, 517);
            dgvOrder.TabIndex = 13;
            dgvOrder.CellClick += dgvOrder_CellClick;
            dgvOrder.CellValueChanged += dgvOrder_CellValueChanged;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(571, 595);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(81, 38);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total:";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(128, 128, 255);
            pnlHeader.Controls.Add(lblOrderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.ForeColor = SystemColors.MenuText;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1374, 60);
            pnlHeader.TabIndex = 20;
            // 
            // lblOrderTitle
            // 
            lblOrderTitle.AutoSize = true;
            lblOrderTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblOrderTitle.Location = new Point(621, 9);
            lblOrderTitle.Margin = new Padding(4, 0, 4, 0);
            lblOrderTitle.Name = "lblOrderTitle";
            lblOrderTitle.Size = new Size(92, 38);
            lblOrderTitle.TabIndex = 0;
            lblOrderTitle.Text = "Order";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(376, 141);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(104, 30);
            lblQuantity.TabIndex = 15;
            lblQuantity.Text = "Quantity :";
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.MenuBar;
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Location = new Point(376, 192);
            txtQuantity.Margin = new Padding(4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(218, 35);
            txtQuantity.TabIndex = 16;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(128, 128, 255);
            pnlFooter.Controls.Add(lblOrderFooter);
            pnlFooter.Controls.Add(btnExit);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 650);
            pnlFooter.Margin = new Padding(4);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1374, 60);
            pnlFooter.TabIndex = 24;
            // 
            // lblOrderFooter
            // 
            lblOrderFooter.AutoSize = true;
            lblOrderFooter.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblOrderFooter.Location = new Point(1306, 30);
            lblOrderFooter.Margin = new Padding(4, 0, 4, 0);
            lblOrderFooter.Name = "lblOrderFooter";
            lblOrderFooter.Size = new Size(68, 30);
            lblOrderFooter.TabIndex = 1;
            lblOrderFooter.Text = "Order";
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 2;
            btnExit.Location = new Point(13, 12);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(141, 44);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtTotal.BackColor = SystemColors.Menu;
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(658, 592);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(246, 50);
            txtTotal.TabIndex = 25;
            // 
            // lblDollarSign
            // 
            lblDollarSign.AutoSize = true;
            lblDollarSign.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDollarSign.Location = new Point(910, 595);
            lblDollarSign.Name = "lblDollarSign";
            lblDollarSign.Size = new Size(32, 38);
            lblDollarSign.TabIndex = 26;
            lblDollarSign.Text = "$";
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnExport.FlatAppearance.BorderSize = 2;
            btnExport.Location = new Point(998, 592);
            btnExport.Margin = new Padding(4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(176, 50);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export Bill";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            btnFinish.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnFinish.FlatAppearance.BorderSize = 2;
            btnFinish.Location = new Point(1182, 592);
            btnFinish.Margin = new Padding(4);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(176, 50);
            btnFinish.TabIndex = 27;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.FlatAppearance.BorderSize = 2;
            btnEdit.Location = new Point(13, 592);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(176, 50);
            btnEdit.TabIndex = 28;
            btnEdit.Text = "Save";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.Location = new Point(197, 592);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 50);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMerchandise
            // 
            btnMerchandise.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnMerchandise.FlatAppearance.BorderSize = 2;
            btnMerchandise.Location = new Point(381, 592);
            btnMerchandise.Margin = new Padding(4);
            btnMerchandise.Name = "btnMerchandise";
            btnMerchandise.Size = new Size(176, 50);
            btnMerchandise.TabIndex = 30;
            btnMerchandise.Text = "Merchandise";
            btnMerchandise.UseVisualStyleBackColor = true;
            btnMerchandise.Click += btnMerchandise_Click;
            // 
            // pnlCurrentEm
            // 
            pnlCurrentEm.Controls.Add(lblQuantity);
            pnlCurrentEm.Controls.Add(txtQuantity);
            pnlCurrentEm.Controls.Add(lblMerId);
            pnlCurrentEm.Controls.Add(txtMerId);
            pnlCurrentEm.Controls.Add(txtAddress);
            pnlCurrentEm.Controls.Add(lblAddress);
            pnlCurrentEm.Controls.Add(txtPhone);
            pnlCurrentEm.Controls.Add(lblPhone);
            pnlCurrentEm.Controls.Add(lblRole);
            pnlCurrentEm.Controls.Add(txtRole);
            pnlCurrentEm.Controls.Add(txtName);
            pnlCurrentEm.Controls.Add(txtId);
            pnlCurrentEm.Controls.Add(lblName);
            pnlCurrentEm.Controls.Add(lblId);
            pnlCurrentEm.Location = new Point(13, 67);
            pnlCurrentEm.Margin = new Padding(4);
            pnlCurrentEm.Name = "pnlCurrentEm";
            pnlCurrentEm.Size = new Size(639, 517);
            pnlCurrentEm.TabIndex = 31;
            // 
            // lblMerId
            // 
            lblMerId.AutoSize = true;
            lblMerId.Location = new Point(376, 18);
            lblMerId.Margin = new Padding(4, 0, 4, 0);
            lblMerId.Name = "lblMerId";
            lblMerId.Size = new Size(167, 30);
            lblMerId.TabIndex = 13;
            lblMerId.Text = "Merchandise Id :";
            // 
            // txtMerId
            // 
            txtMerId.BackColor = SystemColors.MenuBar;
            txtMerId.BorderStyle = BorderStyle.FixedSingle;
            txtMerId.Enabled = false;
            txtMerId.Location = new Point(376, 69);
            txtMerId.Margin = new Padding(4);
            txtMerId.Name = "txtMerId";
            txtMerId.ReadOnly = true;
            txtMerId.Size = new Size(218, 35);
            txtMerId.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(146, 249);
            txtAddress.Margin = new Padding(4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(448, 84);
            txtAddress.TabIndex = 12;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(16, 248);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(98, 30);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "Address :";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(148, 194);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(186, 35);
            txtPhone.TabIndex = 10;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(20, 202);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(83, 30);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Phone :";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(16, 141);
            lblRole.Margin = new Padding(4, 0, 4, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(64, 30);
            lblRole.TabIndex = 8;
            lblRole.Text = "Role :";
            // 
            // txtRole
            // 
            txtRole.Enabled = false;
            txtRole.Location = new Point(146, 136);
            txtRole.Margin = new Padding(4);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(186, 35);
            txtRole.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(146, 75);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(186, 35);
            txtName.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.MenuBar;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Enabled = false;
            txtId.Location = new Point(148, 15);
            txtId.Margin = new Padding(4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(186, 35);
            txtId.TabIndex = 7;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(16, 80);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(80, 30);
            lblName.TabIndex = 6;
            lblName.Text = "Name :";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 26);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(42, 30);
            lblId.TabIndex = 4;
            lblId.Text = "Id :";
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 710);
            Controls.Add(pnlCurrentEm);
            Controls.Add(btnMerchandise);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnFinish);
            Controls.Add(btnExport);
            Controls.Add(lblDollarSign);
            Controls.Add(txtTotal);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            Controls.Add(lblTotal);
            Controls.Add(dgvOrder);
            Name = "Order";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            pnlCurrentEm.ResumeLayout(false);
            pnlCurrentEm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvOrder;
        private Label lblTotal;
        private Panel pnlHeader;
        private Label lblOrderTitle;
        private Panel pnlFooter;
        private Label lblOrderFooter;
        private Button btnExit;
        private TextBox txtTotal;
        private Label lblDollarSign;
        private Button btnExport;
        private Button btnFinish;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnMerchandise;
        private Panel pnlCurrentEm;
        private Label lblRole;
        private TextBox txtRole;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblName;
        private Label lblId;
        private TextBox txtPhone;
        private Label lblPhone;
        private TextBox txtAddress;
        private Label lblAddress;
        private Label lblMerId;
        private TextBox txtMerId;
        private Label lblQuantity;
        private TextBox txtQuantity;
    }
}