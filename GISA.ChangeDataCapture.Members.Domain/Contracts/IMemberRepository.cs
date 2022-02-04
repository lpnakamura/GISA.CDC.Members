using GISA.ChangeDataCapture.Members.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GISA.ChangeDataCapture.Members.Domain.Contracts
{
    public interface IMemberRepository
    {
        Task<IEnumerable<Member>> GetAllAsync();
        Task<Member> GetByIdAsync(Guid id);
    }
}
