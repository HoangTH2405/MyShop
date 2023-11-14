using Application.MyShop.Interfaces;
using Infrastructure.MyShop.Contexts;
using Infrastructure.MyShop.Entities.MyShop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MyShop.Service
{
    public class CustomerSevices : ICustomerServices
    {
        private readonly MyShopContext _myShopContext;

        public CustomerSevices(MyShopContext myShopContext)
        {
            _myShopContext = myShopContext;
        }

        public bool Delete(string id)
        {
            var data = GetById(id);
            _myShopContext.Remove(data);
            var check = _myShopContext.SaveChanges();
            return check > 0;
        }

        public Customer GetById(string id)
        {
            var datas = _myShopContext.Customers.First(x => x.Id == id);
            return datas;
        }

        public List<Customer> GetList()
        {
            var datas = _myShopContext.Customers.ToList();
            return datas;
        }
    }
}
