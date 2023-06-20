namespace Convenience_Store
{
    partial class AddMerchandise
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
            panel2 = new Panel();
            label2 = new Label();
            txtName = new TextBox();
            cbCategory = new ComboBox();
            label3 = new Label();
            txtUnit = new TextBox();
            txtDes = new TextBox();
            Add = new Button();
            txtQuantity = new TextBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(cbCategory);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtUnit);
            panel2.Controls.Add(txtDes);
            panel2.Controls.Add(Add);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 378);
            panel2.TabIndex = 23;
            panel2.Paint += panel2_Paint;
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
            // Add
            // 
            Add.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Add.Location = new Point(12, 305);
            Add.Name = "Add";
            Add.Size = new Size(138, 52);
            Add.TabIndex = 3;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
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
            // AddMerchandise
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 405);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddMerchandise";
            Text = "AddMerchandise";
            Load += AddMerchandise_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private TextBox txtName;
        private ComboBox cbCategory;
        private Label label3;
        private TextBox txtUnit;
        private TextBox txtDes;
        private Button Add;
        private TextBox txtQuantity;
        private Label label4;
        private TextBox txtPrice;
        private Label label5;
        private Label label7;
        private Label label6;
    }
}