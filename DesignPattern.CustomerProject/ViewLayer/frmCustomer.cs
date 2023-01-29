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
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbTypeCustomer.Text == "Lead")
            {
                var oUser = new Lead();
                oUser.Name = txtName.Text;
                oUser.PhoneNumber = txtPhone.Text;
                oUser.BillAmount = string.IsNullOrEmpty(txtBillAmount.Text) ? 0 :
                    decimal.Parse(txtBillAmount.Text);
                oUser.Addess = txtAddress.Text;
                oUser.BillDate = DateTime.Now;
                try
                {
                    oUser.IsValid();
                    MessageBox.Show("Valid");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Not Valid A Lead : {ex.Message}");
                }
            }
            else
            {
                var oUser = new Customer();
                oUser.Name = txtName.Text;
                oUser.PhoneNumber = txtPhone.Text;
                oUser.BillAmount = string.IsNullOrEmpty(txtBillAmount.Text) ? 0 :
                    decimal.Parse(txtBillAmount.Text);
                oUser.Addess = txtAddress.Text;
                oUser.BillDate = DateTime.Now;
                try
                {
                    oUser.IsValid();
                    MessageBox.Show("Valid");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Not Valid A Customer : {ex.Message}");
                }
            }
        }
    }
}
