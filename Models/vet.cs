using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Milles_MIS4200_Real.Models
{
    public class Vet
    {
        public int vetID { get; set; }
        [Display (Name="Vet Name")]
        /*[Required(ErrorMessage ="Vet Name is required")]
        [StringLength(25)]*/
        public string vetName { get; set; }
        [Display (Name="Vet Phone")]
        /*[DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-\d{3}-\d{4}$",
            ErrorMessage ="Phone number must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]*/
        public string vetPhone { get; set; }
        //public virtual pet pet { get; set; }

        public ICollection<Appointment> Appointment { get; set; }


        //prop tab tab 
    }
}