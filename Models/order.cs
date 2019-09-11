using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Milles_MIS4200_Real.Models
{
    public class order
    {
        public int orderId { get; set; }
        public int customerId { get; set; }
        public virtual customer customer { get; set; }
        public DateTime orderDate { get; set; }
        
        //prop tab tab SWAG
    }
}