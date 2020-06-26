using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DiseasePredictionProject.Core.Models;
using DiseasePredictionProject.Core.Repositories;
using DiseasePredictionProject.Core.UnitOfWorks;
using DiseasePredictionProject.Data.Repositories;

namespace DiseasePredictionProject.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
   
        private IRepository<Disease> _repository;
   

        public IRepository<Disease> Repository => _repository = _repository ??
            new Repository<Disease>(_appDbContext);

        public void Commit()
        {
            _appDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
         await   _appDbContext.SaveChangesAsync();
        }
      
    }
}
