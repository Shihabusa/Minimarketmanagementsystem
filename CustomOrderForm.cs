using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Mini_Market_Management_System
{
    public partial class CustomOrderForm : Form
    {
        DBConnect dbConnect = new DBConnect();
        DataTable orderDetailsTable = new DataTable();
        decimal totalAmount = 0,n=0;

        public CustomOrderForm()
        {
            InitializeComponent();
        }

      

        private void LoadCustomData()
        {
            try
            {
                dbConnect.OpenCon();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Id, catName FROM CustomName", dbConnect.GetCon());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridView_categoryname.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
            finally
            {
                dbConnect.CloseCon();
            }

            try
            {
                dbConnect.OpenCon();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Id, shoetype, hight FROM CustomType", dbConnect.GetCon());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridView_shoetype.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading shoe types: " + ex.Message);
            }
            finally
            {
                dbConnect.CloseCon();
            }

            try
            {
                dbConnect.OpenCon();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Material, price FROM Custommaterial", dbConnect.GetCon());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridView_ProductMaterial.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading materials: " + ex.Message);
            }
            finally
            {
                dbConnect.CloseCon();
            }
        }

        private void CustomOrderForm_Load(object sender, EventArgs e)
        {
        
            LoadCustomData();
            label_date.Text = DateTime.Today.ToShortDateString();
            label_seller.Text = LoginForm.sellerName;
        }

        private void DataGridView_categoryname_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGridView_categoryname.Rows[e.RowIndex];
                TextBox_Categoryname.Text = row.Cells["catName"].Value?.ToString();
            }
        }

        private void DataGridView_shoetype_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGridView_shoetype.Rows[e.RowIndex];
                TextBox_shoeType.Text = row.Cells["shoetype"].Value?.ToString();
            }
        }

        private void DataGridView_ProductMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DataGridView_ProductMaterial.Rows[e.RowIndex];
                guna2TextBox_productMaterial.Text = row.Cells["Material"].Value?.ToString();
                guna2TextBox1.Text = row.Cells["price"].Value?.ToString();
            }
        }

        // This button adds the custom order item to the DataTable
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox_Categoryname.Text) || string.IsNullOrEmpty(TextBox_shoeType.Text) || string.IsNullOrEmpty(TextBox_qty.Text) || string.IsNullOrEmpty(guna2TextBox1.Text) || string.IsNullOrEmpty(guna2TextBox_productMaterial.Text))
            {
                MessageBox.Show("Please fill all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(TextBox_qty.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Quantity must be a positive number.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(guna2TextBox1.Text, out decimal price))
            {
                MessageBox.Show("Invalid price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            /*
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
            */
            DataGridViewRow addRow = new DataGridViewRow();
            addRow.CreateCells(dataGridView_order);
            addRow.Cells[0].Value = ++n;
            addRow.Cells[1].Value = TextBox_Categoryname.Text;
            addRow.Cells[2].Value = TextBox_shoeType.Text;
            addRow.Cells[3].Value = guna2TextBox_productMaterial.Text;
            addRow.Cells[4].Value = quantity;
            addRow.Cells[5].Value = price;
            addRow.Cells[6].Value = price * quantity;
            dataGridView_order.Rows.Add(addRow);

            totalAmount += price * quantity;
            label_amount.Text = totalAmount.ToString("N2") + " Ks";
            try
            {
                // Use UPDATE to modify the existing single record for the running total.
                // This assumes the Store table has a single row or you use a key to find it.
                // The most common way is to update the single row in the table.
                string updateQuery = "UPDATE Store SET Amount = @Total";

               SqlCommand command = new SqlCommand(updateQuery, dbConnect.GetCon());
                command.Parameters.AddWithValue("@Total", totalAmount);

                dbConnect.OpenCon();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Show an error if the database update fails
                MessageBox.Show("Error updating Store total: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbConnect.CloseCon();
            }


            TextBox_Categoryname.Clear();
            TextBox_shoeType.Clear();
            TextBox_qty.Clear();
            guna2TextBox1.Clear();
            guna2TextBox_productMaterial.Clear();
        }

        // This button places the entire order to the database without a separate OrderDetails table
        private void button_senttobill_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Hide();
            /*  if (orderDetailsTable.Rows.Count == 0)
              {
                  MessageBox.Show("No items in the order!", "Order Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  return;
              }

              try
              {
                  dbConnect.OpenCon();

                  // Insert into Bill table and get the new BillId
                  string insertBillQuery = "INSERT INTO Bill (SellerName, SellDate, TotalAnt) VALUES (@SellerName, @SellDate, @TotalAnt)";
                  SqlCommand billCmd = new SqlCommand(insertBillQuery, dbConnect.GetCon());
                  billCmd.Parameters.AddWithValue("@SellerName", label_seller.Text);
                  billCmd.Parameters.AddWithValue("@SellDate", DateTime.Parse(label_date.Text));
                  billCmd.Parameters.AddWithValue("@TotalAnt", totalAmount);

                  billCmd.ExecuteNonQuery();

                  MessageBox.Show("Order Added Successfully", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  // Clear DataGridView and reset totals
                  orderDetailsTable.Rows.Clear();
                  totalAmount = 0;
                  label_amount.Text = "0 Ks";
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Error processing order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              finally
              {
                  dbConnect.CloseCon();
              }

          */
        }

        // Empty event handlers
        private void guna2TextBox2_TextChanged(object sender, EventArgs e) { }
        private void TextBox_shoeType_TextChanged(object sender, EventArgs e) { }
        private void TextBox_qty_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e) { }
        private void label_amount_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label_seller_Click(object sender, EventArgs e) { }
        private void label_date_Click(object sender, EventArgs e) { }
        private void label_exit_Click(object sender, EventArgs e) { Application.Exit(); }
        private void panel1_Paint_1(object sender, PaintEventArgs e) { }
        private void button_customprod_Click(object sender, EventArgs e)
        {
            SellerSellingForm sellingForm = new SellerSellingForm();
            sellingForm.Show();
            this.Hide();
        }
        private void button_refresh_Click_1(object sender, EventArgs e) { }

        private void button_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
