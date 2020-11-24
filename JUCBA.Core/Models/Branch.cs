using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace JUCBA.Core.Models
{
    public enum BranchStatus
    {
        Closed, Open
    }
    public class Branch
    {
        public int ID { get; set; }

        [Required]
        //[RegularExpression(@"^[ a-zA-Z]+$", ErrorMessage = "Full name should only contain characters and white spaces"), MaxLength(40)]
        [Display(Name = "Branch Name")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Pls No Special Characters or numbers allowed")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Pls No Special Characters or numbers allowed")]
        public string Address { get; set; }

        public long SortCode { get; set; } 

        public BranchStatus Status { get; set; }
    }
}
