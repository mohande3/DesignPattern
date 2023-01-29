//----------------------------------
//-- Creator : MrMohande3 Khademi --
//----------------------------------

using DesignPattern.CustomerProject.InterfaceLayer;

namespace DesignPattern.CustomerProject.DomainLayer
{
    public class Lead : UserBase, ICustomer
    {
        public Lead(IValidation<ICustomer> _validation) : base(_validation)
        {

        }
    }
}
