using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureApp.Application.İnterfaces.Repository;
using OnionArchitectureApp.Persistence.Context;
using OnionArchitectureApp.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Persistence
{
	public static class ServiceRegistration
	{
		public static void AddPersitenceServices(this IServiceCollection services)
		{
			services.AddDbContext<ApplicationDbContext>(options => options.UseInMemoryDatabase("memoryDb"));
			services.AddTransient<IProductRepository, ProductRepository>();
		}
	}
}