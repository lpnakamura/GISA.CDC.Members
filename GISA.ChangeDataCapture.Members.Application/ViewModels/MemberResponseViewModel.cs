using System;

namespace GISA.ChangeDataCapture.Members.Application.ViewModels
{
    public class MemberResponseViewModel
    {
        public Guid Id { get; set; }
        public MemberRelationViewModel Before { get; set; }
        public MemberRelationViewModel After { get; set; }
        public string Operation { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? RemovedOn { get; set; }
    }

    public class MemberRelationViewModel
    {
        public MemberViewModel Member { get; set; }
        public PlanTypeViewModel PlanType { get; set; }
        public CityViewModel City { get; set; }
        public OcupationViewModel Ocupation { get; set; }
    }

    public class MemberViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SocialName { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Nationality { get; set; }
        public string PersonIdentifier { get; set; }
        public string Address { get; set; }
        public string AddressNumber { get; set; }
        public string Addition { get; set; }
        public string ZipCode { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weigth { get; set; }
        public string BloodType { get; set; }
        public string SkinColor { get; set; }
    }

    public class PlanTypeViewModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
    }

    public class CityViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public Int64? Latitude { get; set; }
        public Int64? Longitude { get; set; }
    }

    public class OcupationViewModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
    }
}
