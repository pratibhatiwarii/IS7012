using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatTiwariph.Models
{
    public class JobTitle
    {
        public int Id { get; set; }

        [DisplayName("Job Title")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Please enter a valid Job Title")]
        [Required(ErrorMessage = "Job Title is required.")]
        public string Title { get; set; }

        [DisplayName("Minimum Salary")]
        [Range(0, 100000)]
        public decimal MinimumSalary { get; set; }

        [DisplayName("Maximum Salary")]
        [Range(0, 10000000)]
        public decimal MaximumSalary { get; set; }

        [DisplayName("Minimum Experience")]
        [Range(0, 20)]
        public decimal MinimumExperience { get; set; }

        [DisplayName("Availability")]
        public bool IsAvailable { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
