using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Milles_MIS4200_Real.Models
{
    public class Appointment
    {
        [Key]
        public int aptID { get; set; }
        public Pet petName { get; set; }
        [Display (Name="Appointment Date")]
        public DateTime aptDate { get; set; }

        //link pet to apt
        [Display(Name = "Pet ID")]
        public int petID { get; set; }
        public virtual Pet Pet { get; set; }

        //link vet to apt
        public int vetID { get; set; }
        public virtual Vet Vet { get; set; }

    }

}