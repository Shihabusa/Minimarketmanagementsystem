using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Mini_Market_Management_System
{
    public partial class RegisterForm : Form
    {
        DBConnect dBCon = new DBConnect();
        private Form CreateLoginForm() => new LoginForm();

        public RegisterForm()
        {
            InitializeComponent();
        }

        // ====== FORM LOAD ======
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            SetSignUpEnabled(false);
            EnsurePassStatusLabel();
        }

        // ====== UI HELPERS ======
        private void SetSignUpEnabled(bool enabled)
        {
            var btn = this.Controls.Find("Button_SignUp", true).FirstOrDefault() as Control;
            if (btn != null) btn.Enabled = enabled;
        }

        private string GetTextFromControl(string controlName)
        {
            var c = this.Controls.Find(controlName, true).FirstOrDefault();
            if (c is TextBox tb) return tb.Text;
            if (c != null && c.GetType().FullName == "Guna.UI2.WinForms.Guna2TextBox")
            {
                dynamic gunaTextBox = c;
                return (string)gunaTextBox.Text;
            }
            return string.Empty;
        }

        private void SetUseSystemPasswordChar(string controlName, bool useSystemPassword)
        {
            var c = this.Controls.Find(controlName, true).FirstOrDefault();
            if (c is TextBox tb)
            {
                tb.UseSystemPasswordChar = useSystemPassword;
            }
            else if (c != null && c.GetType().FullName == "Guna.UI2.WinForms.Guna2TextBox")
            {
                dynamic gunaTextBox = c;
                gunaTextBox.UseSystemPasswordChar = useSystemPassword;
            }
        }

        // Creates or finds a label to show "Passwords match / don't match" feedback
        private Label _lblPassStatus;
        private void EnsurePassStatusLabel()
        {
            var lbl = this.Controls.Find("label_PassStatus", true).FirstOrDefault() as Label;
            if (lbl == null)
            {
                lbl = new Label
                {
                    Name = "label_PassStatus",
                    AutoSize = true,
                    ForeColor = Color.OrangeRed,
                    Text = "",
                    Visible = false
                };
                // Try to place it under confirm password field
                var confirm = this.Controls.Find("TextBox_confirmpassword", true).FirstOrDefault();
                if (confirm != null)
                {
                    lbl.Location = new Point(confirm.Left, confirm.Bottom + 5);
                    confirm.Parent.Controls.Add(lbl);
                }
                else
                {
                    this.Controls.Add(lbl);
                    lbl.Location = new Point(20, 20);
                }
            }
            _lblPassStatus = lbl;
        }

        // ====== VALIDATION ======
        private bool ValidateInputs(out string username, out string password, out string confirmPassword,
                            out string phone, out string age, out string errorMessage)
        {
            username = GetTextFromControl("TextBox_username")?.Trim();
            password = GetTextFromControl("TextBox_password");
            confirmPassword = GetTextFromControl("TextBox_confirmpassword");
            phone = GetTextFromControl("TextBox_number")?.Trim();
            age = GetTextFromControl("TextBox_age")?.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                errorMessage = "Username cannot be empty.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                errorMessage = "Password and Confirm Password cannot be empty.";
                return false;
            }

            if (password.Length < 4)
            {
                errorMessage = "Password must be at least 4 characters.";
                return false;
            }

            if (!PasswordsMatch(password, confirmPassword))
            {
                errorMessage = "Passwords do not match.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                errorMessage = "Phone number cannot be empty.";
                return false;
            }

            // Basic phone validation: digits only, length 7–15
            if (!Regex.IsMatch(phone, @"^\d{7,15}$"))
            {
                errorMessage = "Phone must contain only digits and be 7-15 digits long.";
                return false;
            }

            // Add age validation
            if (string.IsNullOrWhiteSpace(age))
            {
                errorMessage = "Age cannot be empty.";
                return false;
            }

            if (!int.TryParse(age, out int ageValue) || ageValue < 18 || ageValue > 100)
            {
                errorMessage = "Age must be a number between 18 and 100.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        private bool PasswordsMatch(string password, string confirmPassword)
            => string.Equals(password, confirmPassword, StringComparison.Ordinal);

        private void ShowPasswordMatchStatus()
        {
            EnsurePassStatusLabel();
            var pwd = GetTextFromControl("TextBox_password");
            var cpwd = GetTextFromControl("TextBox_confirmpassword");

            if (string.IsNullOrEmpty(pwd) && string.IsNullOrEmpty(cpwd))
            {
                _lblPassStatus.Visible = false;
                return;
            }

            if (PasswordsMatch(pwd, cpwd))
            {
                _lblPassStatus.Visible = true;
                _lblPassStatus.ForeColor = Color.ForestGreen;
                _lblPassStatus.Text = "Passwords match ✓";
            }
            else
            {
                _lblPassStatus.Visible = true;
                _lblPassStatus.ForeColor = Color.OrangeRed;
                _lblPassStatus.Text = "Passwords do not match";
            }
        }

        private void UpdateSignUpButtonState()
        {
            var pwd = GetTextFromControl("TextBox_password");
            var cpwd = GetTextFromControl("TextBox_confirmpassword");
            SetSignUpEnabled(PasswordsMatch(pwd, cpwd) && !string.IsNullOrWhiteSpace(pwd));
        }

        // ====== EVENT HOOKS (TextChanged) ======
        private void TextBox_password_TextChanged(object sender, EventArgs e)
        {
            ShowPasswordMatchStatus();
            UpdateSignUpButtonState();
        }

        private void TextBox_confirmpassword_TextChanged(object sender, EventArgs e)
        {
            ShowPasswordMatchStatus();
            UpdateSignUpButtonState();
        }

        private void TextBox_username_TextChanged(object sender, EventArgs e)
        {
            UpdateSignUpButtonState();
        }

        private void TextBox_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_age_TextChanged(object sender, EventArgs e)
        {
            UpdateSignUpButtonState();
        }

        private void Button_CheckPass_Click(object sender, EventArgs e)
        {
            string u, p, c, ph, age, err;
            if (!ValidateInputs(out u, out p, out c, out ph, out age, out err))
            {
                MessageBox.Show(err, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetSignUpEnabled(true);
            MessageBox.Show("All inputs are valid. You can continue.", "Check Inputs", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ====== SHOW/HIDE PASSWORD ======
        private void checkBox_Showpass_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox1 = (CheckBox)sender;
            bool hide = !checkBox1.Checked;

            SetUseSystemPasswordChar("TextBox_password", hide);
            SetUseSystemPasswordChar("TextBox_confirmpassword", hide);
        }

        // ====== SIGN UP CLICK ======
        private void Button_SignUp_Click(object sender, EventArgs e)
        {
            string username, password, confirmPassword, phone, age, errorMessage;

            if (!ValidateInputs(out username, out password, out confirmPassword, out phone, out age, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string passwordToStore = password;

            string insertQuery = @"
                INSERT INTO Seller (SellerName, SellerPass, SellerPhone, SellerAge)
                VALUES (@username, @password, @phone, @age);";

            SqlConnection con = null;
            try
            {
                con = dBCon.GetCon();

                using (SqlCommand command = new SqlCommand(insertQuery, con))
                {
                    command.Parameters.Add("@username", SqlDbType.NVarChar, 20).Value = username;
                    command.Parameters.Add("@password", SqlDbType.NVarChar, 10).Value = passwordToStore;
                    command.Parameters.Add("@phone", SqlDbType.NVarChar, 20).Value = phone;
                    command.Parameters.Add("@age", SqlDbType.NVarChar, 10).Value = age;

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Seller registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Go back to LoginForm
                        var login = CreateLoginForm();
                        login.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. No rows were affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration failed:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                try
                {
                    if (con != null && con.State != ConnectionState.Closed)
                        con.Close();
                }
                catch { /* ignore */ }
            }
        }

        // ====== OTHER EXISTING HANDLERS ======
        private void label_exit_Click(object sender, EventArgs e) => Application.Exit();

        private void label_exit_MouseEnter(object sender, EventArgs e) => (sender as Label).ForeColor = Color.Red;
        private void label_exit_MouseLeave(object sender, EventArgs e) => (sender as Label).ForeColor = Color.Goldenrod;

        private void label_SignUp_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.FromArgb(70, 130, 180);

            Timer colorResetTimer = new Timer { Interval = 200 };
            colorResetTimer.Tick += (s, args) =>
            {
                label.ForeColor = Color.DarkSlateGray;
                colorResetTimer.Stop();
                colorResetTimer.Dispose();
            };
            colorResetTimer.Start();
        }

        // Unused handlers
        private void label4_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void guna2CircleButton1_Click(object sender, EventArgs e) { }
    }
}