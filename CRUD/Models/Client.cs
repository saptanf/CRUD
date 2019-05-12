using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class Client
    {
        [Key]
        [DisplayName("ID")]
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [DisplayName("Full Name")]
        [StringLength(255)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [DisplayName("Gender")]
        [StringLength(10)]
        public string Gender { get; set; }

        [DisplayName("Place Of Birth")]
        public string PlaceOfBirth { get; set; }

        [Required(ErrorMessage = "This Field is Required")]
        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }


    }

}