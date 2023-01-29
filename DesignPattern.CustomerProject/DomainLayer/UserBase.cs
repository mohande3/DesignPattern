using DesignPattern.CustomerProject.InterfaceLayer;

namespace DesignPattern.CustomerProject.DomainLayer
{
    public class UserBase : ICustomer
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Addess { get; set; }

        public void IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
