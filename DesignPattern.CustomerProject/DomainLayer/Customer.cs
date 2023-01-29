//----------------------------------
//-- Creator : MrMohande3 Khademi --
//----------------------------------

namespace DesignPattern.CustomerProject.DomainLayer
{
    public class Customer : UserBase
    {
        public override void IsValid()
        {
            if (string.IsNullOrEmpty(Name)) { throw new Exception("Name can not be null or empty"); }
            if (string.IsNullOrEmpty(PhoneNumber)) { throw new Exception("PhoneNumber can not be null or empty"); }
            if (string.IsNullOrEmpty(Addess)) { throw new Exception("Addess can not be null or empty"); }
            if (BillAmount == 0) { throw new Exception("BillAmount can not empty"); }
            if (BillDate == null) { throw new Exception("BillDate can not empty"); }
        }
    }
}
