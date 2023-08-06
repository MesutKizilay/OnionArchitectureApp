using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureApp.Application.Dto;
using OnionArchitectureApp.Application.Features.Queries.GetAllProduct;
using OnionArchitectureApp.Application.İnterfaces.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace OnionArchitectureApp.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IMediator _mediator;

		public ProductController(IMediator mediator)
		{
			_mediator = mediator;
		}

        [HttpGet]
		public async Task<IActionResult> Get() 
		{
			var query=new GetAllProductQuery();
			return Ok(await _mediator.Send(query));
			var result = await _productRepository.GetAllAsync();
			result.Select(x => new ProductDto()
			{
				Id = x.Id,
				Name = x.Name
			}).ToList();

			return Ok(result);
		}
	}
}
