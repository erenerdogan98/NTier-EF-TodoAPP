# NTier-EF-TodoAPP
***Detaylı açıklamalar , projenin içerisinde txt formatı şeklinde belirtilmiştir-Detailed explanations are stated in txt format within the project.***
Bu proje, n-katmanlı mimari yapısını kullanarak tasarlanmış bir Todo uygulamasıdır. Entity Framework ile SQL bağlantısı sağlanırken, gelişmiş yapı ve modülerlik için SOLID prensiplerine uygun olarak tasarlanmıştır.Detaylı açıklamalar projenin içerisinde de mevcuttur.

Entities Katmanı: Uygulamanın veri modellerini barındırır. Bu katmanda yapılan her değişiklik, migration ile veritabanına yansıtılır.
DLL (Database Logic Layer) Katmanı: Veritabanı işlemleri bu katmanda gerçekleştirilir. CRUD işlemleri için genel metotlar oluşturularak tekrar tekrar yazım engellenmiştir.
BLL (Business Logic Layer) Katmanı: İş kurallarının tanımlandığı katmandır. Validasyon, e-posta gönderimi gibi işlevler burada gerçekleştirilir.
UI Katmanı: Kullanıcı arayüzünün bulunduğu katmandır. Kullanıcıların sisteme erişimini ve etkileşimini sağlar.
Detaylı açıklamalar projenin içerisinde de mevcuttur.
Özellikler:

Kullanıcılara e-posta bilgilendirmesi yapılır.
Admin için özel panel ve yetkiler mevcuttur.
Kullanıcı sadece kendi işlemlerini görüntüleyebilirken, admin tüm işlemleri görebilir ve düzenleyebilir.
Sonuç olarak, bu proje, modüler ve genişletilebilir bir yapıda, temiz kod prensiplerine uygun olarak tasarlanmıştır. Farklı sunum katmanlarıyla kolayca entegre edilebilir ve genişletilebilir. Güvenlik için ileri düzey şifreleme ve token yöntemleri de entegre edilebilir.
Kullanılan Teknolojiler:

Entity Framework Core: Veritabanı işlemleri için ORM aracıdır. Veritabanı ile uygulama arasındaki bağlantıyı sağlar.
Microsoft.EntityFrameworkCore paketleri: Veritabanı işlemleri ve tasarımı için gerekli paketlerdir.
Windows Forms: Grafik kullanıcı arayüzü tasarımı için kullanılan teknolojidir.
FluentValidation: Nesne doğrulama kurallarının tanımlanmasında kullanılır.
SHA Şifreleme: Kullanıcı şifrelerinin güvenli bir şekilde saklanmasını sağlar.

Kullanılan Yöntemler ve Prensipler:
SOLID Prensipleri: Yazılımın sürdürülebilirliği, genişletilebilirliği ve anlaşılabilirliği için bu prensipler doğrultusunda tasarlanmıştır.
Dependency Injection: Bağımlılıkların yönetimi ve sınıf arası etkileşiminin kontrolü için kullanılır. Bu sayede modüler ve bağlantısız bir yapı elde edilir.
CRUD İşlemleri: Veritabanında oluşturma, okuma, güncelleme ve silme işlemlerini standardize eder.
Migrations: Veritabanı şemasındaki değişiklikleri takip etmek ve yönetmek için kullanılır.
N-Katmanlı Mimari: Projenin modüler, yeniden kullanılabilir ve bakımı kolay olması için kullanılır.

Bu özet, projenin ana özelliklerini ve avantajlarını öne çıkarırken, detayları ve teknik jargonu minimize eder.
Bu mimari yapı ve kullanılan teknoloji ile birlikte , daha kapsamlı projeleri yapabilir ve geliştirebiliriz. Örnek olması amacıyla bu şekilde paylaşmak istedim.Özellikle web tabanlı (örnek olarak ASP.Net )
uygulamalar için güzel , temiz ve anlaşılır bir mimari yapıya sahiptir. 
