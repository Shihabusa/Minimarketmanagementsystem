using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Market_Management_System
{
    public partial class Payment : Form
    {
        DBConnect DBConnect = new DBConnect();
        public Payment()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CashpaymentForm cash = new CashpaymentForm();
            cash.Show();
            this.Close();
        }

        private void Button_debitcard_Click(object sender, EventArgs e)
        {
            CardPaymentForm cashpaymentForm = new CardPaymentForm();
            cashpaymentForm.Show();
            this.Close();
        }

        private void button_x_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }
    }
}
