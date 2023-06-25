namespace Convenience_Store
{
    partial class CreateCustomer
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
            btnSave = new Button();
            label4 = new Label();
            dtpDOB = new DateTimePicker();
            txtCusPhone = new TextBox();
            label17 = new Label();
            txtcusGender = new TextBox();
            txtCusName = new TextBox();
            txtCusId = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(644, 358);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 145);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 34;
            label4.Text = "Date Of Birth";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(176, 140);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(351, 27);
            dtpDOB.TabIndex = 33;
            // 
            // txtCusPhone
            // 
            txtCusPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCusPhone.Location = new Point(176, 178);
            txtCusPhone.Name = "txtCusPhone";
            txtCusPhone.Size = new Size(351, 27);
            txtCusPhone.TabIndex = 30;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(28, 181);
            label17.Name = "label17";
            label17.Size = new Size(131, 20);
            label17.TabIndex = 29;
            label17.Text = "Customer's Phone";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtcusGender
            // 
            txtcusGender.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtcusGender.Location = new Point(176, 101);
            txtcusGender.Name = "txtcusGender";
            txtcusGender.Size = new Size(351, 27);
            txtcusGender.TabIndex = 21;
            // 
            // txtCusName
            // 
            txtCusName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCusName.Location = new Point(176, 58);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(351, 27);
            txtCusName.TabIndex = 20;
            // 
            // txtCusId
            // 
            txtCusId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCusId.Enabled = false;
            txtCusId.Location = new Point(176, 16);
            txtCusId.Name = "txtCusId";
            txtCusId.Size = new Size(351, 27);
            txtCusId.TabIndex = 10;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(28, 104);
            label9.Name = "label9";
            label9.Size = new Size(137, 20);
            label9.TabIndex = 12;
            label9.Text = "Customer's Gender";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(28, 61);
            label8.Name = "label8";
            label8.Size = new Size(128, 20);
            label8.TabIndex = 11;
            label8.Text = "Customer's Name";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 19);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 10;
            label7.Text = "Customer ID";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dtpDOB);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtCusPhone);
            panel2.Controls.Add(txtCusId);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(txtCusName);
            panel2.Controls.Add(txtcusGender);
            panel2.Location = new Point(123, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(527, 231);
            panel2.TabIndex = 35;
            // 
            // CreateCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(btnSave);
            Name = "CreateCustomer";
            Text = "CreateCustomer";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnSave;
        private Label label4;
        private DateTimePicker dtpDOB;
        private TextBox txtCusPhone;
        private Label label17;
        private TextBox txtcusGender;
        private TextBox txtCusName;
        private TextBox txtCusId;
        private Label label9;
        private Label label8;
        private Label label7;
        private Panel panel2;
    }
}