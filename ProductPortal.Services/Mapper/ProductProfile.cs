using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using ProductPortal.Model;
using ProductPortal.ViewModel;

namespace ProductPortal.Services.Mapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductViewModel, Product>();
        }
    }
}
