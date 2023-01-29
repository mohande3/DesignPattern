//----------------------------------
//-- Creator : MrMohande3 Khademi --
//----------------------------------

namespace DesignPattern.CustomerProject.InterfaceLayer
{
    public interface ICustomer
    {
        string Name { get; set; }
        string PhoneNumber { get; set; }
        decimal BillAmount { get; set; }
        DateTime BillDate { get; set; }
        string Addess { get; set; }

        void IsValid();
    }
}
