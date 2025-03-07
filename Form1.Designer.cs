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
            lblBudget = new Label();
            txtMoneyAmount = new TextBox();
            btnAdd = new Button();
            cmbCategory = new ComboBox();
            lstEntries = new ListBox();
            btnReset = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(549, 371);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(112, 25);
            lblBudget.TabIndex = 0;
            lblBudget.Text = "Budget: 0 Fr.";
            lblBudget.Click += lblBudget_Click;
            // 
            // txtMoneyAmount
            // 
            txtMoneyAmount.Location = new Point(151, 68);
            txtMoneyAmount.Name = "txtMoneyAmount";
            txtMoneyAmount.Size = new Size(180, 31);
            txtMoneyAmount.TabIndex = 1;
            txtMoneyAmount.TextChanged += textBox1_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(151, 365);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 31);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(453, 68);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(182, 33);
            cmbCategory.TabIndex = 3;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // lstEntries
            // 
            lstEntries.FormattingEnabled = true;
            lstEntries.ItemHeight = 25;
            lstEntries.Location = new Point(151, 120);
            lstEntries.Name = "lstEntries";
            lstEntries.Size = new Size(484, 229);
            lstEntries.TabIndex = 4;
            lstEntries.SelectedIndexChanged += lstEntries_SelectedIndexChanged;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(398, 366);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(129, 32);
            btnReset.TabIndex = 5;
            btnReset.Text = "reset budget";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(280, 365);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 33);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
