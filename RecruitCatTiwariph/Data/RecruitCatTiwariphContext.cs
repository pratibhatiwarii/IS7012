using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatTiwariph.Models;

namespace RecruitCatTiwariph.Data
{
    public class RecruitCatTiwariphContext : DbContext
    {
        public RecruitCatTiwariphContext (DbContextOptions<RecruitCatTiwariphContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatTiwariph.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatTiwariph.Models.Company> Company { get; set; }

        public DbSet<RecruitCatTiwariph.Models.JobTitle> JobTitle { get; set; }

        public DbSet<RecruitCatTiwariph.Models.Industry> Industry { get; set; }
    }
}
