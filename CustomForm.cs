using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Mini_Market_Management_System
{
    public partial class CustomForm : Form
    {
        DBConnect dbConnect = new DBConnect();
        SqlCommand command = new SqlCommand();

        public CustomForm()
        {
            InitializeComponent();
            LoadCategory();
            LoadShoeType();
            LoadMaterial();
        }

        // CATEGORY SECTION
        public void LoadCategory()
        {
            try
            {
                DataGridView_category.Rows.Clear();
                int i = 0;
                dbConnect.OpenCon();
                command = new SqlCommand("SELECT * FROM CustomName", dbConnect.GetCon());

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        i++;
                        DataGridView_category.Rows.Add(i, reader["Id"].ToString(), reader["catName"].ToString());
                    }
                } // Reader is automatically closed here

                dbConnect.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dbConnect.CloseCon(); // Ensure connection is closed even if error occurs
            }
        }

        private void button_addcatname_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_CnID.Text == "" || TextBox_name.Text == "")
                {
                    MessageBox.Show("Missing information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dbConnect.OpenCon();
                command = new SqlCommand("INSERT INTO CustomName (Id, catName) VALUES (@Id, @catName)", dbConnect.GetCon());
                command.Parameters.AddWithValue("@Id", TextBox_CnID.Text);
                command.Parameters.AddWithValue("@catName", TextBox_name.Text);
                command.ExecuteNonQuery();
                dbConnect.CloseCon();
                MessageBox.Show("Category added successfully");
                LoadCategory();
                ClearCategoryFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_updatecatname_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_CnID.Text == "" || TextBox_name.Text == "")
                {
                    MessageBox.Show("Missing information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dbConnect.OpenCon();
                command = new SqlCommand("UPDATE CustomName SET catName=@catName WHERE Id=@Id", dbConnect.GetCon());
                command.Parameters.AddWithValue("@Id", TextBox_CnID.Text);
                command.Parameters.AddWithValue("@catName", TextBox_name.Text);
                command.ExecuteNonQuery();
                dbConnect.CloseCon();
                MessageBox.Show("Category updated successfully");
                LoadCategory();
                ClearCategoryFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_deletecatname_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_CnID.Text == "")
                {
                    MessageBox.Show("Select a category to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this category?", "Delete Record",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbConnect.OpenCon();
                    command = new SqlCommand("DELETE FROM CustomName WHERE Id=@Id", dbConnect.GetCon());
                    command.Parameters.AddWithValue("@Id", TextBox_CnID.Text);
                    command.ExecuteNonQuery();
                    dbConnect.CloseCon();
                    MessageBox.Show("Category deleted successfully");
                    LoadCategory();
                    ClearCategoryFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only handle valid row clicks (not header clicks)
            if (e.RowIndex >= 0 && e.RowIndex < DataGridView_category.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow row = DataGridView_category.Rows[e.RowIndex];

                // Safely get cell values with null checking
                if (row.Cells[1].Value != null)
                    TextBox_CnID.Text = row.Cells[1].Value.ToString();
                else
                    TextBox_CnID.Text = "";

                if (row.Cells[2].Value != null)
                    TextBox_name.Text = row.Cells[2].Value.ToString();
                else
                    TextBox_name.Text = "";
            }
        }
        private void ClearCategoryFields()
        {
            TextBox_CnID.Clear();
            TextBox_name.Clear();
        }

        // SHOE TYPE SECTION
        public void LoadShoeType()
        {
            try
            {
                guna2DataGridView1.Rows.Clear();
                int i = 0;
                dbConnect.OpenCon();
                command = new SqlCommand("SELECT * FROM CustomType", dbConnect.GetCon());

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        i++;
                        guna2DataGridView1.Rows.Add(i, reader["Id"].ToString(), reader["shoetype"].ToString(), reader["hight"].ToString());
                    }
                } // Reader is automatically closed here

                dbConnect.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dbConnect.CloseCon();
            }
        }

        private void button_AddShoetype_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_StID.Text == "" || TextBox_Shoetype.Text == "" || TextBox_shoehight.Text == "")
                {
                    MessageBox.Show("Missing information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dbConnect.OpenCon();
                command = new SqlCommand("INSERT INTO CustomType (Id, shoetype, hight) VALUES (@Id, @shoetype, @hight)", dbConnect.GetCon());
                command.Parameters.AddWithValue("@Id", TextBox_StID.Text);
                command.Parameters.AddWithValue("@shoetype", TextBox_Shoetype.Text);
                command.Parameters.AddWithValue("@hight", TextBox_shoehight.Text);
                command.ExecuteNonQuery();
                dbConnect.CloseCon();
                MessageBox.Show("Shoe type added successfully");
                LoadShoeType();
                ClearShoeTypeFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_UpdateShoetype_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_StID.Text == "" || TextBox_Shoetype.Text == "" || TextBox_shoehight.Text == "")
                {
                    MessageBox.Show("Missing information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dbConnect.OpenCon();
                command = new SqlCommand("UPDATE CustomType SET shoetype=@shoetype, hight=@hight WHERE Id=@Id", dbConnect.GetCon());
                command.Parameters.AddWithValue("@Id", TextBox_StID.Text);
                command.Parameters.AddWithValue("@shoetype", TextBox_Shoetype.Text);
                command.Parameters.AddWithValue("@hight", TextBox_shoehight.Text);
                command.ExecuteNonQuery();
                dbConnect.CloseCon();
                MessageBox.Show("Shoe type updated successfully");
                LoadShoeType();
                ClearShoeTypeFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_DeleteShoetype_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_StID.Text == "")
                {
                    MessageBox.Show("Select a shoe type to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this shoe type?", "Delete Record",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbConnect.OpenCon();
                    command = new SqlCommand("DELETE FROM CustomType WHERE Id=@Id", dbConnect.GetCon());
                    command.Parameters.AddWithValue("@Id", TextBox_StID.Text);
                    command.ExecuteNonQuery();
                    dbConnect.CloseCon();
                    MessageBox.Show("Shoe type deleted successfully");
                    LoadShoeType();
                    ClearShoeTypeFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only handle valid row clicks (not header clicks which have RowIndex = -1)
            if (e.RowIndex >= 0 && e.RowIndex < guna2DataGridView1.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

                // Safely get cell values with null checking
                TextBox_StID.Text = row.Cells[1]?.Value?.ToString() ?? "";
                TextBox_Shoetype.Text = row.Cells[2]?.Value?.ToString() ?? "";
                TextBox_shoehight.Text = row.Cells[3]?.Value?.ToString() ?? "";
            }
        }

        private void ClearShoeTypeFields()
        {
            TextBox_StID.Clear();
            TextBox_Shoetype.Clear();
            TextBox_shoehight.Clear();
        }

        // MATERIAL SECTION
        public void LoadMaterial()
        {
            try
            {
                guna2DataGridView2.Rows.Clear();
                int i = 0;
                dbConnect.OpenCon();
                command = new SqlCommand("SELECT * FROM Custommaterial", dbConnect.GetCon());

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        i++;
                        guna2DataGridView2.Rows.Add(i, reader["Id"].ToString(), reader["Material"].ToString(), reader["price"].ToString());
                    }
                }

                dbConnect.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dbConnect.CloseCon();
            }
        }

        private void button_AddShoematerial_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_PmID.Text == "" || TextBox_productmaterial.Text == "" || TextBox_Materialprice.Text == "")
                {
                    MessageBox.Show("Please enter all material information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dbConnect.OpenCon();
                command = new SqlCommand("INSERT INTO Custommaterial (Id, Material, price) VALUES (@Id, @Material, @Price)", dbConnect.GetCon());
                command.Parameters.AddWithValue("@Id", TextBox_PmID.Text);
                command.Parameters.AddWithValue("@Material", TextBox_productmaterial.Text);
                command.Parameters.AddWithValue("@Price", TextBox_Materialprice.Text);
                command.ExecuteNonQuery();
                dbConnect.CloseCon();
                MessageBox.Show("Material added successfully");
                LoadMaterial();
                ClearMaterialFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding material: " + ex.Message);
            }
        }

        private void button_UpdateShoematerial_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_PmID.Text == "" || TextBox_productmaterial.Text == "" || TextBox_Materialprice.Text == "")
                {
                    MessageBox.Show("Please enter all material information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dbConnect.OpenCon();
                command = new SqlCommand("UPDATE Custommaterial SET Material=@Material, price=@Price WHERE Id=@Id", dbConnect.GetCon());
                command.Parameters.AddWithValue("@Id", TextBox_PmID.Text);
                command.Parameters.AddWithValue("@Material", TextBox_productmaterial.Text);
                command.Parameters.AddWithValue("@Price", TextBox_Materialprice.Text);
                command.ExecuteNonQuery();
                dbConnect.CloseCon();
                MessageBox.Show("Material updated successfully");
                LoadMaterial();
                ClearMaterialFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating material: " + ex.Message);
            }
        }

        private void button_DeleteShoematerial_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_PmID.Text == "")
                {
                    MessageBox.Show("Select a material to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this material?", "Delete Record",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dbConnect.OpenCon();
                    command = new SqlCommand("DELETE FROM Custommaterial WHERE Id=@Id", dbConnect.GetCon());
                    command.Parameters.AddWithValue("@Id", TextBox_PmID.Text);
                    command.ExecuteNonQuery();
                    dbConnect.CloseCon();
                    MessageBox.Show("Material deleted successfully");
                    LoadMaterial();
                    ClearMaterialFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Only handle valid row clicks (not header clicks which have RowIndex = -1)
            if (e.RowIndex >= 0 && e.RowIndex < guna2DataGridView2.Rows.Count)
            {
                // Get the selected row
                DataGridViewRow row = guna2DataGridView2.Rows[e.RowIndex];

                // Safely get cell values with null checking
                TextBox_PmID.Text = row.Cells[1]?.Value?.ToString() ?? "";
                TextBox_productmaterial.Text = row.Cells[2]?.Value?.ToString() ?? "";
                TextBox_Materialprice.Text = row.Cells[3]?.Value?.ToString() ?? "";
            }
        }
        private void ClearMaterialFields()
        {
            TextBox_PmID.Clear();
            TextBox_productmaterial.Clear();
            TextBox_Materialprice.Clear();
        }
        // REFRESH BUTTON
        private void button_refresh_Click(object sender, EventArgs e)
        {
            LoadCategory();
            LoadShoeType();
            LoadMaterial();
            ClearCategoryFields();
            ClearShoeTypeFields();
            ClearMaterialFields();
        }

        // NAVIGATION AND OTHER BUTTONS
      
       

        
        // Remove these problematic methods or implement them properly:
      

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

       

        private void TextBox_Materialprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_seller_Click_1(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }

        private void button_product_Click_1(object sender, EventArgs e)
        {
            ProductForm pr = new ProductForm();
            pr.Show();
            this.Hide();
        }

        private void button_selling_Click_1(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button_x_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button_refresh_Click_1(object sender, EventArgs e)
        {
            LoadCategory();
            LoadShoeType();
            LoadMaterial();
            ClearCategoryFields();
            ClearShoeTypeFields();
            ClearMaterialFields();
        }
    }
}