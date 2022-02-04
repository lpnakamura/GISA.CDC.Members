using AutoMapper;
using GISA.ChangeDataCapture.Members.Application.Contracts;
using GISA.ChangeDataCapture.Members.Application.ViewModels;
using GISA.ChangeDataCapture.Members.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GISA.ChangeDataCapture.Members.Application.Services
{
    public class MemberService : ServiceBase, IMemberService
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;

        public MemberService(IMapper mapper, INotificationContext notificationContext, IMemberRepository memberRepository) : base(mapper, notificationContext)
        {
            _mapper = mapper;
            _memberRepository = memberRepository;
        }

        public async Task<IEnumerable<MemberSimplifiedResponseViewModel>> GetAllAsync()
        {
            var memberList = await _memberRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<MemberSimplifiedResponseViewModel>>(memberList);
        }

        public async Task<MemberResponseViewModel> GetByIdAsync(Guid id)
        {
            var member = await _memberRepository.GetByIdAsync(id);
            return _mapper.Map<MemberResponseViewModel>(member);
        }
    }
}
