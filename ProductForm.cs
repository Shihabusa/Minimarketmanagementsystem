using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mini_Market_Management_System
{
    public partial class ProductForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public ProductForm()
        {
            InitializeComponent();
        }


        private void ProductForm_Load(object sender, EventArgs e)
        {
            getCategory();
            getTable();
        }

        private void getCategory()
        {
            try
            {
                string selectQuerry = "SELECT * FROM Category";
                SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                comboBox_category.DataSource = table;
                comboBox_category.ValueMember = "CatName";
                comboBox_search.DataSource = table;
                comboBox_search.ValueMember = "CatName";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getTable()
        {
            try
            {
                string selectQuerry = "SELECT * FROM Product";
                SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView_product.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear()
        {
            TextBox_id.Clear();
            TextBox_name.Clear();
            TextBox_price.Clear();
            TextBox_qty.Clear();
            comboBox_category.SelectedIndex = 0;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TextBox_id.Text) || string.IsNullOrWhiteSpace(TextBox_name.Text) ||
                    string.IsNullOrWhiteSpace(TextBox_price.Text) || string.IsNullOrWhiteSpace(TextBox_qty.Text))
                {
                    MessageBox.Show("Please fill all fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Use parameterized query to prevent SQL injection
                string insertQuery = "INSERT INTO Product VALUES(@Id, @Name, @Price, @Qty, @Category)";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                command.Parameters.AddWithValue("@Id", TextBox_id.Text);
                command.Parameters.AddWithValue("@Name", TextBox_name.Text);
                command.Parameters.AddWithValue("@Price", Convert.ToDecimal(TextBox_price.Text));
                command.Parameters.AddWithValue("@Qty", Convert.ToInt32(TextBox_qty.Text));
                command.Parameters.AddWithValue("@Category", comboBox_category.Text);

                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TextBox_id.Text) || string.IsNullOrWhiteSpace(TextBox_name.Text) ||
                    string.IsNullOrWhiteSpace(TextBox_price.Text) || string.IsNullOrWhiteSpace(TextBox_qty.Text))
                {
                    MessageBox.Show("Please fill all fields", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Use parameterized query
                string updateQuery = "UPDATE Product SET ProdName=@Name, ProdPrice=@Price, ProdQty=@Qty, ProdCat=@Category WHERE ProdId=@Id";
                SqlCommand command = new SqlCommand(updateQuery, dBCon.GetCon());
                command.Parameters.AddWithValue("@Name", TextBox_name.Text);
                command.Parameters.AddWithValue("@Price", Convert.ToDecimal(TextBox_price.Text));
                command.Parameters.AddWithValue("@Qty", Convert.ToInt32(TextBox_qty.Text));
                command.Parameters.AddWithValue("@Category", comboBox_category.Text);
                command.Parameters.AddWithValue("@Id", TextBox_id.Text);

                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Updated Successfully", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_product_Click_1(object sender, EventArgs e)
        {
            if (dataGridView_product.SelectedRows.Count > 0)
            {
                TextBox_id.Text = dataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
                TextBox_name.Text = dataGridView_product.SelectedRows[0].Cells[1].Value.ToString();
                TextBox_price.Text = dataGridView_product.SelectedRows[0].Cells[2].Value.ToString();
                TextBox_qty.Text = dataGridView_product.SelectedRows[0].Cells[3].Value.ToString();
                comboBox_category.SelectedValue = dataGridView_product.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TextBox_id.Text))
                {
                    MessageBox.Show("Please select a product to delete", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM Product WHERE ProdId=@Id";
                    SqlCommand command = new SqlCommand(deleteQuery, dBCon.GetCon());
                    command.Parameters.AddWithValue("@Id", TextBox_id.Text);

                    dBCon.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dBCon.CloseCon();
                    getTable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string selectQuerry = "SELECT * FROM Product WHERE ProdCat=@Category";
                SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
                command.Parameters.AddWithValue("@Category", comboBox_search.SelectedValue.ToString());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView_product.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void label_logout_MouseEnter(object sender, EventArgs e)
        {
            Button_logout.ForeColor = Color.Red;
        }

        private void label_logout_MouseLeave(object sender, EventArgs e)
        {
            Button_logout.ForeColor = Color.Goldenrod;
        }

        private void label_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Empty event handler
        }

     
        private void button_GOseller_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();

        }

        private void button_GOcategory_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void button_GOselling_Click(object sender, EventArgs e)
        {

            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }

        private void button_GOdashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();

        }

        private void Button_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button_refresh_Click_1(object sender, EventArgs e)
        {

            getTable();
        }

        private void button_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}