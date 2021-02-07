using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatTiwariph.Models
{
    public class Industry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long? CurrentMarketEvaluation { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Companies { get; set; }
    }
}
