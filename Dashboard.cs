using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mini_Market_Management_System
{
    public partial class Dashboard : Form
    {
        DBConnect dBCon = new DBConnect();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // This event handler was missing in your original code
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            LoadTotalUsers();
            getReviewTable();
            LoadDailyEarnings();
            LoadTotalEarnings();
            getDeliveryTable();
         
        }
        private void getReviewTable()
        {
            string selectQuerry = "SELECT * FROM Review";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_reviewlist.DataSource = table;
        }

        private void getDeliveryTable()
        {
            try
            {
                string selectQuery = "SELECT * FROM Delivery";
                SqlCommand command = new SqlCommand(selectQuery, dBCon.GetCon());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataGridView_deliverydetails.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading delivery status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTotalUsers()
        {
            try
            {
                var con = dBCon.GetCon();
                dBCon.OpenCon();

                string query = "SELECT SellerId, SellerName FROM Seller ORDER BY SellerId";
                var dt = new DataTable();
                using (var da = new SqlDataAdapter(query, con))
                {
                    da.Fill(dt);
                }

                // Make sure you have a DataGridView named 'dataGridView_totaluser' on your form
                dataGridView_totaluser.DataSource = dt;
                // Make sure you have a Label named 'label_tuser' on your form
                label_tuser.Text = $"Total Users: {dt.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dBCon.CloseCon();
            }
        }

        private void LoadTotalCategories()
        {
            try
            {
                var con = dBCon.GetCon();
                dBCon.OpenCon();

                string query = "SELECT CatId, CatName, CatDes FROM Category ORDER BY CatId";
                var dt = new DataTable();
                using (var da = new SqlDataAdapter(query, con))
                {
                    da.Fill(dt);
                }

                // This section was missing in your original code
                // Make sure you have a DataGridView named 'dataGridView_totalcategory' on your form
             

            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Invalid column name"))
                    MessageBox.Show("Check Category column names (CatId, CatName, CatDes / CatDesc).", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"Error loading categories: {ex.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dBCon.CloseCon();
            }
        }

        private void LoadDailyEarnings()
        {
            try
            {
                var con = dBCon.GetCon();
                dBCon.OpenCon();

                string gridQuery = @"
                    SELECT BillId, SellerName, SellDate, TotalAnt
                    FROM Bill
                    WHERE TRY_CONVERT(date, NULLIF(RTRIM(SellDate), '')) = CAST(GETDATE() AS date)
                    ORDER BY BillId;";

                var gridTable = new DataTable();
                using (var da = new SqlDataAdapter(gridQuery, con))
                {
                    da.Fill(gridTable);
                }
                // Make sure you have a DataGridView named 'dataGridView_dailyearn' on your form
                dataGridView_dailyearn.DataSource = gridTable;

                string sumQuery = @"
                    SELECT SUM(TRY_CONVERT(decimal(18,2), TotalAnt))
                    FROM Bill
                    WHERE TRY_CONVERT(date, NULLIF(RTRIM(SellDate), '')) = CAST(GETDATE() AS date);";

                decimal dailyTotal = 0m;
                using (var cmd = new SqlCommand(sumQuery, con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        dailyTotal = Convert.ToDecimal(result);
                }

                // Make sure you have a Label named 'label_dearning' on your form
                label_dearning.Text = $"Daily Earnings: {dailyTotal:0.##} Ks";
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Invalid column name"))
                    MessageBox.Show("Check Bill column names (BillId, SellerName, SellDate, TotalAnt/TotalAmt).", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"Error loading daily earnings: {ex.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading daily earnings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dBCon.CloseCon();
            }
        }

        private void LoadTotalEarnings()
        {
            try
            {
                var con = dBCon.GetCon();
                dBCon.OpenCon();

                string gridQuery = "SELECT BillId, SellerName, SellDate, TotalAnt FROM Bill ORDER BY BillId;";
                var gridTable = new DataTable();
                using (var da = new SqlDataAdapter(gridQuery, con))
                {
                    da.Fill(gridTable);
                }
                // Make sure you have a DataGridView named 'dataGridView_totalearn' on your form
                dataGridView_totalearn.DataSource = gridTable;

                string sumQuery = "SELECT SUM(TRY_CONVERT(decimal(18,2), TotalAnt)) FROM Bill;";
                decimal total = 0m;
                using (var cmd = new SqlCommand(sumQuery, con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        total = Convert.ToDecimal(result);
                }

                // Make sure you have a Label named 'label_totalearning' on your form
                label_totalearning.Text = $"Total Earnings: {total:0.##} Ks";
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Invalid column name"))
                    MessageBox.Show("Check Bill column names (BillId, SellerName, SellDate, TotalAnt/TotalAmt).", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"Error loading total earnings: {ex.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading total earnings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dBCon.CloseCon();
            }
        }

        // DataGridView event handlers
        private void dataGridView_totaluser_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView_totalcategory_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView_dailyearn_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dataGridView_totalearn_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        // Label click events
        private void label_tuser_Click(object sender, EventArgs e) { }
        private void label_tcategory_Click(object sender, EventArgs e) { }
        private void label_dearning_Click(object sender, EventArgs e) { }
        private void label_totalearning_Click(object sender, EventArgs e) { }

        // Other event handlers
        private void button1_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_GOcustomorder_Click(object sender, EventArgs e)
        {
            CustomForm customForm = new CustomForm();
            customForm.Show();
            this.Close();
        }

        private void guna2Button_REFRESH_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
            MessageBox.Show("Dashboard data refreshed successfully!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                                                "Confirm Logout",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void button_seller_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();   
            sellerForm.Show();
            this.Close();
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Close();
        }

        private void button_selling_Click(object sender, EventArgs e)
        {
            SellingForm sellingForm = new SellingForm();
            sellingForm.Show();
            this.Close();
        }

        private void button_customprod_Click(object sender, EventArgs e)
        {
            CustomForm  customForm = new CustomForm();
            customForm.Show();
            this.Close();
        }

        private void button_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataGridView_deliverydetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}