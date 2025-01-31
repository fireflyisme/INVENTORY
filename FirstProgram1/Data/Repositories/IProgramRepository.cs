using DomainLayer.Models;
using FirstProgram1.Data.Repositories;

namespace InfastructureLayer.Repositories
{
    public interface IProgramRepository : IRepository<Program>
    {
        void Update(Program obj);
        void Save();
    }
}