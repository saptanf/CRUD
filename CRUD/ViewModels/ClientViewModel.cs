using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD.ViewModels
{
    public class ClientViewModel
    {
        [Key]
        [DisplayName("ID")]
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [DisplayName("Full Name")]
        [StringLength(255)]
        public string FullName { get; set; }

        [DisplayName("Gender")]
        [StringLength(10)]
        public string Gender { get; set; }

        [DisplayName("Place Of Birth")]
        public string PlaceOfBirth { get; set; }

        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        public string _dateOfBirth { get; set; }
    }
}