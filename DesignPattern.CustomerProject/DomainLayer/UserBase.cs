using DesignPattern.CustomerProject.InterfaceLayer;

namespace DesignPattern.CustomerProject.DomainLayer
{
    public class UserBase : ICustomer
    {
        private IValidation<ICustomer> _validation;
        public string Name { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public decimal BillAmount { get; set; } = 0;
        public DateTime BillDate { get; set; } = DateTime.Now;
        public string Addess { get; set; } = "";

        public UserBase(IValidation<ICustomer> validation)
        {
            _validation = validation;
        }

        public void IsValid()
        {
            _validation.IsValid(this);
        }
    }
}
