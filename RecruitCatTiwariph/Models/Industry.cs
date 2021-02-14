using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatTiwariph.Models
{
    public class Industry
    {
        public int Id { get; set; }

        [DisplayName("Industry Name")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please enter a valid Industry Name")]
        [Required(ErrorMessage = "Industry Name is required.")]
        public string Name { get; set; }
        [DisplayName("Market Evaluation")]
        [Range(0, 1000000000000)]
        public long? CurrentMarketEvaluation { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }
    }
}
