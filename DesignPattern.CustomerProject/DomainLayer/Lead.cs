//----------------------------------
//-- Creator : MrMohande3 Khademi --
//----------------------------------

namespace DesignPattern.CustomerProject.DomainLayer
{
    public class Lead : UserBase
    {
        public override void IsValid()
        {
            if (string.IsNullOrEmpty(Name)) { throw new Exception("Name can not be null or empty"); }
            if (string.IsNullOrEmpty(PhoneNumber)) { throw new Exception("PhoneNumber can not be null or empty"); }
        }
    }
}
