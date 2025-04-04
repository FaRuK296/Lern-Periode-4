namespace LA_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblBudget = new Label();
            txtMoneyAmount = new TextBox();
            btnAdd = new Button();
            cmbCategory = new ComboBox();
            lstEntries = new ListBox();
            btnReset = new Button();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.BackColor = Color.PapayaWhip;
            lblBudget.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBudget.ForeColor = Color.SeaGreen;
            lblBudget.Location = new Point(619, 350);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(119, 20);
            lblBudget.TabIndex = 0;
            lblBudget.Text = "Budget: 0 $";
            lblBudget.Click += lblBudget_Click;
            // 
            // txtMoneyAmount
            // 
            txtMoneyAmount.BackColor = Color.PapayaWhip;
            txtMoneyAmount.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMoneyAmount.ForeColor = Color.SeaGreen;
            txtMoneyAmount.Location = new Point(85, 56);
            txtMoneyAmount.Name = "txtMoneyAmount";
            txtMoneyAmount.Size = new Size(180, 28);
            txtMoneyAmount.TabIndex = 1;
            txtMoneyAmount.TextChanged += textBox1_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.PapayaWhip;
            btnAdd.Font = new Font("Broadway", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.SeaGreen;
            btnAdd.Location = new Point(28, 350);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 88);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.PapayaWhip;
            cmbCategory.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.ForeColor = Color.SeaGreen;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(505, 56);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(182, 28);
            cmbCategory.TabIndex = 3;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // lstEntries
            // 
            lstEntries.BackColor = Color.SeaGreen;
            lstEntries.Cursor = Cursors.Hand;
            lstEntries.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstEntries.ForeColor = Color.PapayaWhip;
            lstEntries.FormattingEnabled = true;
            lstEntries.ItemHeight = 20;
            lstEntries.Location = new Point(28, 114);
            lstEntries.Name = "lstEntries";
            lstEntries.Size = new Size(727, 224);
            lstEntries.TabIndex = 4;
            lstEntries.SelectedIndexChanged += lstEntries_SelectedIndexChanged;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.PapayaWhip;
            btnReset.Font = new Font("Broadway", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.SeaGreen;
            btnReset.Location = new Point(282, 350);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(161, 88);
            btnReset.TabIndex = 5;
            btnReset.Text = "reset budget";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.PapayaWhip;
            btnDelete.Font = new Font("Broadway", 14F);
            btnDelete.ForeColor = Color.SeaGreen;
            btnDelete.Location = new Point(157, 350);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 88);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PapayaWhip;
            label1.Font = new Font("Broadway", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(28, 5);
            label1.Name = "label1";
            label1.Size = new Size(288, 34);
            label1.TabIndex = 7;
            label1.Text = "money amount ⬇️";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.PapayaWhip;
            label2.Font = new Font("Broadway", 15F);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(442, 5);
            label2.Name = "label2";
            label2.Size = new Size(313, 34);
            label2.TabIndex = 8;
            label2.Text = "income/outcome ⬇️";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(784, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnReset);
            Controls.Add(lstEntries);
            Controls.Add(cmbCategory);
            Controls.Add(btnAdd);
            Controls.Add(txtMoneyAmount);
            Controls.Add(lblBudget);
            Name = "Form1";
            Text = "Budget-Tracker";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBudget;
        private TextBox txtMoneyAmount;
        private Button btnAdd;
        private ComboBox cmbCategory;
        private ListBox lstEntries;
        private Button btnReset;
        private Button btnDelete;
        private Label label1;
        private Label label2;
    }
}
