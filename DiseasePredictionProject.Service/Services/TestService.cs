using DiseasePredictionProject.Core.Models;
using DiseasePredictionProject.Core.Repositories;
using DiseasePredictionProject.Core.Response;
using DiseasePredictionProject.Core.Services;
using DiseasePredictionProject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseasePredictionProject.Service.Services
{
    public class TestService : Service<Disease>, ITestService
    {
        public TestService(IUnitOfWork unitOfWork, IRepository<Disease> repository) : base(unitOfWork, repository)
        {
        }
        int[,] array = new int[11, 18] { {0,0,0,0,0,1,0,0,0,1,0,1,0,0,0,1,1,0},//Sarılık
                                            {0,1,0,0,0,1,0,0,0,1,0,0,0,0,0,1,0,0},//artrit 
                                            {0,0,1,0,1,1,0,0,0,0,0,0,0,0,0,1,0,0},//tüberküloz
                                            {1,0,0,1,1,1,0,0,0,1,0,0,0,0,0,0,0,0},//grip
                                            {1,0,0,1,1,1,0,0,0,1,0,0,1,0,1,0,0,0},//sinüzit
                                            {1,0,1,0,1,1,0,0,0,0,0,0,0,1,0,0,0,0},//kalp
                                            {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,1},//tansiyon
                                            {0,0,1,0,0,0,1,1,0,1,1,0,0,0,0,0,0,0},//ateş
                                            {0,0,0,0,0,1,0,0,0,0,1,1,0,0,0,1,0,0},//diyabet
                                            {1,0,0,0,0,0,0,1,1,0,1,0,0,0,0,1,0,0},//gastrit
                                             {0,1,0,1,0,1,0,1,1,0,1,0,0,0,0,0,0,1},//kronik yorgunluk
            };
        int[] result = new int[11]; //sonuç dizissi
        int counter = 0;
        double Calculate(int[] userArray)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                counter = 0;

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == userArray[j]) { counter++; }
                }
                result[i] = (counter * 100) / 18;//hastalıkların cevaplarıyla kullanıcının cevaplarının uyuşma sayılarının oranı hesaplanıyor
                                                   //ve sırayla result dizisine atanıyor.
            }
            double m = result.Max();//En yüksek değer döndürülüyor

            // Positioning max
            return m;
        }
        public async Task<Response<Disease>> GetByIdAsync(int[] userArray)
        {
            int index = Array.IndexOf(result, Convert.ToInt32((Calculate(userArray))))+1;
            double rate=Calculate(userArray);
            if (rate > 88)
            {
                
               var disease=await _unitOfWork.Repository.GetByIdAsync(index);
                return new Response<Disease>(disease);

            }
            else { return new Response<Disease>("Cevaplarınıza uyumlu bir hastalık bulunamadı."); }
        }
    }
}