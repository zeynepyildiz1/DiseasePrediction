using DiseasePredictionProject.Core.Models;
using DiseasePredictionProject.Core.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiseasePredictionProject.Core.Services
{
    public interface ITestService : IService<Disease>
    {
        Task<Response<Disease>> GetByIdAsync(int[] userArray);
    }
}
