using DemoFluentValidation.Domain.Entities;
using DemoFluentValidation.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace DemoFluentValidation.Domain.Services
{
    public class CompanyService : ICompanyService
    {
        public Task<int> Add(Company company)
        {
            throw new NotImplementedException();
        }

        public Task<Company> GetById(int companyId)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
