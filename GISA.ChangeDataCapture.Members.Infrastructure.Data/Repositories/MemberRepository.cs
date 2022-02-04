using GISA.ChangeDataCapture.Members.Domain.Contracts;
using GISA.ChangeDataCapture.Members.Domain.Entities;
using Microsoft.Extensions.Configuration;
using ServiceStack;
using ServiceStack.Aws.DynamoDb;
using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GISA.ChangeDataCapture.Members.Infrastructure.Data.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly IPocoDynamo _pocoDynamo;
        private readonly IConfiguration _configuration;

        public MemberRepository(IPocoDynamo pocoDynamo, IConfiguration configuration)
        {
            _pocoDynamo = pocoDynamo;
            _configuration = configuration;
            RegisterTable();
        }

        public async Task<IEnumerable<Member>> GetAllAsync()
        {
            return await _pocoDynamo.GetAllAsync<Member>();
        }

        public async Task<Member> GetByIdAsync(Guid id)
        {
            return await _pocoDynamo.GetItemAsync<Member>(id);
        }

        private void RegisterTable()
        {
            var memberType = typeof(Member);
            memberType.AddAttributes(new AliasAttribute(_configuration.GetSection("Aws:Dynamo:TableName").Value));
            _pocoDynamo.RegisterTable(memberType);
            _pocoDynamo.InitSchema();
        }
    }
}
