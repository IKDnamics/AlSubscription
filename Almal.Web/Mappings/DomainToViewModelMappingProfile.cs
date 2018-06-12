using AutoMapper;
using Almal.Core;
using Almal.Data;
using System;
using Almal.Web.Models;


namespace Almal.Service.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected  void Configure()
        {
            CreateMap<UserIndexViewModel, ApplicationUser>();
        }
    }
}