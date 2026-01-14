# Stok ve Satış Takip Sistemi

# Proje Açıklaması
Bu proje, küçük ve orta ölçekli işletmelerde ürün, müşteri ve satış işlemlerinin takibini kolaylaştırmak amacıyla geliştirilmiştir.  
Uygulama C# WinForms kullanılarak hazırlanmış olup MySQL veritabanı ile çalışmaktadır.

Projenin temel amacı; stok takibi, satış kayıtları ve raporlama işlemlerini tek bir sistem üzerinden yönetebilmektir.  
Aynı zamanda bu proje, katmanlı mimari yapısını ve nesne yönelimli programlama (OOP) kavramlarını uygulamak amacıyla geliştirilmiştir.



# Kullanıcı Rolleri
Uygulamada farklı yetkilere sahip kullanıcılar bulunmaktadır:

- **Yönetici**
  - Tüm modüllere erişebilir
  - Raporları görüntüleyebilir

- **Satış Personeli**
  - Satış işlemleri yapar
  - Ürün listesini görüntüler

- **Depo Görevlisi**
  - Ürün ekleme ve stok güncelleme işlemlerini yapar



# Katmanlı Mimari Yapısı
Proje, 3 katmanlı mimari kullanılarak geliştirilmiştir:

- **Veri Erişim Katmanı (DAL)**
  - MySQL veritabanı bağlantısı burada yapılır
  - Veritabanı sorguları bu katmanda yer alır

- **İş Katmanı (BLL)**
  - Uygulamanın iş kuralları burada tanımlanmıştır

- **Sunum Katmanı (UI)**
  - WinForms arayüzleri bu katmanda yer alır
  - Kullanıcı etkileşimleri bu katman üzerinden sağlanır



# Temel Ekranlar
Uygulamada yer alan başlıca ekranlar şunlardır:

- **Giriş Ekranı**
  - Kullanıcı adı ve şifre ile giriş yapılır
  - Kullanıcı rolüne göre yetkilendirme uygulanır

- **Ürün Yönetimi**
  - Ürün ekleme, düzenleme ve silme işlemleri
  - Minimum stok uyarıları

- **Müşteri Yönetimi**
  - Müşteri ekleme ve listeleme
  - Perakende ve toptan müşteri ayrımı

- **Satış Ekranı**
  - Müşteri ve ürün seçimi
  - Satış sonrası stok miktarının güncellenmesi

- **Raporlama Ekranı**
  - Satış ve stok ile ilgili raporların görüntülenmesi



# Raporlama Özellikleri
Uygulama içerisinde aşağıdaki raporlar yer almaktadır:

- Aylık satış raporu  
- En çok satılan ürünler  
- Müşteri bazlı satış raporları  
- Kâr / zarar hesaplamaları  
- Minimum stok seviyesinin altındaki ürünler  



# Nesne Yönelimli Programlama (OOP)
Projede temel OOP prensipleri uygulanmıştır:

- Sınıf yapıları (Product, Customer, vb.)
- Kapsülleme 
- Arayüzler 


# (Opsiyonel) Diyagram
-Github sayfasında bir diyagram.png dosyası bulunmaktadır. Bu png dosyası, projenin geliştirme aşamasında izlenilen yol haritasını ve temel özelliklerini görsel olarak özetlemektedir. 
-Diyagram projenin son halini yansıtmayabilir ancak projenin genel yapısı ve işleyişi hakkında fikir vermektedir.



# Kurulum ve Çalıştırma
1. Projeler dosyası bilgisayara indirilir veya klonlanır    
2. Data Base'e bağlanılabilmesi için vpn ile vpn.uludag.edu.tr adresine bağlanılır 
3. Proje Visual Studio ile açılır 

#Youtube
Projenin tanıtım videosuna [buradan ulaşabilirsiniz](https://youtu.be/TqF7h4yATlo).

# Not
Bu proje eğitim amaçlı geliştirilmiştir.
Kullanıcı şifreleri 12345 olarak belirlenmiştir.
