using Microsoft.EntityFrameworkCore;
using OnionArchitectureApp.Application.İnterfaces.Repository;
using OnionArchitectureApp.Domain.Entities;
using OnionArchitectureApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Persistence.Repositories
{
	public class ProductRepository:GenericRepository<Product>,IProductRepository
	{
		public ProductRepository(ApplicationDbContext context):base(context)
		{
			
		}
	}
}
