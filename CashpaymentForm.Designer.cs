namespace Mini_Market_Management_System
{
    partial class CashpaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashpaymentForm));
            this.button_x = new Guna.UI2.WinForms.Guna2Button();
            this.label_payableAmt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox_amount = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button_pay = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Rs = new System.Windows.Forms.Label();
            this.label_buyer = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.button_x.Location = new System.Drawing.Point(486, 12);
            this.button_x.Name = "button_x";
            this.button_x.Size = new System.Drawing.Size(80, 33);
            this.button_x.TabIndex = 71;
            this.button_x.Text = "X";
            this.button_x.Click += new System.EventHandler(this.button_x_Click);
            // 
            // label_payableAmt
            // 
            this.label_payableAmt.AutoSize = true;
            this.label_payableAmt.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_payableAmt.Location = new System.Drawing.Point(45, 189);
            this.label_payableAmt.Name = "label_payableAmt";
            this.label_payableAmt.Size = new System.Drawing.Size(248, 38);
            this.label_payableAmt.TabIndex = 72;
            this.label_payableAmt.Text = "Payable Amount:";
            this.label_payableAmt.Click += new System.EventHandler(this.label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 38);
            this.label1.TabIndex = 73;
            this.label1.Text = "Amount given:";
            // 
            // guna2TextBox_amount
            // 
            this.guna2TextBox_amount.BorderRadius = 15;
            this.guna2TextBox_amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox_amount.DefaultText = "";
            this.guna2TextBox_amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox_amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox_amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_amount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox_amount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_amount.Location = new System.Drawing.Point(275, 268);
            this.guna2TextBox_amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox_amount.Name = "guna2TextBox_amount";
            this.guna2TextBox_amount.PlaceholderText = "";
            this.guna2TextBox_amount.SelectedText = "";
            this.guna2TextBox_amount.Size = new System.Drawing.Size(270, 48);
            this.guna2TextBox_amount.TabIndex = 74;
            this.guna2TextBox_amount.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // Button_pay
            // 
            this.Button_pay.BorderRadius = 15;
            this.Button_pay.BorderThickness = 1;
            this.Button_pay.CustomizableEdges.BottomLeft = false;
            this.Button_pay.CustomizableEdges.BottomRight = false;
            this.Button_pay.CustomizableEdges.TopLeft = false;
            this.Button_pay.CustomizableEdges.TopRight = false;
            this.Button_pay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_pay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_pay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_pay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_pay.FillColor = System.Drawing.Color.Red;
            this.Button_pay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_pay.ForeColor = System.Drawing.Color.Black;
            this.Button_pay.Location = new System.Drawing.Point(195, 357);
            this.Button_pay.Name = "Button_pay";
            this.Button_pay.Size = new System.Drawing.Size(152, 41);
            this.Button_pay.TabIndex = 76;
            this.Button_pay.Text = "Pay";
            this.Button_pay.Click += new System.EventHandler(this.Button_pay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(174, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 38);
            this.label2.TabIndex = 77;
            this.label2.Text = "Cash Payment";
            // 
            // label_Rs
            // 
            this.label_Rs.AutoSize = true;
            this.label_Rs.Location = new System.Drawing.Point(401, 199);
            this.label_Rs.Name = "label_Rs";
            this.label_Rs.Size = new System.Drawing.Size(35, 28);
            this.label_Rs.TabIndex = 78;
            this.label_Rs.Text = "RS";
            this.label_Rs.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_buyer
            // 
            this.label_buyer.AutoSize = true;
            this.label_buyer.Location = new System.Drawing.Point(82, 56);
            this.label_buyer.Name = "label_buyer";
            this.label_buyer.Size = new System.Drawing.Size(61, 28);
            this.label_buyer.TabIndex = 79;
            this.label_buyer.Text = "Buyer";
            this.label_buyer.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(358, 56);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(58, 28);
            this.label_date.TabIndex = 80;
            this.label_date.Text = "DATE";
            this.label_date.Click += new System.EventHandler(this.label5_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 12;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(103, 118);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(75, 48);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 81;
            this.guna2PictureBox1.TabStop = false;
            // 
            // CashpaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(578, 459);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_buyer);
            this.Controls.Add(this.label_Rs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Button_pay);
            this.Controls.Add(this.guna2TextBox_amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_payableAmt);
            this.Controls.Add(this.button_x);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CashpaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashpaymentForm";
            this.Load += new System.EventHandler(this.CashpaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button button_x;
        private System.Windows.Forms.Label label_payableAmt;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_amount;
        private Guna.UI2.WinForms.Guna2Button Button_pay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Rs;
        private System.Windows.Forms.Label label_buyer;
        private System.Windows.Forms.Label label_date;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}