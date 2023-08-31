using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLabLibrary.Repository
{
    public class ComputerRepository : ComputerLabRepository
    {
        private readonly ComputerDbContext _db;
        public ComputerRepository(ComputerDbContext dbContext) {
            _db = dbContext;
        }
        public string AddComputer(ComputerLabModel computer)
        {
            throw new NotImplementedException();
            _db.computer.Add(computer);
            _db.SaveChanges();
            return "Inserted";
        }

        public void DeleteAllComputer()
        {
            throw new NotImplementedException();
        }

        public string DeleteComputerById(int id)
        {
            throw new NotImplementedException();
            var comp = _db.computer.Find(id);
            _db.computer.Remove(comp);
            _db.SaveChanges();
            return "Deleted !";
        }

        public List<ComputerLabModel> GetAll()
        {
            throw new NotImplementedException();
            var list = _db.computer.ToList();
            return list;
        }

        public ComputerLabModel GetComputerLabById(int id)
        {
            throw new NotImplementedException();
            return _db.computer.Find(id);
        }

        public string UpdateComputer(ComputerLabModel computer)
        {
            throw new NotImplementedException();
            _db.Entry(computer).State=EntityState.Modified;
            _db.SaveChanges();
            return "Updated DB!";
        }
    }
}
