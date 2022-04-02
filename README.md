# Hospital
# Hastane yönetim ve randevu otomasyonu
Hastaneler kompleks işlemlerin gerçekleştiği çok fonksiyonlu işletmelerdir. Öncelikle hastane bir işletmedir, daha sonra tıbbi hizmet veren bir kuruluştur ayrıca otelcilik hizmeti verirler.Tıbbi malzemelerin yönetilmesi, hasta kaydı,doktor işlemleri,radevu işlemleri, depo işlemeri, demirbaş kayıtları gibi çok fonksiyonel kurumlardır. Bizim bu otomasyondaki amacımız insanların yaşamında büyük rol oynayan sağlık sektöründe çalışanların ve hasta insanların hayatını kolaylaştırmaktır.Biz bu otomasyonda hastane randevu kısmını işleyeceğiz.Bu otomasyon hastaların randevu saati, bölüm adı, doktor adı gibi çeşitli bilgilere kolayca sahip olabilmesi ve istendiği zaman erişebilmesini sağlamaktadır.

Otomasyonun içeriğini daha çok anlatmak istersek hastanelerde kaynakların yerinde kullanılması ve israfın önlenmesi,oluşturulmaya çalışılan kalite ve standartların tesis edilmesi ve korunması,hastanelerde sunulan sağlık hizmetinin en iyi şekilde verilebilmesidir.Otomasyon daha önceki randevu sistemlerinde olduğu gibi hastanede hangi bölümlerin olduğunu doktorların hangi zaman diliminde ve hangi saat aralıklarında dolu olduğu hakkında bilgiler sunmaktadır. Hastanede yeni bir bölüm açılacağı zaman ve randevu saatlerinde güncelleme yapılabilecektir. Bu nedenle randevu alınacak bölümlerden kolaylıkla randevu alınabilecektir ve hasta doktor arasında sağıklı bir iletişim sağlanabilecektir. Bir çok hastane randevu sistemlerinde hasta ve doktor arasında iletişim kopuklukları ve hatalı bilgilerden kaynaklı yanlış anlaşılmalar oluşmaktadır bizim otomasyonumuz hasta ve doktor arasında daha sistematik bir iletişimin kurulmasını sağlamaktadır. 


Bu otomasyon nesneye yönelik programlama dillerinden olan C# dili ile yapılacaktır.C# programlama dili derleyicisi olarak kullanılan Visual Studio programı incelenmiş ve arayüz tasarımına da önem verilmiştir. Bununla birlikte projemizde kullanılan MsSQL veritabanı hakkında bilgiler işlenmiştir.Projemizin önemli bir kısmını her hangi bir hastane servisinin gereksinim duyacağı, hastanenin ihtiyaçlarına cevap verebilecek bir otomasyon sistem yazılımı içermektedir. Bu yazılımda olması gereken temel özellikler doğruluk(Yazılımın belirtilmiş ihtiyaçlarını karşılamasıdır.), güvenilirlik(Gerekli işlevi ne hassaslıkla yerine getireceği beklentisidir.), verimlilik(İşlevin gerçekleştirilmesi için kullanılması gereken bilgisayar kaynakları ve kod miktarıdır.), bütünlük(Yazılım ve bilgilerine, istenmeyen insanlarca ulaşımın ne derece engellenebildiğidir.), kullanılabilirlik(Programın öğrenilmesi, çalıştırılması, girdi hazırlama ve çıktı yorumlama işlemlerinin kolaylık derecesidir.), hata bulma kolaylığı(Hatanın yerini bulma ve düzeltme kolaylığıdır.), esneklik(Yazılımda değişiklik yapma kolaylığıdır), taşınabilirlik(Programın farklı donanımlarda ve yazılım sistemi ortamlarında kullanılmasıdır.), tekrar kullanılabilirlik(Yazılım tamamının ya da bir bölümünün farklı bir uygulamada kullanılabilmesidir.), birlikte çalışabilirlik(Bir yazılım sisteminin diğerleri ile bağlantı sağlaması kolaylığıdır.), Özetlemek gerekirse bu otomasyon hastanın, sağlık çalışanlarının ve hastane yönetiminin daha dinamik kullanımasını sağlamaktadır.Yazılım geliştirme süreç aşamaları işlenecek ve proje görselleriyle birlikte tanıtılacaktır.




# Katkı Sağlayanlar

Süveyda Sultan Altay 192523067

Züleyha Taşgıt 192523023


# Kullanılacak Dil

C#


