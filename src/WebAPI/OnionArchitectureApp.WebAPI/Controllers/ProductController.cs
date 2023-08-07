using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureApp.Application.Dto;
using OnionArchitectureApp.Application.Features.Commands.CreateProduct;
using OnionArchitectureApp.Application.Features.Queries.GetAllProduct;
using OnionArchitectureApp.Application.Features.Queries.GetProductById;
using OnionArchitectureApp.Application.İnterfaces.Repository;
using System;
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
		}

        [HttpPost]
		public async Task<IActionResult> Post(CreateProductCommand createProductCommand) 
		{
			return Ok(await _mediator.Send(createProductCommand));
		}

        [HttpGet("{id}")]
		public async Task<IActionResult> GetProductById(Guid id) 
		{
			var query=new GetProductByIdQuery() { Id=id};
			return Ok(await _mediator.Send(query));
		}
	}
}