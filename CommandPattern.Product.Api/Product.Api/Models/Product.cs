using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Api.Models
{
    public class Product
    {
        public Guid Uid { get; set; }

        public string Name { get; set; }
    }
}
