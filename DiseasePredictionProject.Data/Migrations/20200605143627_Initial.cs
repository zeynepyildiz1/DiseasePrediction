using Microsoft.EntityFrameworkCore.Migrations;

namespace DiseasePredictionProject.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiseaseName = table.Column<string>(maxLength: 200, nullable: false),
                    DiseaseDescription = table.Column<string>(nullable: true),
                    DiseaseCauses = table.Column<string>(nullable: true),
                    TreatmentMethod = table.Column<string>(nullable: true),
                    Medicines = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Diseases",
                columns: new[] { "Id", "DiseaseCauses", "DiseaseDescription", "DiseaseName", "Medicines", "TreatmentMethod" },
                values: new object[,]
                {
                    { 1, "Sarılık yaratabilecek altta yatan durumlar şunlardır:Karaciğerin akut iltihabı: Bu, karaciğerin bilirubini konjuge etme ve salgılama yeteneğini bozarak birikmeye neden olabilir.Safra kanalının iltihabı: Bu, safranın salgılanmasını ve bilirubinin çıkarılmasını önleyerek sarılıklara neden olabilir.Safra kanalının tıkanması: Bu, karaciğerin bilirubini atmasını önler.Hemolitik anemi: Büyük miktarlarda kırmızı kan hücresi parçalandığında bilirubin üretimi artar.Gilbert sendromu: Bu, enzimlerin safra atılımını işleme yeteneğini bozan kalıtsal bir durumdur.Kolestaz: Bu,karaciğerden safra akışını keser.Konjuge bilirubin içeren safra, atılmak yerine karaciğerde kalır.", "Kana rengini veren ve oksijen taşıyan yapılara hemoglobin denir. Hemoglobin kırmızı kan hücrelerinin (alyuvarların) ana yapısını oluşturan maddedir. Alyuvarların vücuttaki ömrü yaklaşık 120 gündür. 120 gün sonrasında kanda bulunan alyuvarlar yıkılıp yenilenir. Alyuvarlardaki bu hemoglobin maddesi yıkıldığı zaman bilirubine dönüştürülür. Bilirubin ise sarı renkli bir maddedir. Karaciğer, bilirubinin vücuttan uzaklaştırılması ile görevlidir. Fakat bilirubin herhangi bir nedenle vücuttan yeteri kadar uzaklaştırılamazsa kan dolaşımına katılır ve cildin, mukozaların ve göz akının sarı renkte gözükmesine neden olur.", "Sarılık", null, "Sarılık, altta yatan nedenin yönetilmesiyle tedavi edilir.Anemiye bağlı sarılık, demir takviyeleri alarak veya daha fazla demir açısından zengin gıdalar yiyerek kandaki demir miktarını artırarak tedavi edilebilir.Hepatite bağlı sarılık antiviral veya steroid ilaçlar gerektirir.Doktorlar tıkanıklığın neden olduğu sarılığı tedavi ederek tıkanıklığı cerrahi olarak çıkarabilir." },
                    { 10, "Sigara kullanımı, Aşırı alkol tüketimi, Non steroidal anti inflamatuar ilaçlar olarak bilinen aspirin, ibuprofen gibi ilaçların uzun süreli kullanımı, Fiziksel stres: Kişinin ciddi bir hastalığa yakalanması, büyük operasyonlar, ciddi yaralanma ve yanıklar, Zihinsel stres, Çeşitli bakteriler, virüsler veya mantarlar enfeksiyonları, Gıda alerjileri, Radyasyon terapisi, İleri yaş, Besin zehirlenmeleri", "astrit, mide iç yüzeyini döşeyen ve gastrik mukoza adı verilen zarın iltihaplanması durumudur. Mide, yenen yiyecekler için tampon görevi görür. Yiyecekler midede karıştırılır, asidik özellikteki mide suyuyla sindirilir. Midede ayrıca diyetle alınan proteinleri parçalayan sindirim enzimleri de salgılanır. Mide suyu, mide mukozasında bulunan çok sayıda bezden üretilir. Mide mukozası mide suyunun kuvvetli asidik etkisinden korunmak için özelleşmiş hücrelerinden mide iç yüzeyini kaplayan ince viskoz bir mukus üretir. Çeşitli faktörler; bu koruyucu mukus katmanına saldırabilir veya çok fazla mide asidi üretimine neden olabilir. Bunun sonucunda gastrit ortaya çıkar.", "Gastrit", "Gaviscon, Nexium", "Yaşam tarzı değişikliği, ilaçla tedavi, cerrahi tedavi" },
                    { 8, "Menopoz, Hiperprolaktinemi, Prolaktin hormon yüksekliği, nadir görülen bir tümör olan feokromasitoma Karsinoid sendromu gibi daha bir çok etken sebep olabilir.", "Ateş basması ya da sıcak basması, vücudun sıcaklığı gerektiği gibi düzenleyememesinden kaynaklanır. Beynin hipotalamus bölgesi vücudun sıcak soğuk dengesini korumasını sağlar. Hava soğuduğunda beyne sinyal gönderip, titremeyi tetikler. Hava ısındıkça ise beyne sinyal gönderip, terlemeyi sağlar. Ter buharlaştıkça vücudu soğutur. Bazı durumlarda bu denge bozulabilir.", "Ateş Basması", null, "Altta yatan nedenler kaldırılmalıdır. Sıcak bir günde efordan kaynaklanan hafif hiperemi, artan su tüketimi ve serin bir yerde dinlenme gibi kişisel bakım önlemleri ile yeterince tedavi edilebilir.İlacın maruz kalmasından kaynaklanan ısı inmesi, o ilacın derhal kesilmesini ve bazen de diğer ilaçların karşı önlem olarak kullanılmasını gerektirir.Antipiretiklerin(örn.Asetaminofen, aspirin, diğer nonsteroid antienflamatuar ilaçlar) sıcak çarpması tedavisinde rolü yoktur, çünkü antipiretikler pirojenlerin neden olduğu hipotalamik ayar noktasındaki değişikliği kesintiye uğratır; sıcak çarpması durumunda olduğu gibi aşırı yüklenmiş sağlıklı bir hipotalamus üzerinde çalışmaları beklenmez.Bu durumda, antipiretikler hepatik, hematolojik ve böbrek komplikasyonları geliştiren hastalarda aslında zararlı olabilir, çünkü kanama eğilimlerini şiddetlendirebilirler.Vücut sıcaklığı önemli ölçüde yükseltildiğinde, ısıyı gidermek ve vücudun kendi sıcaklıklarını düzenleme yeteneğini geri kazanmak için mekanik soğutma yöntemleri kullanılır.Serin, gölgeli bir alanda dinlenmek ve kıyafetleri çıkarmak gibi pasif soğutma teknikleri hemen uygulanabilir." },
                    { 7, "İlerleyen yaş, genetik yatkınlık, sigara, şeker hastalığı, yüksek-düşük kan basıncı, miyopi, uzun süreli kortizon tedavisi, göz yaralanmaları", "Glokom (göz tansiyonu), göz içi basıncının görme sinirini tahrip edecek kadar yükselmesi nedeniyle görme kaybına yol açan bir hastalıktır.", "Göz tansiyonu (Glokom)", null, "İlaç tedavisi genellikle ilk tercih edilen yöntemdir.Bunun dışında çeşitli lazer tedavileri(ALT, SLT), ve cerrahi yöntemler uygulanmaktadır." },
                    { 6, "Genetik olarak olabilir, doğuştan kalbin iyi gelişmemesinden olabilir, sigar kullanımı tetikleyebilir, diyabet gibi başka hastalılkarı tarafından tetiklenebilir", "Kalp hastalığı kalbinizi etkileyen bir dizi durumu tanımlar. Kalp hastalığı şemsiyesi altındaki hastalıklar arasında koroner arter hastalığı gibi kan damarı hastalıkları; kalp ritmi problemleri (aritmiler); ve diğerlerinin yanı sıra, doğuştan kalp kusurları (doğuştan kalp kusurları).'Kalp hastalığı' terimi genellikle 'kardiyovasküler hastalık' terimi ile dönüşümlü olarak kullanılır.Kardiyovasküler hastalık genellikle kalp krizi,göğüs ağrısı(anjina) veya inmeye yol açabilen daralmış veya tıkanmış kan damarlarını içeren durumları ifade eder.Kalbinizin kasını, kapakçıklarını veya ritmini etkileyenler gibi diğer kalp rahatsızlıkları da kalp hastalığı formları olarak kabul edilir.Birçok kalp hastalığı formu sağlıklı yaşam tarzı seçimleriyle önlenebilir veya tedavi edilebilir.", "Kalp Hastalıkları", "ACE İnhibitörleri, antiaritmikler, Beta - Engelleyici Tedavisi, Digoksin,diüretikler", "Yaşam tarzı değişiklikleri, İlaç tedavi uygulamaları, Perkütan koroner girişim(Stent uygulamaları),Açık kalp ameliyatı(By pass tedavisi)." },
                    { 9, "Diyabet Tip 1 Diyabet ve Tip İki Diyabet olarak ikiye ayrılmaktadır. Tip 1 Diyabetin sebebi genellikle genetik faktörlerdir. Tip 2 Diyabetin sebebi ise aşırı kilo, ilerleyen yaş, hareketsiz yaşam veya stres olabilir", "Diyabet, vücudunuzunda pankreas adlı salgı bezinin yeterli miktarda insülin hormonu üretmemesi ya da ürettiği insulin hormonunun etkili bir şekilde kullanılamaması durumun da gelişen ve ömür boyu süren bir hastalıktır. Sonuç olarak kişi, yediği besinlerden kana geçen şekeri yani glukozu kullanamaz ve kan şekeri yükselir (hiperglisemi).", "Diyabet", null, "Tıbbi beslenme tedavisi (Diyet), Egzersiz - Fiziksel aktivite, Kan şekerini düşüren ilaçlar (Haplar ve insülin olarak 2 grupta toplanır.), Eğitim, Diyabetlinin kendini izlemesi" },
                    { 4, "Ailede astım varlığı, solunum yoluyla toz ve kimyasal maddeler maruz kalan meslekler, bebeklik döneminde alerjenlere maruz kalma vb.", "Grip influenza adı verilen virüs tarafından meydana getirilen; 39 derece ateş, şiddetli kas ve eklem ağrıları, halsizlik, bitkinlik, titreme, baş ağrısı ve kuru öksürük gibi belirtilerle ortaya çıkan bir mevsim hastalığıdır.", "Grip", null, "Astım tedavisi planlanırken hastalığın ağırlık derecesine göre tedavi planlanır. Eğer alerjik astım düşünülüyor ise alerji ilaçları verilir. Ataklar esnasında hastayı rahatlatmak için solunum yoluyla uygulanan spreyler kullanılır. Kortizon, tedavide önemli rol oynar. Hem sprey şeklinde hem de ağızdan uygulanabilir. Tedavinin başarısı, hastanın geçirdiği atak sayısının azalmasına göre belirlenir. " },
                    { 3, "Verem hastalığı yani akciğer tüberkülozu havaya salınan mikroskobik damlacıklar yoluyla insandan insana yayılan bakterilerden kaynaklanır.", "Verem hastalığı, yani tıbbi adıyla tüberküloz (TB) hava yoluyla bir bireyden diğerine yayılan, bulaşıcı bir akciğer hastalığıdır. Verem hastalığı Mycobacterium Tuberculosis isimli bakterilerden kaynaklanır. Verem hastalığı tedavi edilebilir ve verem aşısı ile önlenebilir bir hastalıktır.", "Tüberküloz", "İsoniazid, Rifampin(Rifadin, Rimaktan), Etambutol(Myambutol), Pirazinamid", "Tüberküloz ile en az altı ila dokuz ay boyunca antibiyotik almalısınız. Tam ilaçlar ve tedavi süresi yaşınıza, genel sağlığınıza, olası ilaç direncine, TB (gizli veya aktif) formuna ve enfeksiyonun vücuttaki konumuna bağlıdır.Kombine ilaç tedavisi ile dokuz yerine dört ay, gizli TB'nin aktif TB haline gelmesini önlemede etkili olabilir." },
                    { 2, "Bağışıklık sistemi yani savunma sistemi düzgün çalıştığında vücut savunması bakteri, virüs ve diğer yabancı hücrelere karşı savaşır. Romatoid artritde bağışıklık sistemi düzgün çalışmaz ve vücut kendi eklemleri ve diğer organlarına saldırır. Romatoid artritde iltihap hücrelere (beyaz kan hücreleri yani akyuvarlar) kandan eklem dokularına doğru hareket eder ve eklemlere saldırırlar. Eklem sıvısı artarve eklemde şişlik meydana gelir. Eklem dokusundaki iltihap hücreleri eklemi etkileyip hasara neden olur.", "Romatoid artrit eklem iltihabının sık görülen formudur ve eklemlerin içindeki zarda (sinoviyumda) ve/veya diğer iç organlarda iltihaba yol açar. Eklem hattı kalınlaşır ve eklemde ısı artışı, şişme ve ağrıya yol açabilir. Romatoid artrit yıllarca devam eder yani kronik bir hastalıktır. Vücutta değişik pek çok eklemi etkiler. Kıkırdak, kemik ve eklem yapılarına zarar verir.", "Romatoid Artrit", "NSAİİ (Kortizon olmayan ağrı kesici ve iltihap gidericiler),Glukokortikoidler (Kortizon),Analjezikler (Basit ağrı kesiciler)", "Fizik tedavi bazı artrit tipleri için yardımcı olabilir. Egzersizler hareket aralığını iyileştirebilir ve eklemleri çevreleyen kasları güçlendirebilir." },
                    { 5, "Grip, virüs kaynaklı bir solunum yolu hastalığıdır. Hastalık, çok bulaşıcıdır ve genellikle enfekte olan bir kişinin öksürmesi, hapşırması, el teması yoluyla başkalarına geçer. Yetişkinler, hastalık belirtileri ortaya çıkmadan bir gün öncesine ve hastalandıktan 7 gün sonrasına kadar hastalığı bulaştırır haldedirler.", "Sinüzit yüz kemiklerinin içerisindeki boşlukların iltihaplı doku ile dolmasından ortaya çıkan hastalıktır. Burun tıkanıklığı, sarı-yeşil renkte burun akıntısı, geniz akıntısı, baş ağrısı ve koku almada güçlük ile kendisini göstermektedir. ", "Sinüzit", null, "Hem tablet hem de inhalasyon şeklinde kullanıma sunulmuş formları olan antiviral ilaçlar, gribin hem daha hafif hem de kısa sürede geçmesine yardımcı olur." }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "QuestionText" },
                values: new object[,]
                {
                    { 10, "Vücut ısınız normalin üzerinde mi?" },
                    { 15, "Yüz ve göz çevresinde ağrı, basınç veya doluluk hissediyor musunuz?" },
                    { 14, "Nefes darlığı çekiyor musunuz?" },
                    { 13, "Bulanık gördüğünüz oluyor mu?" },
                    { 12, "Karın ağrınız var mı?" },
                    { 11, "Mide bulantınız var mı?" },
                    { 9, "Midenizde ekşime ya da yanma, ağzınıza acı ekşi tat gelmesi gibi durumları yaşıyor musunuz?" },
                    { 4, "Boğaz ağrınız var mı?" },
                    { 7, "Yakın zaman içerisinde hiç baygınlık geçirdiniz mi?" },
                    { 6, "Gün içerisinde devamlı yorgun mu hissediyorsunuz?" },
                    { 5, "Öksürüğünüz var mı?" },
                    { 16, "Gün içerisinde su içme isteğinizde ya da iştahınızda artma ya da azalma var mı?" },
                    { 3, "Göğüs ağrınız var mı?" },
                    { 2, "Eklem ağrınız var mı?" },
                    { 1, "Baş ağrınız var mı?" },
                    { 8, "Kendinizi ve vücudunuzu huzursuz hissediyor muunuz?" },
                    { 17, "Göz içinde ve cildinizde bir renk değişimi var mı?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "Questions");
        }
    }
}
