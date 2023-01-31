//----------------------------------
//-- Creator : MrMohande3 Khademi --
//----------------------------------

using DesignPattern.CustomerProject.AdoDAL;
using DesignPattern.CustomerProject.DomainLayer;
using DesignPattern.CustomerProject.InterfaceLayer;
using DesignPattern.CustomerProject.ValidationAlgorithmLayer;

namespace DesignPattern.CustomerProject.FactoryLayer
{
    public enum ETypeOfData
    {
        Customer = 0,
        Lead = 1,
        CustomerAdo = 2
    }

    public static class FactoryCustomer<T>
    {

        private static Dictionary<ETypeOfData, object> _userTypes =
            new Dictionary<ETypeOfData, object>();

        public static T Create(ETypeOfData type = ETypeOfData.Customer)
        {
            
            if (_userTypes.Count == 0)
            {
                _userTypes.Add(ETypeOfData.Customer, new Customer(new CustomerValidationAll()));
                _userTypes.Add(ETypeOfData.Lead, new Lead(new LeadValidation()));
                _userTypes.Add(ETypeOfData.CustomerAdo, new CustomerDAL());
            }
            return (T)_userTypes[type];
        }
    }
}
