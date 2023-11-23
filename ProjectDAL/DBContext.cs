using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDAL
{
    public partial class ProjectDBContext : DbContext
    {
        public ProjectDBContext()
        {
            
        }
        public ProjectDBContext(DbContextOptions<ProjectDBContext> options) : base(options) 
        {
        

        }

        public virtual DbSet<Owner> FlatOwner { get; set; } = null;

        public virtual DbSet<Facility> Facilities { get; set; } = null;

        public virtual DbSet<GatePass> Permission { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=ApartmentDb; Trusted_Connection=true");
        }
    }
}
