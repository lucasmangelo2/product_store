using AutoMapper;
using ProductStore.Model;
using ProductStore.WebAPI.Request;
using ProductStore.WebAPI.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductStore.WebAPI.Infra
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductRequest>().ReverseMap();
            CreateMap<Category, CategoryRequest>().ReverseMap();
            CreateMap<Document, DocumentRequest>().ReverseMap();

            CreateMap<Product, ProductResponse>().ReverseMap();
            CreateMap<Category, CategoryResponse>().ReverseMap();
            CreateMap<Document, DocumentResponse>().ReverseMap();
        }
    }
}
