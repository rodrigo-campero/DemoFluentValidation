using DemoFluentValidation.Domain.Entities;
using System.Threading.Tasks;

namespace DemoFluentValidation.Domain.Interfaces
{
    public interface IRevenuesService
    {
        Task<int> Add(Revenues revenues);
        Task<int> Update(Revenues revenues);
        Task<Revenues> GetById(int revenuesId);
    }
}
