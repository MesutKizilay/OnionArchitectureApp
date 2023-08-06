using MediatR;
using OnionArchitectureApp.Application.Dto;
using OnionArchitectureApp.Application.İnterfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.Features.Queries.GetAllProduct
{
	public class GetAllProductQuery:IRequest<List<ProductDto>>
	{

		public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<ProductDto>>
		{
			IProductRepository _productRepository;

			public GetAllProductQueryHandler(IProductRepository productRepository)
			{
				_productRepository = productRepository;
			}

			public async Task<List<ProductDto>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
			{
				var product = await _productRepository.GetAllAsync();

				return product.Select(i => new ProductDto()
				{
					Id = i.Id,
					Name = i.Name
				}).ToList();
			}
		}
	}
}