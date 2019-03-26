using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adt.EntityFramework.Models;

namespace Adt.EntityFramework
{
	public class StudentDbContext : DbContext
	{
		public DbSet<Student> Student { get; set; }



		public StudentDbContext() : base("Server=(localdb)\\mssqllocaldb;Database=pl2;Trusted_Connection=True;")
		{
			
		}


		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Student>().ToTable("Student");// e.g. - chain .HasKey(s => s.Id)
		}
	}
}
