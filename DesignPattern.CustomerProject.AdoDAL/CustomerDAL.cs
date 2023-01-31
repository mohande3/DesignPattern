using DesignPattern.CustomerProject.InterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CustomerProject.AdoDAL
{
    public class CustomerDAL : TemplateADO<ICustomer>
    {
        public CustomerDAL() : base("")
        {

        }
        protected override void ExecuteCommand(ICustomer entity)
        {
            throw new NotImplementedException();
        }
    }
}
