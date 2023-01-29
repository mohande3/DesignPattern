//----------------------------------
//-- Creator : MrMohande3 Khademi --
//----------------------------------

using DesignPattern.CustomerProject.DomainLayer;

namespace DesignPattern.CustomerProject.FactoryLayer
{
    public static class FactoryCustomer
    {
        public static UserBase Create(string userType = "customer")
        {
            if (userType.Trim().ToLower() == "customer")
            {
                return new Customer();
            }
            else
            {
                return new Lead();
            }
        }
    }
}
