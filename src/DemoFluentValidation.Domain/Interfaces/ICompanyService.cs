using DemoFluentValidation.Domain.Entities;
using System.Threading.Tasks;

namespace DemoFluentValidation.Domain.Interfaces
{
    public interface ICompanyService
    {
        Task<int> Add(Company company);
        Task<int> Update(Company company);
        Task<Company> GetById(int companyId);
    }
}
