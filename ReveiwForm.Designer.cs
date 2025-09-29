using System.Windows.Forms;

namespace Mini_Market_Management_System
{
    partial class ReveiwForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_product = new System.Windows.Forms.Label();
            this.DataGridView_productdetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button_add = new System.Windows.Forms.Button();
            this.TextBox_description = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_category = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_category = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.DataGridView_reviewlist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label_reviewprod = new System.Windows.Forms.Label();
            this.label_reviewdetails = new System.Windows.Forms.Label();
            this.label_seller = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.Button_BuyProd = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_productdetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_reviewlist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label_product);
            this.panel1.Controls.Add(this.DataGridView_productdetail);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.TextBox_description);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextBox_category);
            this.panel1.Controls.Add(this.label_category);
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.DataGridView_reviewlist);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.label_reviewprod);
            this.panel1.Controls.Add(this.label_reviewdetails);
            this.panel1.Controls.Add(this.label_seller);
            this.panel1.Location = new System.Drawing.Point(195, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 695);
            this.panel1.TabIndex = 36;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_product.ForeColor = System.Drawing.Color.White;
            this.label_product.Location = new System.Drawing.Point(696, 52);
            this.label_product.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(104, 35);
            this.label_product.TabIndex = 83;
            this.label_product.Text = "Products";
            // 
            // DataGridView_productdetail
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_productdetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_productdetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_productdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_productdetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_productdetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_productdetail.Location = new System.Drawing.Point(518, 109);
            this.DataGridView_productdetail.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView_productdetail.Name = "DataGridView_productdetail";
            this.DataGridView_productdetail.RowHeadersVisible = false;
            this.DataGridView_productdetail.RowHeadersWidth = 51;
            this.DataGridView_productdetail.Size = new System.Drawing.Size(395, 206);
            this.DataGridView_productdetail.TabIndex = 82;
            this.DataGridView_productdetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_productdetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_productdetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_productdetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_productdetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_productdetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_productdetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_productdetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_productdetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_productdetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_productdetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_productdetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_productdetail.ThemeStyle.HeaderStyle.Height = 23;
            this.DataGridView_productdetail.ThemeStyle.ReadOnly = false;
            this.DataGridView_productdetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_productdetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_productdetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_productdetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_productdetail.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView_productdetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_productdetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_productdetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_productdetail_CellClick);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.SkyBlue;
            this.button_add.FlatAppearance.BorderSize = 0;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(82, 331);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(117, 64);
            this.button_add.TabIndex = 81;
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
            this.TextBox_description.Location = new System.Drawing.Point(226, 238);
            this.TextBox_description.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_description.Name = "TextBox_description";
            this.TextBox_description.PlaceholderText = "";
            this.TextBox_description.SelectedText = "";
            this.TextBox_description.Size = new System.Drawing.Size(267, 44);
            this.TextBox_description.TabIndex = 78;
            this.TextBox_description.TextChanged += new System.EventHandler(this.TextBox_description_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 35);
            this.label4.TabIndex = 77;
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
            this.TextBox_name.Location = new System.Drawing.Point(227, 184);
            this.TextBox_name.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.PlaceholderText = "";
            this.TextBox_name.SelectedText = "";
            this.TextBox_name.Size = new System.Drawing.Size(267, 44);
            this.TextBox_name.TabIndex = 76;
            this.TextBox_name.TextChanged += new System.EventHandler(this.TextBox_name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 35);
            this.label3.TabIndex = 75;
            this.label3.Text = "Product Name";
            // 
            // TextBox_category
            // 
            this.TextBox_category.BorderRadius = 18;
            this.TextBox_category.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_category.DefaultText = "";
            this.TextBox_category.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_category.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_category.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_category.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_category.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_category.ForeColor = System.Drawing.Color.Black;
            this.TextBox_category.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_category.Location = new System.Drawing.Point(226, 130);
            this.TextBox_category.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_category.Name = "TextBox_category";
            this.TextBox_category.PlaceholderText = "";
            this.TextBox_category.SelectedText = "";
            this.TextBox_category.Size = new System.Drawing.Size(267, 44);
            this.TextBox_category.TabIndex = 74;
            this.TextBox_category.TextChanged += new System.EventHandler(this.TextBox_id_TextChanged);
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.ForeColor = System.Drawing.Color.White;
            this.label_category.Location = new System.Drawing.Point(41, 139);
            this.label_category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(190, 35);
            this.label_category.TabIndex = 73;
            this.label_category.Text = "Product Category";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(290, 52);
            this.label_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(75, 35);
            this.label_date.TabIndex = 72;
            this.label_date.Text = "Date: ";
            // 
            // DataGridView_reviewlist
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridView_reviewlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_reviewlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_reviewlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_reviewlist.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_reviewlist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_reviewlist.Location = new System.Drawing.Point(71, 459);
            this.DataGridView_reviewlist.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView_reviewlist.Name = "DataGridView_reviewlist";
            this.DataGridView_reviewlist.RowHeadersVisible = false;
            this.DataGridView_reviewlist.RowHeadersWidth = 51;
            this.DataGridView_reviewlist.Size = new System.Drawing.Size(517, 206);
            this.DataGridView_reviewlist.TabIndex = 71;
            this.DataGridView_reviewlist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_reviewlist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_reviewlist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_reviewlist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_reviewlist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_reviewlist.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_reviewlist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_reviewlist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_reviewlist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_reviewlist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_reviewlist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_reviewlist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_reviewlist.ThemeStyle.HeaderStyle.Height = 23;
            this.DataGridView_reviewlist.ThemeStyle.ReadOnly = false;
            this.DataGridView_reviewlist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_reviewlist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_reviewlist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_reviewlist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_reviewlist.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView_reviewlist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_reviewlist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_reviewlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_reviewlist_CellContentClick);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.PaleTurquoise;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(465, 405);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(114, 43);
            this.guna2Button1.TabIndex = 57;
            this.guna2Button1.Text = "REFRESH";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label_reviewprod
            // 
            this.label_reviewprod.AutoSize = true;
            this.label_reviewprod.Font = new System.Drawing.Font("Sitka Display", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reviewprod.ForeColor = System.Drawing.Color.White;
            this.label_reviewprod.Location = new System.Drawing.Point(166, 3);
            this.label_reviewprod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_reviewprod.Name = "label_reviewprod";
            this.label_reviewprod.Size = new System.Drawing.Size(299, 49);
            this.label_reviewprod.TabIndex = 15;
            this.label_reviewprod.Text = "REVIEW PRODUCT";
            // 
            // label_reviewdetails
            // 
            this.label_reviewdetails.AutoSize = true;
            this.label_reviewdetails.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_reviewdetails.ForeColor = System.Drawing.Color.White;
            this.label_reviewdetails.Location = new System.Drawing.Point(97, 413);
            this.label_reviewdetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_reviewdetails.Name = "label_reviewdetails";
            this.label_reviewdetails.Size = new System.Drawing.Size(160, 35);
            this.label_reviewdetails.TabIndex = 6;
            this.label_reviewdetails.Text = "ALL REVIEWS";
            // 
            // label_seller
            // 
            this.label_seller.AutoSize = true;
            this.label_seller.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_seller.ForeColor = System.Drawing.Color.White;
            this.label_seller.Location = new System.Drawing.Point(76, 52);
            this.label_seller.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_seller.Name = "label_seller";
            this.label_seller.Size = new System.Drawing.Size(138, 35);
            this.label_seller.TabIndex = 0;
            this.label_seller.Text = "Seller Name";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Red;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Location = new System.Drawing.Point(1057, 12);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(86, 36);
            this.guna2Button2.TabIndex = 84;
            this.guna2Button2.Text = "X";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Button_BuyProd
            // 
            this.Button_BuyProd.BorderRadius = 15;
            this.Button_BuyProd.BorderThickness = 1;
            this.Button_BuyProd.CustomizableEdges.BottomRight = false;
            this.Button_BuyProd.CustomizableEdges.TopRight = false;
            this.Button_BuyProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_BuyProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_BuyProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_BuyProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_BuyProd.FillColor = System.Drawing.Color.PaleTurquoise;
            this.Button_BuyProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_BuyProd.ForeColor = System.Drawing.Color.Black;
            this.Button_BuyProd.Location = new System.Drawing.Point(12, 409);
            this.Button_BuyProd.Name = "Button_BuyProd";
            this.Button_BuyProd.Size = new System.Drawing.Size(185, 62);
            this.Button_BuyProd.TabIndex = 85;
            this.Button_BuyProd.Text = "Buy Product";
            this.Button_BuyProd.Click += new System.EventHandler(this.Button_BuyProd_Click);
            // 
            // ReveiwForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 753);
            this.Controls.Add(this.Button_BuyProd);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReveiwForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReveiwForm";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_productdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_reviewlist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_date;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_reviewlist;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label_reviewprod;
        private System.Windows.Forms.Label label_reviewdetails;
        private System.Windows.Forms.Label label_seller;
        private System.Windows.Forms.Button button_add;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_description;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_category;
        private System.Windows.Forms.Label label_category;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_productdetail;
        private System.Windows.Forms.Label label_product;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button Button_BuyProd;
    }
}