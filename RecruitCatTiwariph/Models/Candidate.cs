using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatTiwariph.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        [StringLength(50)]
        [Required(ErrorMessage ="First Name is required.")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [DisplayName("Target Salary")]
        [Range(0,1000000)]
        public decimal TargetSalary { get; set; }

        [DisplayName("Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [StringLength(15)]
        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }

        [DisplayName("SSN")]
        [StringLength(11, MinimumLength =9, ErrorMessage ="Please enter a valid Social Security Number")]
        [Required(ErrorMessage = "Social Security is required")]
        public string SocialSecurityNumber { get; set; }

        [DisplayName("Current Salary")]
        [Range(0, 1000000)]
        public decimal? CurrentSalary { get; set; }

        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Range(15, 100)]
        public int? Age { get; set; }
        public Company Company { get; set; }
        public int? CompanyId { get; set; }

        [DisplayName("Job Title")]
        public JobTitle JobTitle { get; set; }
        public int JobTitleId { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
    }
}
