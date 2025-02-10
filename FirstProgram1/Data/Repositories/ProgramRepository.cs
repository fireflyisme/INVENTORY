﻿using DomainLayer.Models;
using Inventory.Data;
using Inventory.Data.Repositories;

namespace InfastructureLayer.Repositories
{
    //public class AllowanceRepository : BaseRepository, IAllowanceRepository
    public class ProgramRepository : Repository<Program>, IProgramRepository
    {
        private AppDbContext _db;
        public ProgramRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Program obj)
        {
            _db.Programs.Update(obj);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
