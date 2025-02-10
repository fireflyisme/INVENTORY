using DomainLayer.Models;
using Inventory.Data.Repositories;
using Inventory.Data;

namespace InfastructureLayer.Repositories
{
    public interface IProgramRepository : IRepository<Program>
    {
        void Update(Program obj);
        void Save();
    }
}