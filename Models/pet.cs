using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Milles_MIS4200_Real.Models
{
    public class Pet
    {
        public int petID { get; set; }
        [Display (Name="Pet Name")]
        /*[Required(ErrorMessage ="Pet Name is required")]
        [StringLength(25)]*/
        public string petName { get; set; }
        [Display (Name="Type of Pet")]
        /*[Required]
        [StringLength(25)]*/
        public string petType { get; set; }
        [Display (Name="Phone Number")]
        /*[DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-\d{3}-\d{4}$",
            ErrorMessage ="Phone number must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]*/
        public string phone { get; set; }
        // prop tab tab 
        public ICollection<Appointment> Appointment { get; set; }
    }
}