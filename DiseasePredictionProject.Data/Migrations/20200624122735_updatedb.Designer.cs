﻿// <auto-generated />
using DiseasePredictionProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DiseasePredictionProject.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200624122735_updatedb")]
    partial class updatedb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DiseasePredictionProject.Core.Models.Disease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiseaseCauses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiseaseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiseaseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicines")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TreatmentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Diseases");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiseaseCauses = "Sarılık yaratabilecek altta yatan durumlar şunlardır:Karaciğerin akut iltihabı: Bu, karaciğerin bilirubini konjuge etme ve salgılama yeteneğini bozarak birikmeye neden olabilir.Safra kanalının iltihabı: Bu, safranın salgılanmasını ve bilirubinin çıkarılmasını önleyerek sarılıklara neden olabilir.Safra kanalının tıkanması: Bu, karaciğerin bilirubini atmasını önler.Hemolitik anemi: Büyük miktarlarda kırmızı kan hücresi parçalandığında bilirubin üretimi artar.Gilbert sendromu: Bu, enzimlerin safra atılımını işleme yeteneğini bozan kalıtsal bir durumdur.Kolestaz: Bu,karaciğerden safra akışını keser.Konjuge bilirubin içeren safra, atılmak yerine karaciğerde kalır.",
                            DiseaseDescription = "Kana rengini veren ve oksijen taşıyan yapılara hemoglobin denir. Hemoglobin kırmızı kan hücrelerinin (alyuvarların) ana yapısını oluşturan maddedir. Alyuvarların vücuttaki ömrü yaklaşık 120 gündür. 120 gün sonrasında kanda bulunan alyuvarlar yıkılıp yenilenir. Alyuvarlardaki bu hemoglobin maddesi yıkıldığı zaman bilirubine dönüştürülür. Bilirubin ise sarı renkli bir maddedir. Karaciğer, bilirubinin vücuttan uzaklaştırılması ile görevlidir. Fakat bilirubin herhangi bir nedenle vücuttan yeteri kadar uzaklaştırılamazsa kan dolaşımına katılır ve cildin, mukozaların ve göz akının sarı renkte gözükmesine neden olur.",
                            DiseaseName = "Sarılık",
                            Info = "https://www.medicalpark.com.tr/sarilik/hg-2092",
                            TreatmentMethod = "Sarılık, altta yatan nedenin yönetilmesiyle tedavi edilir.Anemiye bağlı sarılık, demir takviyeleri alarak veya daha fazla demir açısından zengin gıdalar yiyerek kandaki demir miktarını artırarak tedavi edilebilir.Hepatite bağlı sarılık antiviral veya steroid ilaçlar gerektirir.Doktorlar tıkanıklığın neden olduğu sarılığı tedavi ederek tıkanıklığı cerrahi olarak çıkarabilir."
                        },
                        new
                        {
                            Id = 2,
                            DiseaseCauses = "Bağışıklık sistemi yani savunma sistemi düzgün çalıştığında vücut savunması bakteri, virüs ve diğer yabancı hücrelere karşı savaşır. Romatoid artritde bağışıklık sistemi düzgün çalışmaz ve vücut kendi eklemleri ve diğer organlarına saldırır. Romatoid artritde iltihap hücrelere (beyaz kan hücreleri yani akyuvarlar) kandan eklem dokularına doğru hareket eder ve eklemlere saldırırlar. Eklem sıvısı artarve eklemde şişlik meydana gelir. Eklem dokusundaki iltihap hücreleri eklemi etkileyip hasara neden olur.",
                            DiseaseDescription = "Romatoid artrit eklem iltihabının sık görülen formudur ve eklemlerin içindeki zarda (sinoviyumda) ve/veya diğer iç organlarda iltihaba yol açar. Eklem hattı kalınlaşır ve eklemde ısı artışı, şişme ve ağrıya yol açabilir. Romatoid artrit yıllarca devam eder yani kronik bir hastalıktır. Vücutta değişik pek çok eklemi etkiler. Kıkırdak, kemik ve eklem yapılarına zarar verir.",
                            DiseaseName = "Romatoid Artrit",
                            Info = "https://www.medicalpark.com.tr/romatoid-artrit-nedir-teshisi-ve-tedavisi-nelerdir/hg-132",
                            Medicines = "NSAİİ (Kortizon olmayan ağrı kesici ve iltihap gidericiler),Glukokortikoidler (Kortizon),Analjezikler (Basit ağrı kesiciler)",
                            TreatmentMethod = "Fizik tedavi bazı artrit tipleri için yardımcı olabilir. Egzersizler hareket aralığını iyileştirebilir ve eklemleri çevreleyen kasları güçlendirebilir."
                        },
                        new
                        {
                            Id = 3,
                            DiseaseCauses = "Verem hastalığı yani akciğer tüberkülozu havaya salınan mikroskobik damlacıklar yoluyla insandan insana yayılan bakterilerden kaynaklanır.",
                            DiseaseDescription = "Verem hastalığı, yani tıbbi adıyla tüberküloz (TB) hava yoluyla bir bireyden diğerine yayılan, bulaşıcı bir akciğer hastalığıdır. Verem hastalığı Mycobacterium Tuberculosis isimli bakterilerden kaynaklanır. Verem hastalığı tedavi edilebilir ve verem aşısı ile önlenebilir bir hastalıktır.",
                            DiseaseName = "Tüberküloz",
                            Info = "https://www.medicalpark.com.tr/tuberkuloz-nedir-belirtileri-teshisi-ve-tedavi-yontemleri-nelerdir/hg-1772",
                            Medicines = "İsoniazid, Rifampin(Rifadin, Rimaktan), Etambutol(Myambutol), Pirazinamid",
                            TreatmentMethod = "Tüberküloz ile en az altı ila dokuz ay boyunca antibiyotik almalısınız. Tam ilaçlar ve tedavi süresi yaşınıza, genel sağlığınıza, olası ilaç direncine, TB (gizli veya aktif) formuna ve enfeksiyonun vücuttaki konumuna bağlıdır.Kombine ilaç tedavisi ile dokuz yerine dört ay, gizli TB'nin aktif TB haline gelmesini önlemede etkili olabilir."
                        },
                        new
                        {
                            Id = 4,
                            DiseaseCauses = "Ailede astım varlığı, solunum yoluyla toz ve kimyasal maddeler maruz kalan meslekler, bebeklik döneminde alerjenlere maruz kalma vb.",
                            DiseaseDescription = "Grip influenza adı verilen virüs tarafından meydana getirilen; 39 derece ateş, şiddetli kas ve eklem ağrıları, halsizlik, bitkinlik, titreme, baş ağrısı ve kuru öksürük gibi belirtilerle ortaya çıkan bir mevsim hastalığıdır.",
                            DiseaseName = "Grip",
                            Info = "https://www.medicalpark.com.tr/grip-nedir-belirtileri-ve-tedavileri-nelerdir/hg-1902#:~:text=Grip%20influenza%20ad%C4%B1%20verilen%20vir%C3%BCs,ortaya%20%C3%A7%C4%B1kan%20bir%20mevsim%20hastal%C4%B1%C4%9F%C4%B1d%C4%B1r.",
                            TreatmentMethod = "Astım tedavisi planlanırken hastalığın ağırlık derecesine göre tedavi planlanır. Eğer alerjik astım düşünülüyor ise alerji ilaçları verilir. Ataklar esnasında hastayı rahatlatmak için solunum yoluyla uygulanan spreyler kullanılır. Kortizon, tedavide önemli rol oynar. Hem sprey şeklinde hem de ağızdan uygulanabilir. Tedavinin başarısı, hastanın geçirdiği atak sayısının azalmasına göre belirlenir. "
                        },
                        new
                        {
                            Id = 5,
                            DiseaseCauses = "Grip, virüs kaynaklı bir solunum yolu hastalığıdır. Hastalık, çok bulaşıcıdır ve genellikle enfekte olan bir kişinin öksürmesi, hapşırması, el teması yoluyla başkalarına geçer. Yetişkinler, hastalık belirtileri ortaya çıkmadan bir gün öncesine ve hastalandıktan 7 gün sonrasına kadar hastalığı bulaştırır haldedirler.",
                            DiseaseDescription = "Sinüzit yüz kemiklerinin içerisindeki boşlukların iltihaplı doku ile dolmasından ortaya çıkan hastalıktır. Burun tıkanıklığı, sarı-yeşil renkte burun akıntısı, geniz akıntısı, baş ağrısı ve koku almada güçlük ile kendisini göstermektedir. ",
                            DiseaseName = "Sinüzit",
                            Info = "https://www.medicalpark.com.tr/sinuzit-nedir/hg-138",
                            TreatmentMethod = "Hem tablet hem de inhalasyon şeklinde kullanıma sunulmuş formları olan antiviral ilaçlar, gribin hem daha hafif hem de kısa sürede geçmesine yardımcı olur."
                        },
                        new
                        {
                            Id = 6,
                            DiseaseCauses = "Genetik olarak olabilir, doğuştan kalbin iyi gelişmemesinden olabilir, sigar kullanımı tetikleyebilir, diyabet gibi başka hastalılkarı tarafından tetiklenebilir",
                            DiseaseDescription = "Kalp hastalığı kalbinizi etkileyen bir dizi durumu tanımlar. Kalp hastalığı şemsiyesi altındaki hastalıklar arasında koroner arter hastalığı gibi kan damarı hastalıkları; kalp ritmi problemleri (aritmiler); ve diğerlerinin yanı sıra, doğuştan kalp kusurları (doğuştan kalp kusurları).'Kalp hastalığı' terimi genellikle 'kardiyovasküler hastalık' terimi ile dönüşümlü olarak kullanılır.Kardiyovasküler hastalık genellikle kalp krizi,göğüs ağrısı(anjina) veya inmeye yol açabilen daralmış veya tıkanmış kan damarlarını içeren durumları ifade eder.Kalbinizin kasını, kapakçıklarını veya ritmini etkileyenler gibi diğer kalp rahatsızlıkları da kalp hastalığı formları olarak kabul edilir.Birçok kalp hastalığı formu sağlıklı yaşam tarzı seçimleriyle önlenebilir veya tedavi edilebilir.",
                            DiseaseName = "Kalp Hastalıkları",
                            Info = "https://www.medicalpark.com.tr/kalp-krizi-nedir-belirtileri-ve-tedavi-yontemleri-nelerdir/hg-1851",
                            Medicines = "ACE İnhibitörleri, antiaritmikler, Beta - Engelleyici Tedavisi, Digoksin,diüretikler",
                            TreatmentMethod = "Yaşam tarzı değişiklikleri, İlaç tedavi uygulamaları, Perkütan koroner girişim(Stent uygulamaları),Açık kalp ameliyatı(By pass tedavisi)."
                        },
                        new
                        {
                            Id = 7,
                            DiseaseCauses = "İlerleyen yaş, genetik yatkınlık, sigara, şeker hastalığı, yüksek-düşük kan basıncı, miyopi, uzun süreli kortizon tedavisi, göz yaralanmaları",
                            DiseaseDescription = "Glokom (göz tansiyonu), göz içi basıncının görme sinirini tahrip edecek kadar yükselmesi nedeniyle görme kaybına yol açan bir hastalıktır.",
                            DiseaseName = "Göz tansiyonu (Glokom)",
                            Info = "https://www.medicalpark.com.tr/glokom-hastaligi-nedir-belirti-ve-tedavi-yontemleri-nelerdir/hg-1737",
                            TreatmentMethod = "İlaç tedavisi genellikle ilk tercih edilen yöntemdir.Bunun dışında çeşitli lazer tedavileri(ALT, SLT), ve cerrahi yöntemler uygulanmaktadır."
                        },
                        new
                        {
                            Id = 8,
                            DiseaseCauses = "Menopoz, Hiperprolaktinemi, Prolaktin hormon yüksekliği, nadir görülen bir tümör olan feokromasitoma Karsinoid sendromu gibi daha bir çok etken sebep olabilir.",
                            DiseaseDescription = "Ateş basması ya da sıcak basması, vücudun sıcaklığı gerektiği gibi düzenleyememesinden kaynaklanır. Beynin hipotalamus bölgesi vücudun sıcak soğuk dengesini korumasını sağlar. Hava soğuduğunda beyne sinyal gönderip, titremeyi tetikler. Hava ısındıkça ise beyne sinyal gönderip, terlemeyi sağlar. Ter buharlaştıkça vücudu soğutur. Bazı durumlarda bu denge bozulabilir.",
                            DiseaseName = "Ateş Basması",
                            Info = "https://www.sozcu.com.tr/2018/saglik/ates-basmasi-nedir-belirtileri-nelerdir-tedavisi-nasil-olur-2326752/#:~:text=%C4%B0%C5%9Fte%20t%C3%BCm%20bilmeniz%20gerekenler...&text=Ate%C5%9F%20basmas%C4%B1%20veya%20s%C4%B1cak%20basmas%C4%B1,gibi%20belirtilerle%20karakterize%20bir%20durumdur.",
                            TreatmentMethod = "Altta yatan nedenler kaldırılmalıdır. Sıcak bir günde efordan kaynaklanan hafif hiperemi, artan su tüketimi ve serin bir yerde dinlenme gibi kişisel bakım önlemleri ile yeterince tedavi edilebilir.İlacın maruz kalmasından kaynaklanan ısı inmesi, o ilacın derhal kesilmesini ve bazen de diğer ilaçların karşı önlem olarak kullanılmasını gerektirir.Antipiretiklerin(örn.Asetaminofen, aspirin, diğer nonsteroid antienflamatuar ilaçlar) sıcak çarpması tedavisinde rolü yoktur, çünkü antipiretikler pirojenlerin neden olduğu hipotalamik ayar noktasındaki değişikliği kesintiye uğratır; sıcak çarpması durumunda olduğu gibi aşırı yüklenmiş sağlıklı bir hipotalamus üzerinde çalışmaları beklenmez.Bu durumda, antipiretikler hepatik, hematolojik ve böbrek komplikasyonları geliştiren hastalarda aslında zararlı olabilir, çünkü kanama eğilimlerini şiddetlendirebilirler.Vücut sıcaklığı önemli ölçüde yükseltildiğinde, ısıyı gidermek ve vücudun kendi sıcaklıklarını düzenleme yeteneğini geri kazanmak için mekanik soğutma yöntemleri kullanılır.Serin, gölgeli bir alanda dinlenmek ve kıyafetleri çıkarmak gibi pasif soğutma teknikleri hemen uygulanabilir."
                        },
                        new
                        {
                            Id = 9,
                            DiseaseCauses = "Diyabet Tip 1 Diyabet ve Tip İki Diyabet olarak ikiye ayrılmaktadır. Tip 1 Diyabetin sebebi genellikle genetik faktörlerdir. Tip 2 Diyabetin sebebi ise aşırı kilo, ilerleyen yaş, hareketsiz yaşam veya stres olabilir",
                            DiseaseDescription = "Diyabet, vücudunuzunda pankreas adlı salgı bezinin yeterli miktarda insülin hormonu üretmemesi ya da ürettiği insulin hormonunun etkili bir şekilde kullanılamaması durumun da gelişen ve ömür boyu süren bir hastalıktır. Sonuç olarak kişi, yediği besinlerden kana geçen şekeri yani glukozu kullanamaz ve kan şekeri yükselir (hiperglisemi).",
                            DiseaseName = "Diyabet",
                            Info = "https://www.medicalpark.com.tr/seker-hastaligi-diyabet-nedir/hg-1703",
                            TreatmentMethod = "Tıbbi beslenme tedavisi (Diyet), Egzersiz - Fiziksel aktivite, Kan şekerini düşüren ilaçlar (Haplar ve insülin olarak 2 grupta toplanır.), Eğitim, Diyabetlinin kendini izlemesi"
                        },
                        new
                        {
                            Id = 10,
                            DiseaseCauses = "Sigara kullanımı, Aşırı alkol tüketimi, Non steroidal anti inflamatuar ilaçlar olarak bilinen aspirin, ibuprofen gibi ilaçların uzun süreli kullanımı, Fiziksel stres: Kişinin ciddi bir hastalığa yakalanması, büyük operasyonlar, ciddi yaralanma ve yanıklar, Zihinsel stres, Çeşitli bakteriler, virüsler veya mantarlar enfeksiyonları, Gıda alerjileri, Radyasyon terapisi, İleri yaş, Besin zehirlenmeleri",
                            DiseaseDescription = "Gastrit, mide iç yüzeyini döşeyen ve gastrik mukoza adı verilen zarın iltihaplanması durumudur. Mide, yenen yiyecekler için tampon görevi görür. Yiyecekler midede karıştırılır, asidik özellikteki mide suyuyla sindirilir. Midede ayrıca diyetle alınan proteinleri parçalayan sindirim enzimleri de salgılanır. Mide suyu, mide mukozasında bulunan çok sayıda bezden üretilir. Mide mukozası mide suyunun kuvvetli asidik etkisinden korunmak için özelleşmiş hücrelerinden mide iç yüzeyini kaplayan ince viskoz bir mukus üretir. Çeşitli faktörler; bu koruyucu mukus katmanına saldırabilir veya çok fazla mide asidi üretimine neden olabilir. Bunun sonucunda gastrit ortaya çıkar.",
                            DiseaseName = "Gastrit",
                            Info = "https://www.medicalpark.com.tr/gastrit-nedir-belirtileri-ve-tedavisi-nelerdir/hg-1957",
                            Medicines = "Gaviscon, Nexium",
                            TreatmentMethod = "Yaşam tarzı değişikliği, ilaçla tedavi, cerrahi tedavi"
                        },
                        new
                        {
                            Id = 11,
                            DiseaseCauses = "Kronik yorgunluğun nedenleri kişinin yaş grubuna göre de değişiklik gösterebilir. Genç insanlarda iş stresi, kansızlık, depresyon veya düşük tansiyon gibi sebepler yorgunluğa neden olurken, daha yaşlılarda diyabet, börek, kalp ve karaciğer sorunları da yorgunluğa neden olabilir.",
                            DiseaseDescription = "Geçmek bilmeyen yorgunluğunuzun sebebi kansızlık da olabilir depresyon da... Yorgunluğunuza eşlik eden başka şikayetleriniz varsa bir uzmana başvurmayı ihmal etmeyin. Çünkü çoğu zaman üzerinde durulmayan yorgunluk, ciddi bir hastalığın belirtisi olabiliyor.Kişi kendisini sürekli olarak yorgun ve halsiz hissediyorsa ve bu durum 6 ayı aşkın bir süredir devam ediyorsa kronik yorgunluk sendromuna sahip olabilir. Genellikle mevsim geçişlerinde yorgunluk hissi kendini daha fazla belli eder ve yorgunluğa ek olarak uykusuzluk, vücutta karıncalanma, güçsüzlük ve enerji eksikliği gibi durumlar eşlik eder. Kronik yorgunluk kişinin fiziksel aktivitelerini etkileyebileceği gibi aynı zamanda psikolojik olarak da tehdit oluşturmaktadır.",
                            DiseaseName = "Kronik Yorgunluk Sendromu",
                            Info = "https://www.medicalpark.com.tr/kronik-yorgunluk-sendromu/hg-2112",
                            TreatmentMethod = "Kronik yorgunlukta hasta öyküsü son derece önem taşıyor. Çalıştığı işten, günlük aktivitesine kadar hastanın tüm öyküsü ve bu duruma yol açabileceği düşünülen rahatsızlıkları öğreniliyor. Yorgunluğun ne kadar süredir devam ettiği ve diğer tetikleyen unsurlar araştırılıyor.Yorgunluğun altında yatabilecek diğer sebeplerin olmadığı durumlarda, kronik yorgunluğun tedavisine psikiyatristler ve psikologlar eşliğinde başlanıyor. Kimi hastalar, uzman ekip eşliğinde yapılan terapi seanslarından oldukça fayda görüyor. Kronik yorgunluk tedavisi bir takım yaşam tarzı değişikliklerini de içeriyor. 6 ila 8 saatlik düzenli uyku saatleri ve basit egzersiz hareketleri tedavinin bir parçası olabiliyor. Bunun yanı sıra, sağlıksız diyetler de kronik yorgunluğa sebep olan durumlardan biri olabiliyor."
                        });
                });

            modelBuilder.Entity("DiseasePredictionProject.Core.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("QuestionText")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            QuestionText = "Baş ağrınız var mı?"
                        },
                        new
                        {
                            Id = 2,
                            QuestionText = "Eklem ağrınız veya kas ağrınız var mı?"
                        },
                        new
                        {
                            Id = 3,
                            QuestionText = "Göğüs ağrınız var mı?"
                        },
                        new
                        {
                            Id = 4,
                            QuestionText = "Boğaz ağrınız var mı?"
                        },
                        new
                        {
                            Id = 5,
                            QuestionText = "Öksürüğünüz var mı?"
                        },
                        new
                        {
                            Id = 6,
                            QuestionText = "Gün içerisinde devamlı yorgun mu hissediyorsunuz?"
                        },
                        new
                        {
                            Id = 7,
                            QuestionText = "Yakın zaman içerisinde hiç baygınlık geçirdiniz mi?"
                        },
                        new
                        {
                            Id = 8,
                            QuestionText = "Kendinizi ve vücudunuzu huzursuz hissediyor muunuz?"
                        },
                        new
                        {
                            Id = 9,
                            QuestionText = "Midenizde ekşime ya da yanma, ağzınıza acı ekşi tat gelmesi gibi durumları yaşıyor musunuz?"
                        },
                        new
                        {
                            Id = 10,
                            QuestionText = "Vücut ısınız normalin üzerinde mi?"
                        },
                        new
                        {
                            Id = 11,
                            QuestionText = "Mide bulantınız var mı?"
                        },
                        new
                        {
                            Id = 12,
                            QuestionText = "Karın ağrınız var mı?"
                        },
                        new
                        {
                            Id = 13,
                            QuestionText = "Geniz akıntınız var mı?"
                        },
                        new
                        {
                            Id = 14,
                            QuestionText = "Nefes darlığı çekiyor musunuz?"
                        },
                        new
                        {
                            Id = 15,
                            QuestionText = "Yüz ve göz çevresinde ağrı, basınç veya doluluk hissediyor musunuz?"
                        },
                        new
                        {
                            Id = 16,
                            QuestionText = "Gün içerisinde su içme isteğinizde ya da iştahınızda artma ya da azalma var mı?"
                        },
                        new
                        {
                            Id = 17,
                            QuestionText = "Göz içinde ve cildinizde bir renk değişimi var mı?"
                        },
                        new
                        {
                            Id = 18,
                            QuestionText = "Gün içerisinde baş dönmesiyle birlikte görüşünüzün bulanıklaştığı oluyor mu?"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
