using GISA.ChangeDataCapture.Members.Application.Contracts;
using GISA.ChangeDataCapture.Members.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GISA.ChangeDataCapture.Members.Api.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class MemberController : ApiBaseController
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService, INotificationContext notificationContext) : base(notificationContext)
        {
            _memberService = memberService;
        }

        [HttpGet("{id}")]
        public async Task<MemberResponseViewModel> GetByIdAsync(Guid id)
        {
            return await _memberService.GetByIdAsync(id);
        }

        [HttpGet]
        public async Task<IEnumerable<MemberSimplifiedResponseViewModel>> GetAllAsync()
        {
            return await _memberService.GetAllAsync();
        }
    }
}
