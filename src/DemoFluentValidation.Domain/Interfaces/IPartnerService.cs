using DemoFluentValidation.Domain.Entities;
using System.Threading.Tasks;

namespace DemoFluentValidation.Domain.Interfaces
{
    public interface IPartnerService
    {
        Task<int> Add(Partner partner);
        Task<int> Update(Partner partner);
        Task<Partner> GetById(int partnerId);
    }
}
