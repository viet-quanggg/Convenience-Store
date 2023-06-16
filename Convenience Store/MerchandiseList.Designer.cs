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
            btnSearch.Location = new Point(972, 128);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 39);
            btnSearch.TabIndex = 41;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(501, 132);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Box";
            txtSearch.Size = new Size(445, 31);
            txtSearch.TabIndex = 40;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(675, 482);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(190, 56);
            btnAdd.TabIndex = 39;
            btnAdd.Text = "Add Into Order";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            btnFinish.FlatAppearance.BorderSize = 2;
            btnFinish.FlatStyle = FlatStyle.Flat;
            btnFinish.Location = new Point(887, 482);
            btnFinish.Margin = new Padding(4);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(190, 56);
            btnFinish.TabIndex = 38;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += btnFinish_Click;
            // 
            // btnRemove
            // 
            btnRemove.FlatAppearance.BorderSize = 2;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Location = new Point(122, 482);
            btnRemove.Margin = new Padding(4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(190, 56);
            btnRemove.TabIndex = 31;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(71, 124);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(316, 54);
            label1.TabIndex = 32;
            label1.Text = "Currently Added";
            // 
            // dgvCurrentlyAdd
            // 
            dgvCurrentlyAdd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurrentlyAdd.Location = new Point(54, 186);
            dgvCurrentlyAdd.Name = "dgvCurrentlyAdd";
            dgvCurrentlyAdd.RowHeadersWidth = 62;
            dgvCurrentlyAdd.RowTemplate.Height = 33;
            dgvCurrentlyAdd.Size = new Size(362, 276);
            dgvCurrentlyAdd.TabIndex = 37;
            // 
            // dgvMerchandise
            // 
            dgvMerchandise.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMerchandise.Location = new Point(501, 186);
            dgvMerchandise.Name = "dgvMerchandise";
            dgvMerchandise.RowHeadersWidth = 62;
            dgvMerchandise.RowTemplate.Height = 33;
            dgvMerchandise.Size = new Size(583, 276);
            dgvMerchandise.TabIndex = 36;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Location = new Point(0, 557);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(1134, 12);
            label7.TabIndex = 35;
            label7.Text = "label7";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnExit);
            panel2.Location = new Point(7, 573);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1140, 155);
            panel2.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(990, 11);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 32);
            label4.TabIndex = 1;
            label4.Text = "Login Page";
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 2;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(12, 6);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(118, 36);
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
            panel1.Location = new Point(0, -19);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1148, 144);
            panel1.TabIndex = 33;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(-11, 131);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(3054, 12);
            label6.TabIndex = 17;
            label6.Text = "label6";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(183, -4);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(763, 128);
            label3.TabIndex = 0;
            label3.Text = "Merchandise List";
            // 
            // MerchandiseList
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 709);
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