using AutoMapper;
using OnionArchitectureApp.Application.Dto;
using OnionArchitectureApp.Application.Features.Commands.CreateProduct;
using OnionArchitectureApp.Application.Features.Queries.GetProductById;
using OnionArchitectureApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureApp.Application.Mapping
{
	public class GeneralMapping:Profile
	{
        public GeneralMapping()
        {
            CreateMap<Product,ProductDto>().ReverseMap();
            CreateMap<Product,CreateProductCommand>().ReverseMap();
            CreateMap<Product, GetProductByIdQuery>().ReverseMap();
            CreateMap<Product, GetroductByIdModel>().ReverseMap();
        }
    }
}