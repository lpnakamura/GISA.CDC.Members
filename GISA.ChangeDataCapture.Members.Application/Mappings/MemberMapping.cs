using AutoMapper;
using GISA.ChangeDataCapture.Members.Application.ViewModels;
using GISA.ChangeDataCapture.Members.Domain.Entities;

namespace GISA.ChangeDataCapture.Members.Application.Mappings
{
    public class MemberMapping : Profile
    {
        public MemberMapping()
        {
            CreateMap<Member, MemberResponseViewModel>().ReverseMap();
            CreateMap<MemberRelationEntity, MemberRelationViewModel>().ReverseMap();
            CreateMap<MemberEntity, MemberViewModel>().ReverseMap();
            CreateMap<PlanTypeEntity, PlanTypeViewModel>().ReverseMap();
            CreateMap<CityEntity, CityViewModel>().ReverseMap();
            CreateMap<OcupationEntity, OcupationViewModel>().ReverseMap();

            CreateMap<Member, MemberSimplifiedResponseViewModel>().ReverseMap();
            CreateMap<MemberRelationEntity, MemberSimplifiedRelationViewModel>().ReverseMap();
            CreateMap<MemberEntity, MemberSimplifiedViewModel>().ReverseMap();
        }
    }
}
