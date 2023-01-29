//----------------------------------
//-- Creator : MrMohande3 Khademi --
//----------------------------------

using DesignPattern.CustomerProject.InterfaceLayer;

namespace DesignPattern.CustomerProject.ViewLayer
{
    public partial class frmCustomer : Form
    {
        private ICustomer _user = null;
        public frmCustomer()
        {
            InitializeComponent();
            _user = FactoryLayer.FactoryCustomer.Create();
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
            _user = FactoryLayer.FactoryCustomer.Create(cmbTypeCustomer.Text);
        }
    }
}
