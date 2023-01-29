//----------------------------------
//-- Creator : MrMohande3 Khademi --
//----------------------------------

using DesignPattern.CustomerProject.DomainLayer;

namespace DesignPattern.CustomerProject.FactoryLayer
{
    public static class FactoryCustomer
    {
        private static Dictionary<string, UserBase> _userTypes;
        static FactoryCustomer()
        {
            _userTypes = new Dictionary<string, UserBase>();
            _userTypes.Add("customer", new Customer());
            _userTypes.Add("lead", new Lead());
        }
        public static UserBase Create(string userType = "customer")
        {
            return _userTypes[userType];
        }
    }
}
