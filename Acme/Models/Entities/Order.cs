using System;
using System.Collections.Generic;

namespace Acme.Models.Entities
{
    public partial class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime? ShippedDate { get; set; }

        public Customer Customer { get; set; }
    }
}
