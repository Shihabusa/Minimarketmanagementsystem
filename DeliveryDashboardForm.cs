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
    public partial class DeliveryDashboardForm : Form
    {
        public DeliveryDashboardForm()
        {
            InitializeComponent();
        }
        private void DelivaryDashboard_LOad(object sender, EventArgs e)
        {
            getbilllistTable();
            labelDate.Text = DateTime.Today.ToShortDateString();
            getDeliveryStatusTable();
        }


        DBConnect dBCon = new DBConnect();
        private void getbilllistTable()
        {
            try
            {
                string selectQuerry = "SELECT * FROM Bill";
                SqlCommand command = new SqlCommand(selectQuerry, dBCon.GetCon());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataGridView_delivery.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DataGridView_delivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridView_delivery.Rows[e.RowIndex];
                TextBox_CnID.Text = row.Cells["BillId"].Value.ToString();
                TextBox_buyername.Text = row.Cells["SellerName"].Value.ToString(); // Assuming SellerName is used as the buyer name here
            }
        }
        private void getDeliveryStatusTable()
        {
            try
            {
                string selectQuery = "SELECT * FROM Delivery";
                SqlCommand command = new SqlCommand(selectQuery, dBCon.GetCon());
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                guna2DataGridView_deliverystatus.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading delivery status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();

        }

      

        private void button_x_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView_deliverystatus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // First, validate that the required text boxes are not empty
            if (string.IsNullOrEmpty(TextBox_CnID.Text) || string.IsNullOrEmpty(TextBox_buyername.Text) || string.IsNullOrEmpty(ComboBox_orderStatus.Text))
            {
                MessageBox.Show("Please select a bill and a delivery status.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Check if a record for this BillId already exists in the Delivery table
                string checkQuery = "SELECT COUNT(*) FROM Delivery WHERE BillId = @BillId";
                SqlCommand checkCmd = new SqlCommand(checkQuery, dBCon.GetCon());
                checkCmd.Parameters.AddWithValue("@BillId", TextBox_CnID.Text);

                dBCon.OpenCon();
                int recordCount = (int)checkCmd.ExecuteScalar();
                dBCon.CloseCon();

                if (recordCount > 0)
                {
                    // If a record exists, update the DeliveryStatus
                    string updateQuery = "UPDATE Delivery SET DeliveryStatus = @DeliveryStatus, Date = @Date WHERE BillId = @BillId";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, dBCon.GetCon());
                    updateCmd.Parameters.AddWithValue("@DeliveryStatus", ComboBox_orderStatus.Text);
                    updateCmd.Parameters.AddWithValue("@Date", labelDate.Text);
                    updateCmd.Parameters.AddWithValue("@BillId", TextBox_CnID.Text);

                    dBCon.OpenCon();
                    updateCmd.ExecuteNonQuery();
                    dBCon.CloseCon();

                    MessageBox.Show("Delivery status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // If no record exists, insert a new one
                    string insertQuery = "INSERT INTO Delivery (BillId, Buyer, DeliveryStatus, Date) VALUES (@BillId, @Buyer, @DeliveryStatus, @Date)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, dBCon.GetCon());
                    insertCmd.Parameters.AddWithValue("@BillId", TextBox_CnID.Text);
                    insertCmd.Parameters.AddWithValue("@Buyer", TextBox_buyername.Text);
                    insertCmd.Parameters.AddWithValue("@DeliveryStatus", ComboBox_orderStatus.Text);
                    insertCmd.Parameters.AddWithValue("@Date", labelDate.Text);

                    dBCon.OpenCon();
                    insertCmd.ExecuteNonQuery();
                    dBCon.CloseCon();

                    MessageBox.Show("Delivery record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Refresh the delivery status DataGridView
                getDeliveryStatusTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the delivery status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            getbilllistTable();
            getDeliveryStatusTable();
            MessageBox.Show("Data refreshed successfully!", "Refresh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
