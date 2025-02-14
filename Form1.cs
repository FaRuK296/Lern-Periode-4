namespace LA_4
{
    public partial class Form1 : Form
    {
        private decimal budget = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstEntries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblBudget_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMoneyAmount.Text, out decimal moneyAmount) && cmbCategory.SelectedItem != null)
            {
                string category = cmbCategory.SelectedItem.ToString();

                if (category == "Income")
                {
                    budget += moneyAmount;
                    lstEntries.Items.Add("+ " + moneyAmount + " €");
                }
                else if (category == "Outcome")
                {
                    budget -= moneyAmount;
                    lstEntries.Items.Add("- " + moneyAmount + " €");
                }

                lblBudget.Text = "Budget: " + budget + " €";
                txtMoneyAmount.Clear();
            }
            else
            {
                MessageBox.Show("Please enter valid amount and select category!");
            }
        
    }
    }
}

