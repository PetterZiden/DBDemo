using Acme.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Acme.Models
{
    public class CustomersService
    {

        private readonly AcmeContext _context;

        public CustomersService(AcmeContext context)
        {
            _context = context;
        }

        public Customer[] GetAll()
        {
            return _context.Customer.ToArray();
        }

        public async Task Add(Customer customer)
        {
            _context.Customer.Add(customer);
            await _context.SaveChangesAsync();
        }
    }
}
