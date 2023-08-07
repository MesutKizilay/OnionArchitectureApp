using AutoMapper;
using MediatR;
using OnionArchitectureApp.Application.Dto;
using OnionArchitectureApp.Application.İnterfaces.Repository;
using OnionArchitectureApp.Domain.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.Features.Queries.GetAllProduct
{

	public class GetAllProductQuery : IRequest<ServiceResponse<List<ProductDto>>>
	{

		public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, ServiceResponse<List<ProductDto>>>
		{
			private readonly IProductRepository _productRepository;
			private readonly IMapper _mapper;

			public GetAllProductQueryHandler(IProductRepository productRepository,IMapper mapper)
			{
				_productRepository = productRepository;
				_mapper = mapper;
			}

			public async Task<ServiceResponse<List<ProductDto>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
			{
				var products = await _productRepository.GetAllAsync();

				var viewModel = _mapper.Map<List<ProductDto>>(products);

				return new ServiceResponse<List<ProductDto>>(viewModel);
			}
		}
	}
}