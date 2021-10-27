using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Project5.Models
{
    public partial class ProjectModel1 : DbContext
    {
        public ProjectModel1()
            : base("name=ProjectModel1")
        {
        }

        public virtual DbSet<Personal_Information> Personal_Information { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personal_Information>()
                .Property(e => e.Phone_Number_)
                .IsUnicode(false);
        }
    }
}
