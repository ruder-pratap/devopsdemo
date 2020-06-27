using AutoMapper;
using ProductPortal.Model;
using ProductPortal.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductPortal.Services.Mapper
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<CategoryViewModel, Category>();
        }
    }
}
