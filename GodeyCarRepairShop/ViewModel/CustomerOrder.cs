using GodeyCarRepairShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GodeyCarRepairShop.ViewModel
{
    public class CustomerOrder
    {
        public Guid ServiceId { get; set; }
        public Service Service { get; set; }
        public Customer Customer { get; set; }
    }
}
