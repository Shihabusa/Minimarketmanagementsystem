using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace Mini_Market_Management_System
{
    public partial class SellingForm : Form
    {
        DBConnect dBCon = new DBConnect();
        DGVPrinter printer = new DGVPrinter();
        public SellingForm()
        {
            InitializeComponent();
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
                string selectQuerry = "SELECT ProdId, ProdName, ProdPrice, ProdQty FROM Product WHERE ProdQty > 0";
                SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataGridView_product.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getSellTable()
        {
            try
            {
                string selectQuerry = "SELECT * FROM Bill";
                SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataGridView_sellList.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Today.ToShortDateString();
            label_seller.Text = LoginForm.sellerName;
            getTable();
            getCategory();
            getSellTable();
        }

        private void DataGridView_product_Click(object sender, EventArgs e)
        {
            if (DataGridView_product.SelectedRows.Count > 0)
            {
                TextBox_name.Text = DataGridView_product.SelectedRows[0].Cells["ProdName"].Value.ToString();
                TextBox_price.Text = DataGridView_product.SelectedRows[0].Cells["ProdPrice"].Value.ToString();
                // Store the product ID for quantity updates
                TextBox_id.Text = DataGridView_product.SelectedRows[0].Cells["ProdId"].Value.ToString();
            }
        }

        int grandTotal = 0, n = 0;
        
        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView_order.Rows.Count == 0)
                {
                    MessageBox.Show("Please add items to the order first", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insert bill
                string insertQuery = "INSERT INTO Bill (SellerName, SellDate, TotalAnt) VALUES(@Seller, @Date, @Total)";
                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                command.Parameters.AddWithValue("@Seller", label_seller.Text);
                command.Parameters.AddWithValue("@Date", DateTime.Parse(label_date.Text));
                command.Parameters.AddWithValue("@Total", grandTotal);


                dBCon.OpenCon();
                command.ExecuteNonQuery();

                // Update product quantities
                UpdateProductQuantities();

                MessageBox.Show("Order Added Successfully", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();

                getSellTable();
                getTable(); // Refresh product list to show updated quantities

                // Clear order grid
                dataGridView_order.Rows.Clear();
                grandTotal = 0;
                label_amount.Text = "0 Ks";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProductQuantities()
        {
            foreach (DataGridViewRow row in dataGridView_order.Rows)
            {
                if (row.Cells[0].Value != null) // Check if row is not empty
                {
                    string productName = row.Cells[1].Value.ToString();
                    int quantitySold = Convert.ToInt32(row.Cells[3].Value);

                    // Update product quantity in database
                    string updateQuery = "UPDATE Product SET ProdQty = ProdQty - @Qty WHERE ProdName = @Name";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, dBCon.GetCon());
                    updateCommand.Parameters.AddWithValue("@Qty", quantitySold);
                    updateCommand.Parameters.AddWithValue("@Name", productName);
                    updateCommand.ExecuteNonQuery();
                }
            }
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            if (DataGridView_sellList.Rows.Count == 0)
            {
                MessageBox.Show("No sales data to print", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Print functionality
            printer.Title = "Daily Sell Lists";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Mini Market Management System";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_sellList);
        }

     

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
       

        private void comboBox_category_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string selectQuerry = "SELECT ProdId, ProdName, ProdPrice, ProdQty FROM Product WHERE ProdCat=@Category AND ProdQty > 0";
                SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
                command.Parameters.AddWithValue("@Category", comboBox_category.SelectedValue.ToString());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataGridView_product.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private int GetAvailableQuantity(string productName)
        {
            try
            {
                string query = "SELECT ProdQty FROM Product WHERE ProdName = @Name";
                SqlCommand command = new SqlCommand(query, dBCon.GetCon());
                command.Parameters.AddWithValue("@Name", productName);

                dBCon.OpenCon();
                object result = command.ExecuteScalar();
                dBCon.CloseCon();

                return result != null ? Convert.ToInt32(result) : 0;
            }
            catch
            {
                return 0;
            }
        }

        private void dataGridView_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_amount_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView_sellList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridView_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_refresh_Click_1(object sender, EventArgs e)
        {
            getTable();
        }

        private void label_date_Click(object sender, EventArgs e)
        {

        }

        private void button_GOcustomorder_Click(object sender, EventArgs e)
        {
            CustomOrderForm order = new CustomOrderForm();
            order.Show();
            this.Hide();
        }

        private void button_GObuyerdashboard_Click(object sender, EventArgs e)
        {
            SelerDashboardForm selerDashboard = new SelerDashboardForm();
            selerDashboard.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (TextBox_name.Text == "" || TextBox_qty.Text == "")
            {
                MessageBox.Show("Missing Information", "Information Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if quantity is available
            int availableQty = GetAvailableQuantity(TextBox_name.Text);
            int requestedQty = Convert.ToInt32(TextBox_qty.Text);

            if (requestedQty > availableQty)
            {
                MessageBox.Show($"Only {availableQty} units available in stock", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int Total = Convert.ToInt32(TextBox_price.Text) * Convert.ToInt32(TextBox_qty.Text);
            DataGridViewRow addRow = new DataGridViewRow();
            addRow.CreateCells(dataGridView_order);
            addRow.Cells[0].Value = ++n;
            addRow.Cells[1].Value = TextBox_name.Text;
            addRow.Cells[2].Value = TextBox_price.Text;
            addRow.Cells[3].Value = TextBox_qty.Text;
            addRow.Cells[4].Value = Total;
            dataGridView_order.Rows.Add(addRow);
            grandTotal += Total;
            label_amount.Text = grandTotal + " Ks";

            // Clear fields for next product
            TextBox_name.Clear();
            TextBox_price.Clear();
            TextBox_qty.Clear();
        }

        private void Button_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void comboBox_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_seller_Click(object sender, EventArgs e)
        {
            SellerForm form = new SellerForm(); 
            form.Show();
            this.Hide();
        }

        private void button_product_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            form.Show();
            this.Hide();
        }

        private void button_customprod_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm();
            form.Show();
            this.Hide();
        }

        private void label_seller_Click(object sender, EventArgs e)
        {

        }

        private void button_x_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Empty event handler
        }
    }
}