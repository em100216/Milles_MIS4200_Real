using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Milles_MIS4200_Real.Models
{
    public class customer
    {
        public int customerId { get; set; }
        public string customerFirstName { get; set; }
        public string customerLastName { get; set; }
        public string phone { get; set; }
        public int email { get; set; }
        public int MyProperty { get; set; }
        // prop tab tab 
        public ICollection<order> orders { get; set; }
    }
}