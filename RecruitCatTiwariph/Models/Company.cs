using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatTiwariph.Models
{
    public class Company
    {
        public int Id { get; set; }

        [DisplayName("Company Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "Company Name is required.")]
        public string Name { get; set; }

        [DisplayName("Position Name")]
        [StringLength(50, MinimumLength =2, ErrorMessage ="Please enter a valid Position Name")]
        [Required(ErrorMessage = "Position Name is required.")]
        public string PositionName { get; set; }

        [DisplayName("Minimum Salary")]
        [Range(0, 100000)]
        public decimal MinimumSalary { get; set; }

        [DisplayName("Maximum Salary")]
        [Range(0, 100000000)]
        public decimal MaximumSalary { get; set; }

        [DisplayName("Optional Start Date")]
        [DataType(DataType.Date)]
        public DateTime OptionalStartDate { get; set; }

        [StringLength(50,MinimumLength = 2, ErrorMessage = "Please enter a valid Location")]
        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; }

        [DisplayName("Employee Count")]
        [Range(0, 1000000)]
        public int? CurrentNumberOfEmployees { get; set; }
        public List<Candidate> Candidates { get; set; }
        public Industry Industry { get; set; }
        public int IndustryId { get; set; }
    }
}
