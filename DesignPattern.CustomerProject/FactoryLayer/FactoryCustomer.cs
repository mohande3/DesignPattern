//----------------------------------
//-- Creator : MrMohande3 Khademi --
//----------------------------------

using DesignPattern.CustomerProject.DomainLayer;

namespace DesignPattern.CustomerProject.FactoryLayer
{
    public static class FactoryCustomer
    {
        private static Dictionary<string, UserBase> _userTypes =
            new Dictionary<string, UserBase>();
        public static UserBase Create(string userType = "customer")
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
