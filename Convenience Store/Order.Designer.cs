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
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblHeaderLine = new Label();
            lblOrderTitle = new Label();
            pnlFooter = new Panel();
            lblOrderFooter = new Label();
            btnExit = new Button();
            lblFooterLine = new Label();
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
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(450, 103);
            dgvOrder.Margin = new Padding(2);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 62;
            dgvOrder.RowTemplate.Height = 33;
            dgvOrder.Size = new Size(445, 244);
            dgvOrder.TabIndex = 13;
            dgvOrder.CellClick += dgvOrder_CellClick;
            dgvOrder.CellValueChanged += dgvOrder_CellValueChanged;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(403, 382);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 28);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total:";
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblHeaderLine);
            pnlHeader.Controls.Add(lblOrderTitle);
            pnlHeader.ForeColor = SystemColors.MenuText;
            pnlHeader.Location = new Point(-14, -6);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(956, 103);
            pnlHeader.TabIndex = 20;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(251, 94);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(72, 20);
            lblQuantity.TabIndex = 15;
            lblQuantity.Text = "Quantity :";
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = SystemColors.MenuBar;
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Location = new Point(251, 128);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(146, 27);
            txtQuantity.TabIndex = 16;
            // 
            // lblHeaderLine
            // 
            lblHeaderLine.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblHeaderLine.BackColor = SystemColors.ActiveCaptionText;
            lblHeaderLine.BorderStyle = BorderStyle.FixedSingle;
            lblHeaderLine.Location = new Point(17, 80);
            lblHeaderLine.Name = "lblHeaderLine";
            lblHeaderLine.Size = new Size(2456, 10);
            lblHeaderLine.TabIndex = 17;
            lblHeaderLine.Text = "label6";
            lblHeaderLine.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblOrderTitle
            // 
            lblOrderTitle.AutoSize = true;
            lblOrderTitle.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderTitle.Location = new Point(379, 3);
            lblOrderTitle.Name = "lblOrderTitle";
            lblOrderTitle.Size = new Size(185, 78);
            lblOrderTitle.TabIndex = 0;
            lblOrderTitle.Text = "Order";
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(lblOrderFooter);
            pnlFooter.Controls.Add(btnExit);
            pnlFooter.Location = new Point(3, 415);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(912, 124);
            pnlFooter.TabIndex = 24;
            // 
            // lblOrderFooter
            // 
            lblOrderFooter.AutoSize = true;
            lblOrderFooter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOrderFooter.Location = new Point(834, 21);
            lblOrderFooter.Name = "lblOrderFooter";
            lblOrderFooter.Size = new Size(63, 28);
            lblOrderFooter.TabIndex = 1;
            lblOrderFooter.Text = "Order";
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 2;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(10, 22);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lblFooterLine
            // 
            lblFooterLine.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFooterLine.BackColor = SystemColors.ActiveCaptionText;
            lblFooterLine.BorderStyle = BorderStyle.FixedSingle;
            lblFooterLine.Location = new Point(-726, 421);
            lblFooterLine.Name = "lblFooterLine";
            lblFooterLine.Size = new Size(2441, 10);
            lblFooterLine.TabIndex = 18;
            lblFooterLine.Text = "label3";
            lblFooterLine.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.Menu;
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(465, 360);
            txtTotal.Margin = new Padding(2);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(164, 50);
            txtTotal.TabIndex = 25;
            // 
            // lblDollarSign
            // 
            lblDollarSign.AutoSize = true;
            lblDollarSign.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDollarSign.Location = new Point(627, 379);
            lblDollarSign.Margin = new Padding(2, 0, 2, 0);
            lblDollarSign.Name = "lblDollarSign";
            lblDollarSign.Size = new Size(23, 28);
            lblDollarSign.TabIndex = 26;
            lblDollarSign.Text = "$";
            // 
            // btnExport
            // 
            btnExport.FlatAppearance.BorderSize = 2;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Location = new Point(655, 370);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(117, 33);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export Bill";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            btnFinish.FlatAppearance.BorderSize = 2;
            btnFinish.FlatStyle = FlatStyle.Flat;
            btnFinish.Location = new Point(788, 370);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(117, 33);
            btnFinish.TabIndex = 27;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.FlatAppearance.BorderSize = 2;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(13, 371);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(117, 33);
            btnEdit.TabIndex = 28;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(149, 371);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 33);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMerchandise
            // 
            btnMerchandise.FlatAppearance.BorderSize = 2;
            btnMerchandise.FlatStyle = FlatStyle.Flat;
            btnMerchandise.Location = new Point(281, 371);
            btnMerchandise.Name = "btnMerchandise";
            btnMerchandise.Size = new Size(117, 33);
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
            pnlCurrentEm.Location = new Point(13, 103);
            pnlCurrentEm.Name = "pnlCurrentEm";
            pnlCurrentEm.Size = new Size(421, 244);
            pnlCurrentEm.TabIndex = 31;
            // 
            // lblMerId
            // 
            lblMerId.AutoSize = true;
            lblMerId.Location = new Point(251, 12);
            lblMerId.Name = "lblMerId";
            lblMerId.Size = new Size(117, 20);
            lblMerId.TabIndex = 13;
            lblMerId.Text = "Merchandise Id :";
            // 
            // txtMerId
            // 
            txtMerId.BackColor = SystemColors.MenuBar;
            txtMerId.BorderStyle = BorderStyle.FixedSingle;
            txtMerId.Enabled = false;
            txtMerId.Location = new Point(251, 46);
            txtMerId.Name = "txtMerId";
            txtMerId.ReadOnly = true;
            txtMerId.Size = new Size(146, 27);
            txtMerId.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(97, 166);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(285, 57);
            txtAddress.TabIndex = 12;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(11, 165);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(69, 20);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "Address :";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(99, 129);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 10;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(13, 135);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(57, 20);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Phone :";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(11, 94);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(46, 20);
            lblRole.TabIndex = 8;
            lblRole.Text = "Role :";
            // 
            // txtRole
            // 
            txtRole.Enabled = false;
            txtRole.Location = new Point(97, 91);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(125, 27);
            txtRole.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(97, 50);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.MenuBar;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Enabled = false;
            txtId.Location = new Point(99, 10);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 7;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(11, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 6;
            lblName.Text = "Name :";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(13, 17);
            lblId.Name = "lblId";
            lblId.Size = new Size(29, 20);
            lblId.TabIndex = 4;
            lblId.Text = "Id :";
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 473);
            Controls.Add(pnlCurrentEm);
            Controls.Add(btnMerchandise);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnFinish);
            Controls.Add(btnExport);
            Controls.Add(lblDollarSign);
            Controls.Add(txtTotal);
            Controls.Add(lblFooterLine);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            Controls.Add(lblTotal);
            Controls.Add(dgvOrder);
            Margin = new Padding(2);
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
        private Label lblHeaderLine;
        private Label lblOrderTitle;
        private Panel pnlFooter;
        private Label lblOrderFooter;
        private Button btnExit;
        private Label lblFooterLine;
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