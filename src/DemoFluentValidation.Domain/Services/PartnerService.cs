using DemoFluentValidation.Domain.Entities;
using DemoFluentValidation.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace DemoFluentValidation.Domain.Services
{
    public class PartnerService : IPartnerService
    {
        public Task<int> Add(Partner partner)
        {
            throw new NotImplementedException();
        }

        public Task<Partner> GetById(int partnerId)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Partner partner)
        {
            throw new NotImplementedException();
        }
    }
}
