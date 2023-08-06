using OnionArchitectureApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.İnterfaces.Repository
{
	public interface IProductRepository:IGenericRepositoryAsync<Product>
	{
	}
}