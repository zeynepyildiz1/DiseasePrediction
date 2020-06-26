using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DiseasePredictionProject.Core.Models;
using DiseasePredictionProject.Core.Repositories;


namespace DiseasePredictionProject.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {    
         
        
      
        IRepository<Disease> Repository { get; }
        Task CommitAsync();
        void Commit();
      
    }
}
