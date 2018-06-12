using AutoMapper;
using Almal.Core;
using Almal.Web.Models;
using Almal.Data;
using System;


namespace Almal.Service.Mappings
{

    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected  void Configure()
       {
            CreateMap<UserIndexViewModel, ApplicationUser>();

        }
    }
}