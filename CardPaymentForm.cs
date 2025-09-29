using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Market_Management_System
{
    public partial class CardPaymentForm : Form
    {
        public CardPaymentForm()
        {
            InitializeComponent();
        }
        DBConnect dBCon = new DBConnect();
        private decimal amountDue = 0;

        private void InsertSuccessfulBill()
        {
            try
            {
                // Ensure SellerName, SellDate, and TotalAnt columns exist in your Bill table
                string insertQuery = "INSERT INTO Bill (SellerName, SellDate, TotalAnt) VALUES (@Seller, @Date, @Total)";

                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());

                // Use the data from the labels and the calculated amount
                command.Parameters.AddWithValue("@Seller", label_buyer.Text);
                command.Parameters.AddWithValue("@Date", label_date.Text);
                command.Parameters.AddWithValue("@Total", amountDue);

                dBCon.OpenCon();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // IMPORTANT: If this fails, the payment message is misleading.
                MessageBox.Show("Error recording bill in database: " + ex.Message, "Database Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dBCon.CloseCon();
            }
        }
      


        private void LoadAmountFromStore()
            {
            try
            {
                string query = "SELECT TOP 1 Amount FROM Store";
                SqlCommand command = new SqlCommand(query, dBCon.GetCon());
                dBCon.OpenCon();

                object result = command.ExecuteScalar();

                // Use a temporary variable 'tempAmount' for parsing.
                decimal tempAmount = 0;

                // Check for null/DBNull/valid parse, and use the class variable 'amountDue'
                if (result != null && result != DBNull.Value && decimal.TryParse(result.ToString(), out tempAmount))
                {
                    amountDue = tempAmount; // Assign the successfully parsed value to the class variable
                }
                else
                {
                    amountDue = 0; // Set to 0 if loading fails
                    MessageBox.Show("Using default amount of 0.00. Please ensure the 'Store' table has data.", "Data Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                label_amount.Text = amountDue.ToString("N2") + " RS"; // Display the amount
            }
            catch (Exception ex)
            {
                amountDue = 0;
                MessageBox.Show("Database error loading amount: " + ex.Message, "Fatal DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dBCon.CloseCon();
            }
        }
            private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_first_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void TextBox_last_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_CardNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_code_TextChanged(object sender, EventArgs e)
        {

        }

      
     
        private void Button_makepayment_Click(object sender, EventArgs e)
        {
            // 1. Check if the amount is zero before processing
            if (amountDue <= 0)
            {
                MessageBox.Show("The amount due is zero. Cannot process payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. INPUT VALIDATION
            if (!ValidateInput())
            {
                return; // Validation failed, messages were shown
            }

            // 3. SIMULATED PAYMENT SUCCESS LOGIC
            // After successful payment validation:

            // 4. RECORD BILL IN DATABASE
            InsertSuccessfulBill(); // Call the new insertion method

            MessageBox.Show($"Payment of {amountDue:N2} Ks Done Successfully!", "Payment Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK; // Signal success to the calling form
            SellerSellingForm sellerSellingForm = new SellerSellingForm();
            sellerSellingForm.Show();
            this.Close(); 
        }
        private bool ValidateInput()
        {
            // 1. Check for empty fields
            if (
                string.IsNullOrWhiteSpace(TextBox_last.Text) ||
                string.IsNullOrWhiteSpace(TextBox_CardNum.Text) ||
                string.IsNullOrWhiteSpace(TextBox_code.Text))
            {
                MessageBox.Show("Please fill all card details.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 2. First name and last name must not be the same
            if (TextBox_first.Text.Equals(TextBox_last.Text, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("First Name and Last Name cannot be the same.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // 3. Card number validation (15 digits exactly)
            if (TextBox_CardNum.Text.Length != 15 || !long.TryParse(TextBox_CardNum.Text, out _))
            {
                MessageBox.Show("Card Number must be exactly 15 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // 4. Security code validation (3 or 4 digits exactly)
            if ((TextBox_code.Text.Length != 3 && TextBox_code.Text.Length != 4) || !int.TryParse(TextBox_code.Text, out _))
            {
                MessageBox.Show("Security Code must be 3 or 4 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // 5. Check if Debit or Credit is selected
           

            return true;
        }
        private void button_x_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void CardPaymentForm_Load(object sender, EventArgs e)
        {
            // Set Date and Buyer Name from LoginForm (assuming label_buyer and labelDate exist)
            label_date.Text = DateTime.Today.ToShortDateString();
            label_buyer.Text = LoginForm.sellerName;
            TextBox_first.Text = LoginForm.sellerName;
            TextBox_first.ReadOnly = true;
            // Load and display the Amount from the Store table
            LoadAmountFromStore();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label_amount_Click(object sender, EventArgs e)
        {

        }

        private void label_buyer_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
