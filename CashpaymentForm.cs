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
    public partial class CashpaymentForm : Form
    {
        public CashpaymentForm()
        {
            InitializeComponent();
        }
        DBConnect dBCon = new DBConnect();
        private decimal payableAmount = 0; // Holds the amount fetched
        private decimal totalAmount = 0;
       
       
        private void LoadPayableAmountFromStore()
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
                    payableAmount = tempAmount; // Assign the successfully parsed value to the class variable
                }
                else
                {
                    payableAmount = 0; // Set to 0 if loading fails
                    MessageBox.Show("Using default amount of 0.00. Please ensure the 'Store' table has data.", "Data Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                label_Rs.Text = payableAmount.ToString("N2") + " RS"; // Display the amount
            }
            catch (Exception ex)
            {
                payableAmount = 0;
                MessageBox.Show("Database error loading amount: " + ex.Message, "Fatal DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dBCon.CloseCon();
            }
        }
        private void label_Click(object sender, EventArgs e)
        {

        }

        private void Button_pay_Click(object sender, EventArgs e)
        {
            if (payableAmount <= 0)
            {
                MessageBox.Show("The payable amount is zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Validate Amount Given
            if (string.IsNullOrWhiteSpace(guna2TextBox_amount.Text) || !decimal.TryParse(guna2TextBox_amount.Text, out decimal amountGiven))
            {
                MessageBox.Show("Please enter a valid amount given.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Calculate Difference
            decimal difference = amountGiven - payableAmount;

            if (difference < 0)
            {
                // Amount is less than payable amount (Shortfall)
                decimal requiredMore = Math.Abs(difference);
                MessageBox.Show($"Amount insufficient. You need to pay {requiredMore:N2} RS more.", "Insufficient Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Amount is sufficient or more (Success)
                string successMessage;

                if (difference > 0)
                {
                    // Calculate Change
                    successMessage = $"Payment Successful!\nChange to be returned: {difference:N2} RS";
                }
                else
                {
                    // Exact amount given
                    successMessage = "Payment Successful! Exact amount received.";
                }

                // 3. Record Bill in Database (You would typically call a method here)
                // For simplicity, we signal success and close.
                InsertSuccessfulBill();
                MessageBox.Show(successMessage, "Payment Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Signal success to the calling form
                this.DialogResult = DialogResult.OK;
                this.Close(); // Close the cash payment form
                SellerSellingForm sellerSellingForm = new SellerSellingForm();
                sellerSellingForm.Show();
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void InsertSuccessfulBill()
        {
            try
            {
                // Ensure SellerName, SellDate, and TotalAnt columns exist in your Bill table
                string insertQuery = "INSERT INTO Bill (SellerName, SellDate, TotalAnt) VALUES (@Seller, @Date, @Total)";

                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());

                // Use the data from the labels and the calculated amount
                command.Parameters.AddWithValue("@Seller", label_buyer.Text); // Using label_buyer for SellerName
                command.Parameters.AddWithValue("@Date", label_date.Text);
                command.Parameters.AddWithValue("@Total", payableAmount);

                dBCon.OpenCon();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Show a clear error if the bill fails to save
                MessageBox.Show("Error recording bill in database: " + ex.Message, "Database Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dBCon.CloseCon();
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CashpaymentForm_Load(object sender, EventArgs e)
        {
            // 1. Set Buyer Name and Date
            label_buyer.Text = LoginForm.sellerName;
            label_date.Text = DateTime.Today.ToShortDateString();

            // 2. Load the Payable Amount
            LoadPayableAmountFromStore();
        }

        private void button_x_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
