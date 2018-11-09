using System;
using System.Collections.Generic;

namespace Acme.Models.Entities
{
    public partial class Customer
    {
        public Customer()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }

        public ICollection<Order> Order { get; set; }
    }
}
