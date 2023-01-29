//----------------------------------
//-- Creator : MrMohande3 Khademi --
//----------------------------------

using DesignPattern.CustomerProject.DomainLayer;
using DesignPattern.CustomerProject.InterfaceLayer;

namespace DesignPattern.CustomerProject.FactoryLayer
{
    public static class FactoryCustomer
    {
        private static Dictionary<string, ICustomer> _userTypes =
            new Dictionary<string, ICustomer>();

        public static ICustomer Create(string userType = "customer")
        {
            if (_userTypes.Count == 0)
            {
                _userTypes.Add("customer", new Customer());
                _userTypes.Add("lead", new Lead());
            }
            return _userTypes[userType];
        }
    }
}
