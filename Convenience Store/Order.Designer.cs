namespace MechandiseList
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            btnExit = new Button();
            label3 = new Label();
            txtTotal = new TextBox();
            label5 = new Label();
            btnExport = new Button();
            btnFinish = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnMerchandise = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(563, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(506, 222);
            dataGridView1.TabIndex = 13;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(118, 175);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(252, 211);
            dataGridView2.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(563, 432);
            label4.Name = "label4";
            label4.Size = new Size(95, 45);
            label4.TabIndex = 3;
            label4.Text = "Total:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.MenuText;
            panel1.Location = new Point(4, 13);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1148, 144);
            panel1.TabIndex = 20;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(417, 3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(299, 128);
            label1.TabIndex = 0;
            label1.Text = "Order";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnExit);
            panel2.Location = new Point(4, 519);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1140, 155);
            panel2.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(990, 11);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 32);
            label2.TabIndex = 1;
            label2.Text = "Order";
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
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(-908, 503);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(3051, 12);
            label3.TabIndex = 18;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtTotal
            // 
            txtTotal.BackColor = SystemColors.Menu;
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotal.Location = new Point(645, 437);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(75, 34);
            txtTotal.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(712, 432);
            label5.Name = "label5";
            label5.Size = new Size(37, 45);
            label5.TabIndex = 26;
            label5.Text = "$";
            // 
            // btnExport
            // 
            btnExport.FlatAppearance.BorderSize = 2;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Location = new Point(756, 412);
            btnExport.Margin = new Padding(4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(146, 74);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export Bill";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnFinish
            // 
            btnFinish.FlatAppearance.BorderSize = 2;
            btnFinish.FlatStyle = FlatStyle.Flat;
            btnFinish.Location = new Point(923, 412);
            btnFinish.Margin = new Padding(4);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(146, 74);
            btnFinish.TabIndex = 27;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.FlatAppearance.BorderSize = 2;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(16, 403);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(146, 74);
            btnEdit.TabIndex = 28;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(186, 403);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(146, 74);
            btnDelete.TabIndex = 29;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnMerchandise
            // 
            btnMerchandise.FlatAppearance.BorderSize = 2;
            btnMerchandise.FlatStyle = FlatStyle.Flat;
            btnMerchandise.Location = new Point(351, 403);
            btnMerchandise.Margin = new Padding(4);
            btnMerchandise.Name = "btnMerchandise";
            btnMerchandise.Size = new Size(146, 74);
            btnMerchandise.TabIndex = 30;
            btnMerchandise.Text = "Merchandise";
            btnMerchandise.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 591);
            Controls.Add(btnMerchandise);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnFinish);
            Controls.Add(btnExport);
            Controls.Add(label5);
            Controls.Add(txtTotal);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Order";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label4;
        private Panel panel1;
        private Label label6;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button btnExit;
        private Label label3;
        private TextBox txtTotal;
        private Label label5;
        private Button btnExport;
        private Button btnFinish;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnMerchandise;
    }
}