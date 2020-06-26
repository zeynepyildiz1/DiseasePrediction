using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using DiseasePredictionProject.Core.Models;

namespace DiseasePredictionProject.Data.Seeds
{
    class QuestionSeed : IEntityTypeConfiguration<Question>
    {
     
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasData(
                new Question
                {
                    Id = 1,
                    QuestionText = "Baş ağrınız var mı?"
                },
                 new Question
                 {
                     Id = 2,
                     QuestionText = "Eklem ağrınız veya kas ağrınız var mı?"
                 },
                    new Question
                    {
                        Id = 3,
                        QuestionText = "Göğüs ağrınız var mı?"
                    }, new Question
                    {
                        Id = 4,
                        QuestionText = "Boğaz ağrınız var mı?"
                    },
                       new Question
                       {
                           Id = 5,
                           QuestionText = "Öksürüğünüz var mı?"
                       },
  
                 new Question
                 {
                     Id = 6,
                     QuestionText = "Gün içerisinde devamlı yorgun mu hissediyorsunuz?"
                 }, new Question
                 {
                     Id = 7,
                     QuestionText = "Yakın zaman içerisinde hiç baygınlık geçirdiniz mi?"
                 },
                    new Question
                    {
                        Id = 8,
                        QuestionText = "Kendinizi ve vücudunuzu huzursuz hissediyor muunuz?"
                    },
                       new Question
                       {
                           Id = 9,
                           QuestionText = "Midenizde ekşime ya da yanma, ağzınıza acı ekşi tat gelmesi gibi durumları yaşıyor musunuz?"
                       },
                          new Question
                          {
                              Id = 10,
                              QuestionText = "Vücut ısınız normalin üzerinde mi?"
                          },
                            
                                new Question
                                {
                                    Id = 11,
                                    QuestionText = "Mide bulantınız var mı?"
                                }, new Question
                                {
                                    Id = 12,
                                    QuestionText = "Karın ağrınız var mı?"
                                },
                    new Question
                    {
                        Id = 13,
                        QuestionText = "Geniz akıntınız var mı?"
                    },
                       new Question
                       {
                           Id = 14,
                           QuestionText = "Nefes darlığı çekiyor musunuz?"
                       },
                          new Question
                          {
                              Id = 15,
                              QuestionText = "Yüz ve göz çevresinde ağrı, basınç veya doluluk hissediyor musunuz?"
                          },
                             new Question
                             {
                                 Id = 16,
                                 QuestionText = "Gün içerisinde su içme isteğinizde ya da iştahınızda artma ya da azalma var mı?"
                             },
                             new Question
                             {
                                 Id = 17,
                                 QuestionText = "Göz içinde ve cildinizde bir renk değişimi var mı?"
                             },
                             new Question
                             {
                                 Id = 18,
                                 QuestionText = "Gün içerisinde baş dönmesiyle birlikte görüşünüzün bulanıklaştığı oluyor mu?"
                             }
                             );

        }
    }
}
