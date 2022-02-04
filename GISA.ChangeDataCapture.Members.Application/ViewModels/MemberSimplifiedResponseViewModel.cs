using System;

namespace GISA.ChangeDataCapture.Members.Application.ViewModels
{
    public class MemberSimplifiedResponseViewModel
    {
        public Guid Id { get; set; }
        public MemberSimplifiedRelationViewModel Before { get; set; }
        public MemberSimplifiedRelationViewModel After { get; set; }
        public string Operation { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public DateTime? RemovedOn { get; set; }
    }

    public class MemberSimplifiedRelationViewModel
    {
        public MemberSimplifiedViewModel Member { get; set; }
    }

    public class MemberSimplifiedViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDay { get; set; }
        public string PersonIdentifier { get; set; }
    }
}
