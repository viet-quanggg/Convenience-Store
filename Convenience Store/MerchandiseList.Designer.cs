namespace Convenience_Store
{
    partial class MerchandiseList
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
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnFinish = new Button();
            btnRemove = new Button();
            label1 = new Label();
            dgvCurrentlyAdd = new DataGridView();
            dgvMerchandise = new DataGridView();
            label7 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            btnExit = new Button();
            panel1 = new Panel();
            label6 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentlyAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMerchandise).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 2;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(778, 102);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 31);
            btnSearch.TabIndex = 41;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(401, 106);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Box";
            txtSearch.Size = new Size(357, 27);
            txtSearch.TabIndex = 40;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(540, 386);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(152, 45);
            btnAdd.TabIndex = 39;
            btnAdd.Text = "Add Into Order";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnFinish
            // 
            btnFinish.FlatAppearance.BorderSize = 2;
            btnFinish.FlatStyle = FlatStyle.Flat;
            btnFinish.Location = new Point(710, 386);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(152, 45);
            btnFinish.TabIndex = 38;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += btnFinish_Click;
            // 
            // btnRemove
            // 
            btnRemove.FlatAppearance.BorderSize = 2;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Location = new Point(98, 386);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(152, 45);
            btnRemove.TabIndex = 31;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(57, 99);
            label1.Name = "label1";
            label1.Size = new Size(266, 46);
            label1.TabIndex = 32;
            label1.Text = "Currently Added";
            // 
            // dgvCurrentlyAdd
            // 
            dgvCurrentlyAdd.AllowUserToAddRows = false;
            dgvCurrentlyAdd.AllowUserToDeleteRows = false;
            dgvCurrentlyAdd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurrentlyAdd.Location = new Point(43, 149);
            dgvCurrentlyAdd.Margin = new Padding(2);
            dgvCurrentlyAdd.Name = "dgvCurrentlyAdd";
            dgvCurrentlyAdd.ReadOnly = true;
            dgvCurrentlyAdd.RowHeadersWidth = 62;
            dgvCurrentlyAdd.RowTemplate.Height = 33;
            dgvCurrentlyAdd.Size = new Size(290, 221);
            dgvCurrentlyAdd.TabIndex = 37;
            dgvCurrentlyAdd.CellClick += dgvCurrentlyAdd_CellClick;
            // 
            // dgvMerchandise
            // 
            dgvMerchandise.AllowUserToAddRows = false;
            dgvMerchandise.AllowUserToDeleteRows = false;
            dgvMerchandise.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMerchandise.Location = new Point(401, 149);
            dgvMerchandise.Margin = new Padding(2);
            dgvMerchandise.Name = "dgvMerchandise";
            dgvMerchandise.ReadOnly = true;
            dgvMerchandise.RowHeadersWidth = 62;
            dgvMerchandise.RowTemplate.Height = 33;
            dgvMerchandise.Size = new Size(466, 221);
            dgvMerchandise.TabIndex = 36;
            dgvMerchandise.CellClick += dgvMerchandise_CellClick;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Location = new Point(0, 446);
            label7.Name = "label7";
            label7.Size = new Size(908, 10);
            label7.TabIndex = 35;
            label7.Text = "label7";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnExit);
            panel2.Location = new Point(6, 458);
            panel2.Name = "panel2";
            panel2.Size = new Size(912, 124);
            panel2.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(792, 9);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 1;
            label4.Text = "Login Page";
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 2;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(10, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.ForeColor = SystemColors.MenuText;
            panel1.Location = new Point(0, -15);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 115);
            panel1.TabIndex = 33;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(-9, 105);
            label6.Name = "label6";
            label6.Size = new Size(2444, 10);
            label6.TabIndex = 17;
            label6.Text = "label6";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(146, -3);
            label3.Name = "label3";
            label3.Size = new Size(637, 106);
            label3.TabIndex = 0;
            label3.Text = "Merchandise List";
            // 
            // MerchandiseList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 567);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnAdd);
            Controls.Add(btnFinish);
            Controls.Add(btnRemove);
            Controls.Add(label1);
            Controls.Add(dgvCurrentlyAdd);
            Controls.Add(dgvMerchandise);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "MerchandiseList";
            Text = "MerchandiseList";
            ((System.ComponentModel.ISupportInitialize)dgvCurrentlyAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMerchandise).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnAdd;
        private Button btnFinish;
        private Button btnRemove;
        private Label label1;
        private DataGridView dgvCurrentlyAdd;
        private DataGridView dgvMerchandise;
        private Label label7;
        private Panel panel2;
        private Label label4;
        private Button btnExit;
        private Panel panel1;
        private Label label6;
        private Label label3;
    }
}