using DesignPattern.CustomerProject.DomainLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPattern.CustomerProject.ViewLayer
{
    public partial class frmCustomer : Form
    {
        private UserBase _user = null;
        public frmCustomer()
        {
            InitializeComponent();
            _user = new Customer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _user.Name = txtName.Text;
            _user.PhoneNumber = txtPhone.Text;
            _user.BillAmount = string.IsNullOrEmpty(txtBillAmount.Text) ? 0 :
                decimal.Parse(txtBillAmount.Text);
            _user.Addess = txtAddress.Text;
            _user.BillDate = DateTime.Now;
            try
            {
                _user.IsValid();
                MessageBox.Show("Valid");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Not Valid A Lead : {ex.Message}");
            }
        }

        private void cmbTypeCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTypeCustomer.Text == "Customer")
            {
                _user = new Customer();
            }
            else
            {
                _user = new Lead();
            }
        }
    }
}
