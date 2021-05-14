using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DataAccess.EntityFramework.Abstract;
using WebApi.Entities.Concrete;

namespace WebApi.DataAccess.EntityFramework.Concrete
{
    public class CustomerDal : ICustomerDal
    {
        public void Add(Customer customer)
        {
            using (WebApiContext context = new WebApiContext())
            {
                var addedEntity = context.Entry(customer);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<Customer> GetAll()
        {
            using (WebApiContext context = new WebApiContext())
            {
              return  context.Set<Customer>().ToList();   
            }

        }

        public Customer GetById(int id)
        {
            using (WebApiContext context = new WebApiContext())
            {
                return context.Set<Customer>().SingleOrDefault(p=>p.Id==id);
            }
        }
    }
}
