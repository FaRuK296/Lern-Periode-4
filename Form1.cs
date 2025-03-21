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

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');

                    if (parts.Length == 3 && decimal.TryParse(parts[1], out decimal amount))
                    {
                        string category = parts[0];
                        string date = parts[2];

                        budget += category == "Income" ? amount : -amount;

                        lstEntries.Items.Add($"{(category == "Income" ? "+" : "-")} {amount} $ am {date}");
                    }
                }
                lblBudget.Text = "Budget: " + budget + " $";
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
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:");

                string entry = $"{category};{moneyAmount};{date}";
                lstEntries.Items.Add($"{(category == "Income" ? "+" : "-")} {moneyAmount} $ on {date}");

                budget += category == "Income" ? moneyAmount : -moneyAmount;
                lblBudget.Text = "Budget: " + budget + " $";
                txtMoneyAmount.Clear();

                File.AppendAllText(filePath, entry + Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Please enter a valid and positive amount and select a category!");
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
                    string[] parts = item.ToString().Split(' ');
                    if (parts.Length >= 4)
                    {
                        string sign = parts[0];
                        decimal amount = decimal.Parse(parts[1]);
                        string date = parts[3] + " " + parts[4];

                        string category = sign == "+" ? "Income" : "Outcome";
                        writer.WriteLine($"{category};{amount};{date}");
                    }
                }
            }
        }

       

        private void btnCalculateGoal_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtWeeklySave.Text, out decimal weeklyAmount) &&
                decimal.TryParse(txtGoal.Text, out decimal goalAmount) &&
                weeklyAmount > 0 && goalAmount > 0)
            {
                int weeksNeeded = (int)Math.Ceiling(goalAmount / weeklyAmount);
                lblGoalResult.Text = $"Du musst {weeksNeeded} Woche(n) sparen, um dein Ziel von {goalAmount} € zu erreichen.";
            }
            else
            {
                MessageBox.Show("Bitte gib gültige, positive Zahlen für beide Felder ein.");
            }
        }
    }
}
