/**
 * *************************************************
 * Copyright (c) 2020, Grindrod Bank Limited
 * License MIT: https://opensource.org/licenses/MIT
 * **************************************************
 */
using System.Linq;
using za.co.grindrodbank.a3s.Models;
using AutoMapper;
using za.co.grindrodbank.a3s.A3SApiResources;

namespace za.co.grindrodbank.a3s.MappingProfiles
{
    public class RoleResourceRoleModelProfile : Profile
    {
        public RoleResourceRoleModelProfile()
        {
            CreateMap<RoleModel, Role>().ForMember(dest => dest.Uuid, opt => opt.MapFrom(src => src.Id))
                                        .ForMember(dest => dest.Functions, opt => opt.MapFrom(src => src.RoleFunctions.Select(rf => rf.Function)))
                                        .ForMember(dest => dest.Roles, opt => opt.MapFrom(src => src.ChildRoles.Select(cr => cr.ChildRole)));
            CreateMap<Role, RoleModel>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Uuid));
        }
    }
}
