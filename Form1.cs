namespace LA_4
{
    public partial class Form1 : Form
    {
        private decimal budget = 0;
        private string filePath = "budget_data.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Add("Income");
            cmbCategory.Items.Add("Outcome");

            // check if file exists
            if (File.Exists(filePath))

            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {

                    string[] parts = line.Split(";");

                    if (parts.Length == 2 && decimal.TryParse(parts[1], out decimal amount))
                    {

                        string category = parts[0];

                        if (category == "Income")
                        {
                            budget += amount;
                            lstEntries.Items.Add("+" + amount + "$");
                        }

                        else if (category == "Outcome")
                        {
                            budget -= amount;
                            lstEntries.Items.Add("-" + amount + "$");
                        }
                    }
                }

                lblBudget.Text = "Budget" + budget + "$";
            }
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

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMoneyAmount.Text, out decimal moneyAmount) && moneyAmount > 0 && cmbCategory.SelectedItem != null)
            {
                string category = cmbCategory.SelectedItem.ToString();

                if (category == "Income")
                {
                    budget += moneyAmount;
                    lstEntries.Items.Add("+ " + moneyAmount + " $");
                }
                else if (category == "Outcome")
                {
                    budget -= moneyAmount;
                    lstEntries.Items.Add("- " + moneyAmount + " $");
                }

                lblBudget.Text = "Budget: " + budget + " $";
                txtMoneyAmount.Clear();

                // Save new entry in file
                File.AppendAllText(filePath, category + ";" + moneyAmount + Environment.NewLine);


            }


            else
            {
                MessageBox.Show("Please enter valid and positive amount of money and select category!");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            budget = 0;
            lblBudget.Text = "Budget: 0 $";

            lstEntries.Items.Clear();

            File.WriteAllText(filePath, "");

            MessageBox.Show("Budget has been reset.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstEntries.SelectedIndex != -1)

            {
                lstEntries.Items.RemoveAt(lstEntries.SelectedIndex);

                SaveEntriesToFile();

            }

            else
            {
                MessageBox.Show("Please choose an Entry.");
            }
        }

        private void SaveEntriesToFile()

        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var item in lstEntries.Items)
                {
                    writer.WriteLine(item.ToString());
                }


            }
        }
    }

}

