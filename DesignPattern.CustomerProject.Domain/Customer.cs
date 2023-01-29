//----------------------------------
//-- Creator : MrMohande3 Khademi --
//----------------------------------

using DesignPattern.CustomerProject.InterfaceLayer;

namespace DesignPattern.CustomerProject.DomainLayer
{
    public class Customer : UserBase, ICustomer
    {
        public Customer(IValidation<ICustomer> validation) : base(validation)
        {
        }
    }
}
