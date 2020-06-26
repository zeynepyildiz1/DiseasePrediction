using Microsoft.EntityFrameworkCore.Migrations;

namespace DiseasePredictionProject.Data.Migrations
{
    public partial class UpdateDisease : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 10,
                column: "DiseaseDescription",
                value: "Gastrit, mide iç yüzeyini döşeyen ve gastrik mukoza adı verilen zarın iltihaplanması durumudur. Mide, yenen yiyecekler için tampon görevi görür. Yiyecekler midede karıştırılır, asidik özellikteki mide suyuyla sindirilir. Midede ayrıca diyetle alınan proteinleri parçalayan sindirim enzimleri de salgılanır. Mide suyu, mide mukozasında bulunan çok sayıda bezden üretilir. Mide mukozası mide suyunun kuvvetli asidik etkisinden korunmak için özelleşmiş hücrelerinden mide iç yüzeyini kaplayan ince viskoz bir mukus üretir. Çeşitli faktörler; bu koruyucu mukus katmanına saldırabilir veya çok fazla mide asidi üretimine neden olabilir. Bunun sonucunda gastrit ortaya çıkar.");

            migrationBuilder.InsertData(
                table: "Diseases",
                columns: new[] { "Id", "DiseaseCauses", "DiseaseDescription", "DiseaseName", "Medicines", "TreatmentMethod" },
                values: new object[] { 11, "Kronik yorgunluğun nedenleri kişinin yaş grubuna göre de değişiklik gösterebilir. Genç insanlarda iş stresi, kansızlık, depresyon veya düşük tansiyon gibi sebepler yorgunluğa neden olurken, daha yaşlılarda diyabet, börek, kalp ve karaciğer sorunları da yorgunluğa neden olabilir.", "Geçmek bilmeyen yorgunluğunuzun sebebi kansızlık da olabilir depresyon da... Yorgunluğunuza eşlik eden başka şikayetleriniz varsa bir uzmana başvurmayı ihmal etmeyin. Çünkü çoğu zaman üzerinde durulmayan yorgunluk, ciddi bir hastalığın belirtisi olabiliyor.Kişi kendisini sürekli olarak yorgun ve halsiz hissediyorsa ve bu durum 6 ayı aşkın bir süredir devam ediyorsa kronik yorgunluk sendromuna sahip olabilir. Genellikle mevsim geçişlerinde yorgunluk hissi kendini daha fazla belli eder ve yorgunluğa ek olarak uykusuzluk, vücutta karıncalanma, güçsüzlük ve enerji eksikliği gibi durumlar eşlik eder. Kronik yorgunluk kişinin fiziksel aktivitelerini etkileyebileceği gibi aynı zamanda psikolojik olarak da tehdit oluşturmaktadır.", "Kronik Yorgunluk", null, "Kronik yorgunlukta hasta öyküsü son derece önem taşıyor. Çalıştığı işten, günlük aktivitesine kadar hastanın tüm öyküsü ve bu duruma yol açabileceği düşünülen rahatsızlıkları öğreniliyor. Yorgunluğun ne kadar süredir devam ettiği ve diğer tetikleyen unsurlar araştırılıyor.Yorgunluğun altında yatabilecek diğer sebeplerin olmadığı durumlarda, kronik yorgunluğun tedavisine psikiyatristler ve psikologlar eşliğinde başlanıyor. Kimi hastalar, uzman ekip eşliğinde yapılan terapi seanslarından oldukça fayda görüyor. Kronik yorgunluk tedavisi bir takım yaşam tarzı değişikliklerini de içeriyor. 6 ila 8 saatlik düzenli uyku saatleri ve basit egzersiz hareketleri tedavinin bir parçası olabiliyor. Bunun yanı sıra, sağlıksız diyetler de kronik yorgunluğa sebep olan durumlardan biri olabiliyor." });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "QuestionText",
                value: "Eklem ağrınız veya kas ağrınız var mı?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                column: "QuestionText",
                value: "Gün içerisinde baş dönmesiyle birlikte görüşünüzün bulanıklaştığı oluyor mu?");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Diseases",
                keyColumn: "Id",
                keyValue: 10,
                column: "DiseaseDescription",
                value: "astrit, mide iç yüzeyini döşeyen ve gastrik mukoza adı verilen zarın iltihaplanması durumudur. Mide, yenen yiyecekler için tampon görevi görür. Yiyecekler midede karıştırılır, asidik özellikteki mide suyuyla sindirilir. Midede ayrıca diyetle alınan proteinleri parçalayan sindirim enzimleri de salgılanır. Mide suyu, mide mukozasında bulunan çok sayıda bezden üretilir. Mide mukozası mide suyunun kuvvetli asidik etkisinden korunmak için özelleşmiş hücrelerinden mide iç yüzeyini kaplayan ince viskoz bir mukus üretir. Çeşitli faktörler; bu koruyucu mukus katmanına saldırabilir veya çok fazla mide asidi üretimine neden olabilir. Bunun sonucunda gastrit ortaya çıkar.");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                column: "QuestionText",
                value: "Eklem ağrınız var mı?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                column: "QuestionText",
                value: "Gün içerisinde görüşünüzün bulanıklaştığı oluyor mu?");
        }
    }
}
