using FluentValidation.Results;
using ServiceStack.DataAnnotations;
using System;

namespace GISA.ChangeDataCapture.Members.Domain.Entities
{
    public class Member : EntityBase
    {
        [Alias("before")]
        public MemberRelationEntity Before { get; set; }
        [Alias("after")]
        public MemberRelationEntity After { get; set; }

        public override ValidationResult GetValidationResult<TModel>()
        {
            return new ValidationResult();
        }
    }

    public class MemberRelationEntity
    {
        [Alias("member")]
        public MemberEntity Member { get; set; }
        [Alias("planType")]
        public PlanTypeEntity PlanType { get; set; }
        [Alias("city")]
        public CityEntity City { get; set; }
        [Alias("ocupation")]
        public OcupationEntity Ocupation { get; set; }
    }

    public class MemberEntity
    {
        [Alias("id")]
        public string Id { get; set; }
        [Alias("name")]
        public string Name { get; set; }
        [Alias("socialName")]
        public string SocialName { get; set; }
        [Alias("maritalStatus")]
        public string MaritalStatus { get; set; }
        [Alias("gender")]
        public string Gender { get; set; }
        [Alias("birthDay")]
        public DateTime? BirthDay { get; set; }
        [Alias("nationality")]
        public string Nationality { get; set; }
        [Alias("personIdentifier")]
        public string PersonIdentifier { get; set; }
        [Alias("address")]
        public string Address { get; set; }
        [Alias("addressNumber")]
        public string AddressNumber { get; set; }
        [Alias("addition")]
        public string Addition { get; set; }
        [Alias("zipCode")]
        public string ZipCode { get; set; }
        [Alias("emailAddress")]
        public string EmailAddress { get; set; }
        [Alias("phoneNumber")]
        public string PhoneNumber { get; set; }
        [Alias("mobileNumber")]
        public string MobileNumber { get; set; }
        [Alias("height")]
        public decimal? Height { get; set; }
        [Alias("weigth")]
        public decimal? Weigth { get; set; }
        [Alias("bloodType")]
        public string BloodType { get; set; }
        [Alias("skinColor")]
        public string SkinColor { get; set; }
    }

    public class PlanTypeEntity
    {
        [Alias("id")]
        public string Id { get; set; }
        [Alias("title")]
        public string Title { get; set; }
    }

    public class CityEntity
    {
        [Alias("id")]
        public string Id { get; set; }
        [Alias("name")]
        public string Name { get; set; }
        [Alias("state")]
        public string State { get; set; }
        [Alias("latitude")]
        public Int64? Latitude { get; set; }
        [Alias("longitude")]
        public Int64? Longitude { get; set; }
    }

    public class OcupationEntity
    {
        [Alias("id")]
        public string Id { get; set; }
        [Alias("title")]
        public string Title { get; set; }
    }
}
