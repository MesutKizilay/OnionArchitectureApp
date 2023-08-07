using Microsoft.EntityFrameworkCore;
using OnionArchitectureApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Persistence.Context
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Product>().HasData(
				new Product() { Id = Guid.NewGuid(), Name = "Pen", Quantity = 100, Value = 50 },
				new Product() { Id = Guid.NewGuid(), Name = "Paper", Quantity = 100, Value = 200 },
				new Product() { Id = Guid.NewGuid(), Name = "Book", Quantity = 100, Value = 500 }
				);
			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Product> Products { get; set; }
	}
}