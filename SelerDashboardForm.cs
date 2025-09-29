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
    public partial class SelerDashboardForm : Form
    {
        DBConnect dBCon = new DBConnect();
        public SelerDashboardForm()
        {
            InitializeComponent();
        }
        private void SelerDashboardForm_Load(object sender, EventArgs e)
        {
            label_date.Text = DateTime.Today.ToShortDateString();
            label_seller.Text = LoginForm.sellerName;
           
            getSellTable();
            getReviewTable();
            getDeliveryTable();

        }
        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void getSellTable()
        {
            try
            {
                // Use a parameterized query to filter by the logged-in seller's name.
                string selectQuerry = "SELECT * FROM Bill WHERE SellerName = @SellerName";

                SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());

                // Add the parameter for the seller's name.
                command.Parameters.AddWithValue("@SellerName", LoginForm.sellerName);

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

        private void getReviewTable()
        {
            string selectQuerry = "SELECT Id, Name,Description,Category FROM Review  WHERE Seller = @SellerName";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            command.Parameters.AddWithValue("@SellerName", LoginForm.sellerName);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView_reviewlist.DataSource = table;
        }
        private void getDeliveryTable()
        {
            string selectQuerry = "SELECT Id,BillId,DeliveryStatus,Date FROM Delivery  WHERE Buyer = @SellerName";
            SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
            command.Parameters.AddWithValue("@SellerName", LoginForm.sellerName);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            guna2DataGridView1.DataSource = table;
        }

        private void Button_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button_buyproduct_Click(object sender, EventArgs e)
        {
            SellerSellingForm sellingForm = new SellerSellingForm();
            sellingForm.Show();
            this.Hide();
        }

        private void DataGridView_sellList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
