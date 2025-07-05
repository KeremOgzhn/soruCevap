# Soru-Cevap Programı

Bu proje, kullanıcıların soru ekleyebileceği ve sınav yapabileceği bir masaüstü uygulamasıdır. C# Windows Forms kullanılarak geliştirilmiştir.

## 🚀 Özellikler

- **Kişi Yönetimi**: Sınava katılacak kişileri sisteme kaydetme
- **Soru Yönetimi**: Çoktan seçmeli sorular ekleme ve görüntüleme
- **Sınav Sistemi**: Kayıtlı kullanıcıların sınav yapabilmesi
- **Sonuç Takibi**: Sınav sonuçlarını görüntüleme ve takip etme
- **Veritabanı Entegrasyonu**: SQL Server ile tam entegrasyon

## 🛠️ Teknoloji Yığını

- **Platform**: .NET Framework 4.7.2
- **Dil**: C#
- **UI Framework**: Windows Forms
- **Veritabanı**: Microsoft SQL Server
- **IDE**: Visual Studio

## 📋 Sistem Gereksinimleri

- Windows 7 veya üzeri
- .NET Framework 4.7.2 veya üzeri
- Microsoft SQL Server (Express Edition yeterli)
- Visual Studio 2015 veya üzeri (geliştirme için)

## 🗄️ Veritabanı Kurulumu

1. **SQL Server Kurulumu**: Microsoft SQL Server'ın kurulu olduğundan emin olun
2. **Veritabanı Oluşturma**: `SoruCevapProgrami/veri tabanı/soruCevap.sql` dosyasını SQL Server'da çalıştırın
3. **Bağlantı Ayarları**: `Baglanti.cs` dosyasındaki connection string'i kendi SQL Server ayarlarınıza göre düzenleyin

```csharp
// Baglanti.cs dosyasında
SqlConnection con = new SqlConnection("server = .; initial catalog = scDB; integrated security = sspi");
```

### Veritabanı Tabloları

- **Kisiler**: Sistem kullanıcıları (ID, adSoyad, meslek)
- **Sorular**: Sınav soruları (ID, soruMetni, aSec, bSec, cSec, dSec, dogruCevap)
- **Sinavlar**: Sınav sonuçları (ID, kisiID, tarih, puan)
- **login**: Giriş bilgileri
- **tblDers**: Ders bilgileri
- **tblOgrenci**: Öğrenci bilgileri

## 📦 Kurulum

1. **Repository'yi klonlayın**:
   ```bash
   git clone https://github.com/KeremOgzhn/soruCevap.git
   ```

2. **Visual Studio'da açın**:
   - `SoruCevapProgrami/soruCevapPro.sln` dosyasını Visual Studio ile açın

3. **Veritabanını kurun**:
   - Yukarıdaki veritabanı kurulum adımlarını takip edin

4. **Projeyi derleyin**:
   - Solution'ı rebuild edin (Build → Rebuild Solution)

5. **Uygulamayı çalıştırın**:
   - F5 tuşuna basın veya Debug → Start Debugging

## 📖 Kullanım Kılavuzu

### Ana Menü
Uygulama açıldığında ana menü görüntülenir. Bu menüden şu işlemler yapılabilir:

1. **Sınav Yap**: Mevcut kullanıcılar sınav yapabilir
2. **Kişi Ekle**: Yeni kullanıcı kaydı
3. **Soru Ekle**: Sisteme yeni sorular ekleme
4. **Kişiler**: Kayıtlı kullanıcıları görüntüleme
5. **Sorular**: Sistemdeki soruları görüntüleme
6. **Sonuçlar**: Sınav sonuçlarını görüntüleme

### Sınav Yapma
1. Ana menüden "Sınav Yap" seçeneğini tıklayın
2. Ad ve soyadınızı girin (sistemde kayıtlı olmalısınız)
3. Sınav otomatik olarak başlayacaktır
4. Her soru için A, B, C, D seçeneklerinden birini seçin
5. "Onayla" butonuna tıklayarak sonraki soruya geçin
6. Sınav bitiminde puanınız görüntülenecektir

### Soru Ekleme
1. Ana menüden "Soru Ekle" seçeneğini tıklayın
2. Soru metnini girin
3. A, B, C, D seçeneklerini doldurun
4. Doğru cevabı (A, B, C veya D) belirtin
5. "Kaydet" butonuna tıklayın

### Kişi Ekleme
1. Ana menüden "Kişi Ekle" seçeneğini tıklayın
2. Ad ve soyad bilgisini girin
3. Meslek bilgisini girin
4. "Kaydet" butonuna tıklayın

## 📁 Proje Yapısı

```
SoruCevapProgrami/
├── soruCevapPro/
│   ├── Form1.cs                 # Ana menü formu
│   ├── SinavYap.cs             # Sınav giriş formu
│   ├── SinavStart.cs           # Sınav uygulama formu
│   ├── SoruEkle.cs             # Soru ekleme formu
│   ├── KisiEkle.cs             # Kişi ekleme formu
│   ├── Kisiler.cs              # Kişileri görüntüleme formu
│   ├── Sorular.cs              # Soruları görüntüleme formu
│   ├── Sonuclar.cs             # Sonuçları görüntüleme formu
│   ├── Baglanti.cs             # Veritabanı bağlantı sınıfı
│   ├── Program.cs              # Uygulama giriş noktası
│   └── Properties/             # Proje özellikleri
├── veri tabanı/
│   └── soruCevap.sql          # Veritabanı oluşturma scripti
└── soruCevapPro.sln           # Visual Studio solution dosyası
```

## 🔧 Geliştirme

### Yeni Özellik Ekleme
1. Mevcut form yapısını takip edin
2. Veritabanı değişiklikleri için migration scriptleri hazırlayın
3. `Baglanti.cs` sınıfını kullanarak veritabanı işlemlerini gerçekleştirin

### Veritabanı Bağlantısı
Tüm veritabanı işlemleri `Baglanti.cs` sınıfı üzerinden yapılmaktadır:

```csharp
public static SqlConnection baglan()
{
    SqlConnection con = new SqlConnection("server = .; initial catalog = scDB; integrated security = sspi");
    con.Open();
    return con;
}
```

## 📝 Notlar

- Uygulama Türkçe arayüze sahiptir
- Tüm kullanıcı etkileşimleri Windows Forms ile gerçekleştirilir
- Veritabanı bağlantısı Windows Authentication kullanır
- Sınav sistemi çoktan seçmeli soru formatını destekler

## 🤝 Katkıda Bulunma

1. Bu repository'yi fork edin
2. Yeni bir feature branch oluşturun (`git checkout -b feature/YeniOzellik`)
3. Değişikliklerinizi commit edin (`git commit -am 'Yeni özellik eklendi'`)
4. Branch'inizi push edin (`git push origin feature/YeniOzellik`)
5. Pull Request oluşturun

## 📄 Lisans

Bu proje açık kaynak kodludur ve MIT lisansı altında dağıtılmaktadır.

## 👤 Geliştirici

**Kerem Oğuzhan**
- GitHub: [@KeremOgzhn](https://github.com/KeremOgzhn)

---

Bu README dosyası projenin genel yapısını ve kullanımını açıklamaktadır. Daha detaylı bilgi için kaynak kodları inceleyebilirsiniz.