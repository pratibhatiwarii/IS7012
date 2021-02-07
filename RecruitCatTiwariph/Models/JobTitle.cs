using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatTiwariph.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal MinimumSalary { get; set; }
        public decimal MaximumSalary { get; set; }
        public decimal MinimumExperience { get; set; }
        public bool IsAvailable { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
