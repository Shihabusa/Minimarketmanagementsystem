
namespace Mini_Market_Management_System
{
    partial class CategoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.TextBox_description = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridView_category = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button_seller = new Guna.UI2.WinForms.Guna2Button();
            this.button_product = new Guna.UI2.WinForms.Guna2Button();
            this.button_selling = new Guna.UI2.WinForms.Guna2Button();
            this.button_dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.button_customprod = new Guna.UI2.WinForms.Guna2Button();
            this.button_x = new Guna.UI2.WinForms.Guna2Button();
            this.Button_logout = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_category)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(495, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(354, 49);
            this.label6.TabIndex = 15;
            this.label6.Text = "MANAGE CATEGORIES";
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(317, 327);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(117, 64);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Chartreuse;
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(181, 327);
            this.button_update.Margin = new System.Windows.Forms.Padding(4);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(117, 64);
            this.button_update.TabIndex = 11;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.SkyBlue;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button_add.Location = new System.Drawing.Point(45, 327);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(117, 64);
            this.button_add.TabIndex = 11;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // TextBox_description
            // 
            this.TextBox_description.BorderRadius = 18;
            this.TextBox_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_description.DefaultText = "";
            this.TextBox_description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_description.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_description.ForeColor = System.Drawing.Color.Black;
            this.TextBox_description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_description.Location = new System.Drawing.Point(171, 234);
            this.TextBox_description.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_description.Name = "TextBox_description";
            this.TextBox_description.PlaceholderText = "";
            this.TextBox_description.SelectedText = "";
            this.TextBox_description.Size = new System.Drawing.Size(267, 44);
            this.TextBox_description.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // TextBox_name
            // 
            this.TextBox_name.BorderRadius = 18;
            this.TextBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_name.DefaultText = "";
            this.TextBox_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_name.ForeColor = System.Drawing.Color.Black;
            this.TextBox_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Location = new System.Drawing.Point(171, 180);
            this.TextBox_name.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.PlaceholderText = "";
            this.TextBox_name.SelectedText = "";
            this.TextBox_name.Size = new System.Drawing.Size(267, 44);
            this.TextBox_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // TextBox_id
            // 
            this.TextBox_id.BorderRadius = 18;
            this.TextBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_id.DefaultText = "";
            this.TextBox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_id.ForeColor = System.Drawing.Color.Black;
            this.TextBox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Location = new System.Drawing.Point(171, 126);
            this.TextBox_id.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PlaceholderText = "";
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.Size = new System.Drawing.Size(267, 44);
            this.TextBox_id.TabIndex = 1;
            this.TextBox_id.TextChanged += new System.EventHandler(this.TextBox_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.DataGridView_category);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.TextBox_description);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(212, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 748);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DataGridView_category
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_category.ColumnHeadersHeight = 24;
            this.DataGridView_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_category.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_category.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_category.Location = new System.Drawing.Point(449, 126);
            this.DataGridView_category.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView_category.Name = "DataGridView_category";
            this.DataGridView_category.RowHeadersVisible = false;
            this.DataGridView_category.RowHeadersWidth = 51;
            this.DataGridView_category.Size = new System.Drawing.Size(775, 612);
            this.DataGridView_category.TabIndex = 16;
            this.DataGridView_category.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_category.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_category.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_category.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_category.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_category.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_category.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_category.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_category.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_category.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_category.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_category.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_category.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_category.ThemeStyle.ReadOnly = false;
            this.DataGridView_category.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_category.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_category.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_category.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_category.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView_category.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_category.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_category.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_category_CellContentClick);
            this.DataGridView_category.Click += new System.EventHandler(this.DataGridView_category_Click);
            // 
            // button_seller
            // 
            this.button_seller.BorderRadius = 15;
            this.button_seller.BorderThickness = 1;
            this.button_seller.CustomizableEdges.BottomRight = false;
            this.button_seller.CustomizableEdges.TopRight = false;
            this.button_seller.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_seller.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_seller.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_seller.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_seller.FillColor = System.Drawing.Color.PaleTurquoise;
            this.button_seller.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_seller.ForeColor = System.Drawing.Color.Black;
            this.button_seller.Location = new System.Drawing.Point(32, 76);
            this.button_seller.Name = "button_seller";
            this.button_seller.Size = new System.Drawing.Size(180, 45);
            this.button_seller.TabIndex = 17;
            this.button_seller.Text = "SELLER";
            this.button_seller.Click += new System.EventHandler(this.button_seller_Click_1);
            // 
            // button_product
            // 
            this.button_product.BorderRadius = 15;
            this.button_product.BorderThickness = 1;
            this.button_product.CustomizableEdges.BottomRight = false;
            this.button_product.CustomizableEdges.TopRight = false;
            this.button_product.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_product.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_product.FillColor = System.Drawing.Color.PaleTurquoise;
            this.button_product.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_product.ForeColor = System.Drawing.Color.Black;
            this.button_product.Location = new System.Drawing.Point(32, 157);
            this.button_product.Name = "button_product";
            this.button_product.Size = new System.Drawing.Size(180, 45);
            this.button_product.TabIndex = 30;
            this.button_product.Text = "PRODUCT";
            this.button_product.Click += new System.EventHandler(this.button_product_Click_1);
            // 
            // button_selling
            // 
            this.button_selling.BorderRadius = 15;
            this.button_selling.BorderThickness = 1;
            this.button_selling.CustomizableEdges.BottomRight = false;
            this.button_selling.CustomizableEdges.TopRight = false;
            this.button_selling.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_selling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_selling.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_selling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_selling.FillColor = System.Drawing.Color.PaleTurquoise;
            this.button_selling.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selling.ForeColor = System.Drawing.Color.Black;
            this.button_selling.Location = new System.Drawing.Point(33, 241);
            this.button_selling.Name = "button_selling";
            this.button_selling.Size = new System.Drawing.Size(180, 45);
            this.button_selling.TabIndex = 31;
            this.button_selling.Text = "SELLING";
            this.button_selling.Click += new System.EventHandler(this.button_selling_Click_1);
            // 
            // button_dashboard
            // 
            this.button_dashboard.BorderRadius = 15;
            this.button_dashboard.BorderThickness = 1;
            this.button_dashboard.CustomizableEdges.BottomRight = false;
            this.button_dashboard.CustomizableEdges.TopRight = false;
            this.button_dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_dashboard.FillColor = System.Drawing.Color.PaleTurquoise;
            this.button_dashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dashboard.ForeColor = System.Drawing.Color.Black;
            this.button_dashboard.Location = new System.Drawing.Point(34, 324);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Size = new System.Drawing.Size(180, 45);
            this.button_dashboard.TabIndex = 32;
            this.button_dashboard.Text = "DASHBOARD";
            this.button_dashboard.Click += new System.EventHandler(this.button_dashboard_Click);
            // 
            // button_customprod
            // 
            this.button_customprod.BorderRadius = 15;
            this.button_customprod.BorderThickness = 1;
            this.button_customprod.CustomizableEdges.BottomRight = false;
            this.button_customprod.CustomizableEdges.TopRight = false;
            this.button_customprod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_customprod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_customprod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_customprod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_customprod.FillColor = System.Drawing.Color.PaleTurquoise;
            this.button_customprod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_customprod.ForeColor = System.Drawing.Color.Black;
            this.button_customprod.Location = new System.Drawing.Point(34, 408);
            this.button_customprod.Name = "button_customprod";
            this.button_customprod.Size = new System.Drawing.Size(180, 62);
            this.button_customprod.TabIndex = 33;
            this.button_customprod.Text = "CUSTOM PRODUCT ADD";
            this.button_customprod.Click += new System.EventHandler(this.button_customprod_Click);
            // 
            // button_x
            // 
            this.button_x.BorderRadius = 15;
            this.button_x.BorderThickness = 1;
            this.button_x.CustomizableEdges.BottomLeft = false;
            this.button_x.CustomizableEdges.BottomRight = false;
            this.button_x.CustomizableEdges.TopLeft = false;
            this.button_x.CustomizableEdges.TopRight = false;
            this.button_x.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_x.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_x.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_x.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_x.FillColor = System.Drawing.Color.Red;
            this.button_x.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_x.ForeColor = System.Drawing.Color.Black;
            this.button_x.Location = new System.Drawing.Point(1371, 1);
            this.button_x.Name = "button_x";
            this.button_x.Size = new System.Drawing.Size(80, 34);
            this.button_x.TabIndex = 34;
            this.button_x.Text = "X";
            this.button_x.Click += new System.EventHandler(this.button_x_Click);
            // 
            // Button_logout
            // 
            this.Button_logout.BorderRadius = 18;
            this.Button_logout.FillColor = System.Drawing.Color.Red;
            this.Button_logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_logout.ForeColor = System.Drawing.Color.Black;
            this.Button_logout.Location = new System.Drawing.Point(34, 720);
            this.Button_logout.Margin = new System.Windows.Forms.Padding(4);
            this.Button_logout.Name = "Button_logout";
            this.Button_logout.Size = new System.Drawing.Size(134, 43);
            this.Button_logout.TabIndex = 63;
            this.Button_logout.Text = "LOGOUT";
            this.Button_logout.Click += new System.EventHandler(this.Button_logout_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 800);
            this.Controls.Add(this.Button_logout);
            this.Controls.Add(this.button_x);
            this.Controls.Add(this.button_customprod);
            this.Controls.Add(this.button_dashboard);
            this.Controls.Add(this.button_selling);
            this.Controls.Add(this.button_product);
            this.Controls.Add(this.button_seller);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_category)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_description;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_category;
        private Guna.UI2.WinForms.Guna2Button button_seller;
        private Guna.UI2.WinForms.Guna2Button button_product;
        private Guna.UI2.WinForms.Guna2Button button_selling;
        private Guna.UI2.WinForms.Guna2Button button_dashboard;
        private Guna.UI2.WinForms.Guna2Button button_customprod;
        private Guna.UI2.WinForms.Guna2Button button_x;
        private Guna.UI2.WinForms.Guna2Button Button_logout;
    }
}