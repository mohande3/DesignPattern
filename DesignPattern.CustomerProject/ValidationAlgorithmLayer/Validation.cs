//----------------------------------
//-- Creator : MrMohande3 Khademi --
//----------------------------------

using DesignPattern.CustomerProject.InterfaceLayer;
using System.Xml.Linq;

namespace DesignPattern.CustomerProject.ValidationAlgorithmLayer
{
    public class CustomerValidationAll : IValidation<ICustomer>
    {
        public void IsValid(ICustomer entity)
        {
            if (string.IsNullOrEmpty(entity.Name)) { throw new Exception("Name can not be null or empty"); }
            if (string.IsNullOrEmpty(entity.PhoneNumber)) { throw new Exception("PhoneNumber can not be null or empty"); }
            if (string.IsNullOrEmpty(entity.Addess)) { throw new Exception("Addess can not be null or empty"); }
            if (entity.BillAmount == 0) { throw new Exception("BillAmount can not empty"); }
            if (entity.BillDate == null) { throw new Exception("BillDate can not empty"); }
        }
    }
    public class CustomerValidationImportant : IValidation<ICustomer>
    {
        public void IsValid(ICustomer entity)
        {
            if (string.IsNullOrEmpty(entity.Name)) { throw new Exception("Name can not be null or empty"); }
            if (string.IsNullOrEmpty(entity.PhoneNumber)) { throw new Exception("PhoneNumber can not be null or empty"); }
            if (entity.BillAmount == 0) { throw new Exception("BillAmount can not empty"); }
        }
    }

    public class LeadValidation : IValidation<ICustomer>
    {
        public void IsValid(ICustomer entity)
        {
            if (string.IsNullOrEmpty(entity.Name)) { throw new Exception("Name can not be null or empty"); }
            if (string.IsNullOrEmpty(entity.PhoneNumber)) { throw new Exception("PhoneNumber can not be null or empty"); }
        }
    }
}