C# Programlama Dili (si şarp şeklinde telaffuz edilir), Microsoft'un geliştirmiş olduğu yeni nesil dilidir. Yine Microsoft tarafından geliştirilmiş .NET Teknolojisi için geliştirilmiş dillerden biridir.Microsoft tarafından geliştirilmiş olsa da ECMA ve ISO standartları altına alınmıştır.Visual Studio kod editörü aynı zamanda hızlı navigasyon için kod ayarı yer imleri destekler. Diğer seyir yardımcıları, çöken kod blokları ve artımlı aramaya ekolarak normal metin arama ve regex arama içerir. Kod editörü aynı zamanda bir çoklu öğe panosu ve bir görev listesi içerir. Kod editörü ayrıca, tekrarlanan kod için kaydedilen ve üzerinde çalışılan proje içerisine yerleştirilebilen, kod parçacıklarını destekler.Visual Studio arka plan derleme özelliği de içerir (artımlı derleme olarak da bilinir). Kod yazılırken, sözdizimi ve derleme hataları hakkında geri bildirim sağlayabilmek için (bu hataların altı kızmızı ile işaretlenir) Visual Studio arkaplanda derleme yapar.Microsoft Visual C#
Microsoft Visual C#, .NET Framework ile birlikte Visual Studio IDE'nin C# projelerine destek vermesini sağlayan dil servislerini hedef alan, Microsoft'un bir C#
dil uygulamasıdır. Dil servislerinin, Visual Studio'nun bir parçası olmasıyla birlikte,derleyici, .NET Framework'un ayrı bir parçası olarakta bulunmaktadır.



# Veritabanı
 
 MSSQL 
  
Neden Veritabanı Kullanılır?
Bilgisayar ortamında verilerin tutulması, saklanması ve erişilmesinde günümüze kadar değişik yöntem ve yaklaşımlar kullanılmıştır. Bu yaklaşımlardan biri olan Geleneksel Yaklaşım verilerin ayrı ayrı dosyalarda gruplanma yaklaşımını kullanmaktadır. Veritabanı programlarından önce verileri saklamak için programlama dillerinde sıralı ve rastgele dosyalama sistemleri kullanılırdı. Bu sistem; birbiriyle ilgili olan ve aynı gruba dâhil olan verilerin bir dosyada tutulması yöntemine dayanmaktadır. Verilerin artması, verilere aynı anda erişilmesi ve aynı anda erişilen verilerin erişenlere göre düzenlenmesi gibi ihtiyaçlar arttıkça geleneksel
yaklaşım yetersiz kalmıştır.Diğer bir ismi ile db olarak bilinen database, verilerin belirli bir alanda depolanmasını sağlamaktadır. Özellikle devlet kurumlarında kullanılan bu sistem ile birçok veri rahatlıkla saklanabilmektedir. Belirli bir düzene göre uyarlanan bu sistemi birçok kuruluş kullanıyor.Db sayesinde milyonlarca kişinin bilgisine kısa süre içerisinde ulaşılmaktadır.

MSSQL Nedir?
MSSQL yani uzun adı ile Microsoft SQL Server temel olarak içerisinde verilerin depolandığı bir sistemdir. Daha detaylı ifade ile verilerin depolanmasını ve birden fazla kullanıcının aynı anda erişmesini sağlayan kurumsal çaplı ilişkisel veritabanı yönetim sistemidir. Bir internet sitesi içerisinde yer alan metinler, yazılara yönelik yorumlar, kullanıcıların bilgileri de dahil pek çok veri buraya depolanabiliyor.
MSSQL Ne İşe Yarar?
Windows firmasına ait bilgi yönetim ve depolama ürünü olan MSSQL, işletmeler için önemli bir sistem. Microsoft SQL Server ile veri işleme, indeksleme, sorgulama, raporlama gibi çeşitli işlemler yapılabiliyor. Masaüstü uygulama ve programları kullanacak olanların ve internet sistemleri tasarlayıp hazırlayanların veritabanı gereksinimini iyi derecede karşılıyor.






# İş Dağılımı
Hastanenin ana yazılımı (Züleyha Taşgıt)

Hasta ana yazılımı (Süveyda Sultan Altay)

Veritabanı tablolarının oluşturulması (Züleyha Taşgıt)

Otomasyonun ara yüz  tasarım (Süveyda Sultan Altay)


# Check List

Süveyda Sultan Altay


 #Yazılım Geliştirme Süreci
 
 Görev 1: Problemin tanımı & Planlama,
 Görev 2: Çözüm & Analiz,
 Görev 3:Tasarım,
 Görev 4:Gerçekleştirim,
 Görev 5:Test,
 Görev 6:Uygulama,








