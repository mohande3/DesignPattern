//----------------------------------
//-- Creator : MrMohande3 Khademi --
//----------------------------------

using DesignPattern.CustomerProject.DomainLayer;
using DesignPattern.CustomerProject.InterfaceLayer;
using DesignPattern.CustomerProject.ValidationAlgorithmLayer;

namespace DesignPattern.CustomerProject.FactoryLayer
{
    public static class FactoryCustomer
    {
        private static Dictionary<string, ICustomer> _userTypes =
            new Dictionary<string, ICustomer>();

        public static ICustomer Create(string userType = "customer")
        {
            userType = userType.ToLower().Trim();
            if (_userTypes.Count == 0)
            {
                _userTypes.Add("customer", new Customer(new CustomerValidationAll()));
                _userTypes.Add("lead", new Lead(new LeadValidation()));
            }
            return _userTypes[userType];
        }
    }
}
