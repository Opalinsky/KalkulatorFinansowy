namespace KalkulatorFinansowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Dodanie wartości do ComboBox
            comboBox1.Items.Add("Roczna");
            comboBox1.Items.Add("Miesięczna");

            // Ustawienie domyślnej wartości
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) &&
                !string.IsNullOrEmpty(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox5.Text))
            {
                try
                {
                    double HowManyYears = double.Parse(textBox1.Text);
                    double FirstTransfer = double.Parse(textBox2.Text);
                    double YearRateOfReturn = double.Parse(textBox3.Text) / 100;
                    double PaymentAmount = double.Parse(textBox5.Text);

                    // Sprawdzenie wybranej opcji w ComboBox
                    string selectedOption = comboBox1.SelectedItem.ToString();
                    int paymentsPerYear = selectedOption == "Miesięczna" ? 12 : 1;
                    double annualPaymentAmount = PaymentAmount * paymentsPerYear;

                    double totalAmount = FirstTransfer;

                    for (int i = 1; i <= HowManyYears; i++)
                    {
                        // Dodanie rocznych wpłat
                        totalAmount += annualPaymentAmount;

                        // Aktualizacja wartości inwestycji o roczny zwrot
                        totalAmount += totalAmount * YearRateOfReturn;
                    }
                    if (checkBox1.Checked)
                    {
                        totalAmount = totalAmount * 0.8;
                    }
                    textBox4.Text = totalAmount.ToString("F2");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Nieprawidłowy format liczby. Proszę wprowadzić poprawne dane.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas obliczeń: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Proszę wypełnić wszystkie pola.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Inne metody eventowe pozostają bez zmian


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
