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
    public partial class ReveiwForm : Form
    {
        public ReveiwForm()
        {
            InitializeComponent();
        }
        DBConnect dBCon = new DBConnect();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void getProductTable()
        {
            try
            {
                string selectQuerry = "SELECT ProdId, ProdName,ProdCat FROM Product ";
                SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataGridView_productdetail.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void getReviewTable()
        {
            string selectQuerry = "SELECT Id, Name,Description,Category FROM Review ";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            command.Parameters.AddWithValue("@SellerName", LoginForm.sellerName);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_reviewlist.DataSource = table;
        }
        private void ReviewForm_Load(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Today.ToShortDateString();
            label_seller.Text = LoginForm.sellerName;
            getProductTable();
            getReviewTable();
        }
        private void clear()
        {
            TextBox_category.Clear();
            TextBox_name.Clear();
            TextBox_description.Clear();
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox_category.Text) || string.IsNullOrEmpty(TextBox_name.Text) || string.IsNullOrEmpty(TextBox_description.Text))
            {
                MessageBox.Show("Please fill all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Corrected INSERT query with a new 'Seller' column
                string insertQuery = "INSERT INTO Review ( Name, Description, Seller,Category) VALUES( @Name, @Description, @Seller,@Category)";

                SqlCommand command = new SqlCommand(insertQuery, dBCon.GetCon());
                command.Parameters.AddWithValue("@Category", TextBox_category.Text);
                command.Parameters.AddWithValue("@Name", TextBox_name.Text);
                command.Parameters.AddWithValue("@Description", TextBox_description.Text);
                command.Parameters.AddWithValue("@Seller", LoginForm.sellerName);

                dBCon.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("REVIEW Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dBCon.CloseCon();
                getReviewTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView_reviewlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DataGridView_productdetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a valid row was clicked
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridView_productdetail.Rows[e.RowIndex];

                // Populate the text boxes with data from the clicked row
               TextBox_category.Text = row.Cells["ProdCat"].Value.ToString();
                TextBox_name.Text = row.Cells["ProdName"].Value.ToString();
            }
        }
        private void TextBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        
            getProductTable();
            getReviewTable();
            MessageBox.Show("Data refreshed successfully!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_BuyProd_Click(object sender, EventArgs e)
        {
            SellerSellingForm sellerSellingForm = new SellerSellingForm();
            sellerSellingForm.Show();
            this.Close();
        }
    }
       
    
}
