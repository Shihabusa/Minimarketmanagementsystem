using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace Mini_Market_Management_System
{
    public partial class LoginForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public static string sellerName;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Goldenrod;
        }

        private void label_clear_MouseEnter(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Red;
        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
            label_clear.ForeColor = Color.Goldenrod;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_clear_Click(object sender, EventArgs e)
        {
            TextBox_username.Clear();
            TextBox_password.Clear();
        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            if (TextBox_username.Text == "" || TextBox_password.Text == "")
            {
                MessageBox.Show("Please Enter Username and Password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string username = TextBox_username.Text;
                string password = TextBox_password.Text;

                // 🔹 Admin Login
                if (username == "Admin" && password == "Admin123")
                {
                    ProductForm product = new ProductForm();
                    product.Show();
                    this.Hide();
                }
                else if(username == "DELIVERY" && password == "DELIVERY123") 
                {
                    DeliveryDashboardForm deliver = new DeliveryDashboardForm();
                    deliver.Show();
                    this.Hide();
                }
                else
                {
                    bool loginSuccess = false;

                    // 🔹 Check Seller Table
                    string sellerQuery = "SELECT * FROM Seller WHERE SellerName=@username AND SellerPass=@password";
                    using (SqlCommand cmd = new SqlCommand(sellerQuery, dBCon.GetCon()))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            sellerName = username; // keep your sellerName reference
                            SellerSellingForm selling = new SellerSellingForm();
                            selling.Show();
                            this.Hide();
                            loginSuccess = true;
                        }
                    }

                    // 🔹 Check Customer Table (only if seller login failed)
                    if (!loginSuccess)
                    {
                        string customerQuery = "SELECT * FROM Customer WHERE CusName=@username AND CusPass=@password";
                        using (SqlCommand cmd = new SqlCommand(customerQuery, dBCon.GetCon()))
                        {
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                CustomForm customer = new CustomForm(); // <-- create a form for customer
                                customer.Show();
                                this.Hide();
                                loginSuccess = true;
                            }
                        }
                    }

                    // 🔹 If not found anywhere
                    if (!loginSuccess)
                    {
                        MessageBox.Show("Wrong Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox1 = (CheckBox)sender;

            // Find the password control
            var passwordControl = this.Controls.Find("TextBox_password", true)[0];

            // Handle Guna2TextBox specifically
            if (passwordControl is Guna.UI2.WinForms.Guna2TextBox gunaTextBox)
            {
                gunaTextBox.UseSystemPasswordChar = !checkBox1.Checked;
            }
            // Handle standard TextBox
            else if (passwordControl is TextBox standardTextBox)
            {
                standardTextBox.UseSystemPasswordChar = !checkBox1.Checked;
            }
            else
            {
                MessageBox.Show("Password control not found or is an unexpected type");
            }
        }

        private void TextBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create an instance of RegisterForm
            RegisterForm register = new RegisterForm();

            // Show the RegisterForm
            register.Show();

            // Hide or close the current form
            this.Hide(); // Use Hide() if you want to return later
                         // this.Close(); // Use Close() if you want to completely close this form
        }

    }
}
