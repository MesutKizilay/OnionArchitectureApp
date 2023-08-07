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

namespace OnionArchitectureApp.Application.Features.Queries.GetProductById
{
	public class GetProductByIdQuery:IRequest<ServiceResponse<GetroductByIdModel>>
	{
        public Guid Id { get; set; }

		public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<GetroductByIdModel>>
		{
			readonly IProductRepository _productRepository;
			readonly IMapper _mapper;

			public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
			{
				_productRepository = productRepository;
				_mapper = mapper;
			}

			public async Task<ServiceResponse<GetroductByIdModel>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
			{
				var product=await _productRepository.GetByIdAsync(request.Id);
				var dto=_mapper.Map<GetroductByIdModel>(product);

				return new ServiceResponse<GetroductByIdModel>(dto);
			}
		}
	}
}