using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities.Concrete;

namespace WebApi.DataAccess.EntityFramework.Abstract
{
    public interface ICustomerDal
    {
        List<Customer> GetAll();
        void Add(Customer customer);
        Customer GetById(int id);
    }
}
