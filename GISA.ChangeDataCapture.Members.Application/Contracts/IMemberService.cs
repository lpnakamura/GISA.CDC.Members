using GISA.ChangeDataCapture.Members.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GISA.ChangeDataCapture.Members.Application.Contracts
{
    public interface IMemberService
    {
        Task<IEnumerable<MemberSimplifiedResponseViewModel>> GetAllAsync();
        Task<MemberResponseViewModel> GetByIdAsync(Guid id);
    }
}
