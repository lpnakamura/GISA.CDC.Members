using System;

namespace GISA.ChangeDataCapture.Members.Domain.Models
{
    public class MembersRelation
    {
        public Member Member { get; set; }
        public PlanType PlanType { get; set; }
        public City City { get; set; }
        public Ocupation Ocupation { get; set; }
    }

    public class Member
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
        public string BoodType { get; set; }
        public string SkinColor { get; set; }
    }

    public class PlanType
    {
        public string Id { get; set; }
        public string Title { get; set; }
    }

    public class City
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public Int64? Latitude { get; set; }
        public Int64? Longitude { get; set; }
    }

    public class Ocupation
    {
        public string Id { get; set; }
        public string Title { get; set; }
    }
}
