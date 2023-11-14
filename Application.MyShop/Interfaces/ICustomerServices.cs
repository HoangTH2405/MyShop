using Infrastructure.MyShop.Entities.MyShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MyShop.Interfaces
{
    public interface ICustomerServices
    {
        List<Customer> GetList();
        Customer GetById(string id);

        bool Delete(string id);

    }
}
