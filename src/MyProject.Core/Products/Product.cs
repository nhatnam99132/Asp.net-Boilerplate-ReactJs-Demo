using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Products
{
    public class Product : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
