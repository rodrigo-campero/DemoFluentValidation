using DemoFluentValidation.Domain.Entities;
using DemoFluentValidation.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace DemoFluentValidation.Domain.Services
{
    public class RevenuesService : IRevenuesService
    {
        public Task<int> Add(Revenues revenues)
        {
            throw new NotImplementedException();
        }

        public Task<Revenues> GetById(int revenuesId)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Revenues revenues)
        {
            throw new NotImplementedException();
        }
    }
}
