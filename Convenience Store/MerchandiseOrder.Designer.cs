namespace Convenience_Store
{
    partial class MerchandiseOrder
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            dgvKho = new DataGridView();
            Exit = new Button();
            Add = new Button();
            Edit = new Button();
            Delete = new Button();
            menuStrip1 = new MenuStrip();
            panel1 = new Panel();
            btnChemicals = new Button();
            btnCanned = new Button();
            btnCigarette = new Button();
            btnFrozen = new Button();
            btnOffice = new Button();
            btnTissue = new Button();
            btnSpices = new Button();
            btnMilk = new Button();
            btnMedicine = new Button();
            btnPersonal = new Button();
            btnInstant = new Button();
            btnBeverage = new Button();
            btnAlcoho = new Button();
            btnSnack = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearchKho = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            txtName = new TextBox();
            cbCategory = new ComboBox();
            label3 = new Label();
            txtUnit = new TextBox();
            txtDes = new TextBox();
            txtQuantity = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKho).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 9);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(271, 31);
            label1.TabIndex = 0;
            label1.Text = "Information Merchandise";
            // 
            // dgvKho
            // 
            dgvKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKho.DefaultCellStyle = dataGridViewCellStyle2;
            dgvKho.Location = new Point(628, 150);
            dgvKho.Name = "dgvKho";
            dgvKho.RowHeadersWidth = 51;
            dgvKho.RowTemplate.Height = 29;
            dgvKho.Size = new Size(862, 530);
            dgvKho.TabIndex = 1;
            dgvKho.CellDoubleClick += dgvKho_CellDoubleClick_1;
            // 
            // Exit
            // 
            Exit.Location = new Point(283, 11);
            Exit.Name = "Exit";
            Exit.Size = new Size(107, 29);
            Exit.TabIndex = 2;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            Add.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Add.Location = new Point(9, 92);
            Add.Name = "Add";
            Add.Size = new Size(128, 52);
            Add.TabIndex = 3;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click_1;
            // 
            // Edit
            // 
            Edit.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Edit.Location = new Point(142, 92);
            Edit.Name = "Edit";
            Edit.Size = new Size(124, 52);
            Edit.TabIndex = 4;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // Delete
            // 
            Delete.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Delete.Location = new Point(272, 92);
            Delete.Name = "Delete";
            Delete.Size = new Size(121, 52);
            Delete.TabIndex = 5;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1494, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnChemicals);
            panel1.Controls.Add(btnCanned);
            panel1.Controls.Add(btnCigarette);
            panel1.Controls.Add(btnFrozen);
            panel1.Controls.Add(btnOffice);
            panel1.Controls.Add(btnTissue);
            panel1.Controls.Add(btnSpices);
            panel1.Controls.Add(btnMilk);
            panel1.Controls.Add(btnMedicine);
            panel1.Controls.Add(btnPersonal);
            panel1.Controls.Add(btnInstant);
            panel1.Controls.Add(btnBeverage);
            panel1.Controls.Add(btnAlcoho);
            panel1.Controls.Add(btnSnack);
            panel1.Location = new Point(425, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 611);
            panel1.TabIndex = 8;
            // 
            // btnChemicals
            // 
            btnChemicals.Location = new Point(103, 525);
            btnChemicals.Name = "btnChemicals";
            btnChemicals.Size = new Size(94, 66);
            btnChemicals.TabIndex = 13;
            btnChemicals.Text = "Chemicals - Cosmetics";
            btnChemicals.UseVisualStyleBackColor = true;
            btnChemicals.Click += btnChemicals_Click;
            // 
            // btnCanned
            // 
            btnCanned.Location = new Point(3, 525);
            btnCanned.Name = "btnCanned";
            btnCanned.Size = new Size(94, 66);
            btnCanned.TabIndex = 12;
            btnCanned.Text = "Canned Food";
            btnCanned.UseVisualStyleBackColor = true;
            btnCanned.Click += btnCanned_Click;
            // 
            // btnCigarette
            // 
            btnCigarette.Location = new Point(3, 356);
            btnCigarette.Name = "btnCigarette";
            btnCigarette.Size = new Size(94, 66);
            btnCigarette.TabIndex = 11;
            btnCigarette.Text = "Cigarette";
            btnCigarette.UseVisualStyleBackColor = true;
            btnCigarette.Click += btnCigarette_Click;
            // 
            // btnFrozen
            // 
            btnFrozen.Location = new Point(103, 438);
            btnFrozen.Name = "btnFrozen";
            btnFrozen.Size = new Size(94, 66);
            btnFrozen.TabIndex = 10;
            btnFrozen.Text = "Frozen Products";
            btnFrozen.UseVisualStyleBackColor = true;
            btnFrozen.Click += btnFrozen_Click;
            // 
            // btnOffice
            // 
            btnOffice.Location = new Point(103, 356);
            btnOffice.Name = "btnOffice";
            btnOffice.Size = new Size(94, 66);
            btnOffice.TabIndex = 9;
            btnOffice.Text = "Office Supplies";
            btnOffice.UseVisualStyleBackColor = true;
            btnOffice.Click += btnOffice_Click;
            // 
            // btnTissue
            // 
            btnTissue.Location = new Point(3, 438);
            btnTissue.Name = "btnTissue";
            btnTissue.Size = new Size(94, 66);
            btnTissue.TabIndex = 8;
            btnTissue.Text = "Tissue";
            btnTissue.UseVisualStyleBackColor = true;
            btnTissue.Click += btnTissue_Click;
            // 
            // btnSpices
            // 
            btnSpices.Location = new Point(103, 267);
            btnSpices.Name = "btnSpices";
            btnSpices.Size = new Size(94, 66);
            btnSpices.TabIndex = 7;
            btnSpices.Text = "Spices";
            btnSpices.UseVisualStyleBackColor = true;
            btnSpices.Click += btnSpices_Click;
            // 
            // btnMilk
            // 
            btnMilk.Location = new Point(3, 267);
            btnMilk.Name = "btnMilk";
            btnMilk.Size = new Size(94, 66);
            btnMilk.TabIndex = 6;
            btnMilk.Text = "Milk";
            btnMilk.UseVisualStyleBackColor = true;
            btnMilk.Click += btnMilk_Click;
            // 
            // btnMedicine
            // 
            btnMedicine.Location = new Point(103, 183);
            btnMedicine.Name = "btnMedicine";
            btnMedicine.Size = new Size(94, 66);
            btnMedicine.TabIndex = 5;
            btnMedicine.Text = "Medicine";
            btnMedicine.UseVisualStyleBackColor = true;
            btnMedicine.Click += btnMedicine_Click;
            // 
            // btnPersonal
            // 
            btnPersonal.Location = new Point(3, 183);
            btnPersonal.Name = "btnPersonal";
            btnPersonal.Size = new Size(94, 66);
            btnPersonal.TabIndex = 4;
            btnPersonal.Text = "Personal Belongings";
            btnPersonal.UseVisualStyleBackColor = true;
            btnPersonal.Click += btnPersonal_Click;
            // 
            // btnInstant
            // 
            btnInstant.Location = new Point(103, 94);
            btnInstant.Name = "btnInstant";
            btnInstant.Size = new Size(94, 66);
            btnInstant.TabIndex = 3;
            btnInstant.Text = "Instant Food";
            btnInstant.UseVisualStyleBackColor = true;
            btnInstant.Click += btnInstant_Click;
            // 
            // btnBeverage
            // 
            btnBeverage.Location = new Point(3, 94);
            btnBeverage.Name = "btnBeverage";
            btnBeverage.Size = new Size(94, 66);
            btnBeverage.TabIndex = 2;
            btnBeverage.Text = "Beverage";
            btnBeverage.UseVisualStyleBackColor = true;
            btnBeverage.Click += btnBeverage_Click;
            // 
            // btnAlcoho
            // 
            btnAlcoho.Location = new Point(103, 14);
            btnAlcoho.Name = "btnAlcoho";
            btnAlcoho.Size = new Size(94, 66);
            btnAlcoho.TabIndex = 1;
            btnAlcoho.Text = "Acoholic Drink";
            btnAlcoho.UseVisualStyleBackColor = true;
            btnAlcoho.Click += btnAlcoho_Click;
            // 
            // btnSnack
            // 
            btnSnack.Location = new Point(3, 14);
            btnSnack.Name = "btnSnack";
            btnSnack.Size = new Size(94, 66);
            btnSnack.TabIndex = 0;
            btnSnack.Text = "Snack, Candy";
            btnSnack.UseVisualStyleBackColor = true;
            btnSnack.Click += btnSnack_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.Location = new Point(628, 92);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(121, 52);
            btnRefresh.TabIndex = 23;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(9, 43);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 43);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchKho
            // 
            txtSearchKho.Location = new Point(105, 52);
            txtSearchKho.Name = "txtSearchKho";
            txtSearchKho.Size = new Size(288, 27);
            txtSearchKho.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(cbCategory);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtUnit);
            panel2.Controls.Add(txtDes);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(12, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(381, 445);
            panel2.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(81, 31);
            label2.TabIndex = 9;
            label2.Text = "Name ";
            // 
            // txtName
            // 
            txtName.Location = new Point(153, 14);
            txtName.Name = "txtName";
            txtName.Size = new Size(209, 27);
            txtName.TabIndex = 15;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(153, 242);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(209, 28);
            cbCategory.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 56);
            label3.Name = "label3";
            label3.Size = new Size(137, 31);
            label3.TabIndex = 10;
            label3.Text = "Description ";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(153, 191);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(209, 27);
            txtUnit.TabIndex = 19;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(153, 56);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(209, 27);
            txtDes.TabIndex = 16;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(153, 146);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(209, 27);
            txtQuantity.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 98);
            label4.Name = "label4";
            label4.Size = new Size(70, 31);
            label4.TabIndex = 11;
            label4.Text = "Price ";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(153, 98);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(209, 27);
            txtPrice.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 140);
            label5.Name = "label5";
            label5.Size = new Size(108, 31);
            label5.TabIndex = 12;
            label5.Text = "Quantity ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 242);
            label7.Name = "label7";
            label7.Size = new Size(112, 31);
            label7.TabIndex = 14;
            label7.Text = "Category ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 191);
            label6.Name = "label6";
            label6.Size = new Size(63, 31);
            label6.TabIndex = 13;
            label6.Text = "Unit ";
            // 
            // MerchandiseOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 811);
            Controls.Add(panel2);
            Controls.Add(txtSearchKho);
            Controls.Add(btnSearch);
            Controls.Add(btnRefresh);
            Controls.Add(panel1);
            Controls.Add(Add);
            Controls.Add(Delete);
            Controls.Add(Edit);
            Controls.Add(Exit);
            Controls.Add(dgvKho);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MerchandiseOrder";
            Text = "MerchandiseKho";
            Load += MerchandiseOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKho).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvKho;
        private Button Exit;
        private Button Add;
        private Button Edit;
        private Button Delete;
        private MenuStrip menuStrip1;
        private Panel panel1;
        private Button btnChemicals;
        private Button btnCanned;
        private Button btnCigarette;
        private Button btnFrozen;
        private Button btnOffice;
        private Button btnTissue;
        private Button btnSpices;
        private Button btnMilk;
        private Button btnMedicine;
        private Button btnPersonal;
        private Button btnInstant;
        private Button btnBeverage;
        private Button btnAlcoho;
        private Button btnSnack;
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtSearchKho;
        private Panel panel2;
        private Label label2;
        private TextBox txtName;
        private ComboBox cbCategory;
        private Label label3;
        private TextBox txtUnit;
        private TextBox txtDes;
        private TextBox txtQuantity;
        private Label label4;
        private TextBox txtPrice;
        private Label label5;
        private Label label7;
        private Label label6;
    }
}