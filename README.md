# CHaos - Uygulama Engelleyici (App Blocker)

CHaos, bilgisayarınızda çalışmasını istemediğiniz uygulamaları (çalıştırılabilir `.exe` dosyalarını) seçerek çalışmalarını engelleyen ve arka planda bu uygulamaları otomatik olarak kapatan bir Windows masaüstü yazılımıdır. Aynı zamanda engellenen uygulamaların kaydını tutar ve bu kayıtları PDF olarak dışa aktarmanıza olanak tanır.

## 🚀 Özellikler

- **Uygulama Ekleme/Çıkarma:** İstenilen `.exe` uzantılı dosyaları dosya seçici ile kolayca listeye ekleme ve listeden kaldırma.
- **Dinamik İkon Desteği:** Eklenen uygulamaların orijinal simgelerini (ikonlarını) otomatik olarak çekerek listede gösterir.
- **Otomatik Engelleme:** Engelleme başlatıldığında, seçili olan programların arka planda çalışıp çalışmadığını denetler ve yakaladığı an kapatır (Kill process).
- **Gerçek Zamanlı Log (Kayıt) Sistemi:** Hangi uygulamanın saat kaçta kapatıldığını anlık olarak kaydeder ve özel bir Log Ekranı'nda gösterir.
- **PDF Raporlama:** Tutulan uygulama engelleme geçmişini (logları) tarih ve saat damgasıyla birlikte PDF dosyası olarak bilgisayarınıza kaydeder.
- **Modern Arayüz:** Guna UI2 kütüphanesi kullanılarak tasarlanmış modern ve kullanıcı dostu arayüz.

## 📋 Gereksinimler ve Bağımlılıklar

Bu projeyi derlemek ve geliştirmek için aşağıdaki kütüphanelerin (NuGet paketlerinin) projenizde kurulu olması gerekmektedir:

- `Guna.UI2.WinForms`: Arayüz tasarımı, özel butonlar ve checkbox'lar için.
- `iText7` (ve `iText.Kernel`, `iText.Layout`, `iText.IO`): Log kayıtlarını PDF olarak dışa aktarmak için.

## 📖 Kullanım Kılavuzu

1. **Uygulama Ekleme:**
   - Ekranda bulunan "Uygulama Ekle" butonuna tıklayın.
   - Açılan dosya penceresinden engellemek istediğiniz `.exe` dosyasını seçin.
   - Uygulama, kendi simgesiyle birlikte ana ekrandaki listeye eklenecektir.

2. **Engellemeyi Başlatma:**
   - Listeye eklediğiniz uygulamalardan engellemek istediklerinizin yanındaki kutucuğu (checkbox) işaretleyin.
   - "Engellemeyi Başlat" butonuna tıklayın.
   - Program arka planda çalışmaya başlayacak ve işaretli uygulamalar açılmaya çalışıldığı an kapatılacaktır. Arayüz bu süreçte kilitlenir.

3. **Engellemeyi Durdurma:**
   - "Engellemeyi Durdur" butonuna basarak işlemi sonlandırabilir ve arayüzü tekrar aktif hale getirebilirsiniz.

4. **Uygulama Kaldırma:**
   - Listeden çıkarmak istediğiniz uygulamanın kutucuğunu işaretleyin ve "Uygulama Kaldır" butonuna basın.

5. **Logları Görüntüleme ve PDF'e Aktarma:**
   - "Log Menüsü" butonuna tıklayarak kapatılan uygulamaların geçmişini canlı olarak görebilirsiniz.
   - "PDF'e Aktar" butonuna tıklayarak mevcut olay geçmişini istediğiniz bir dizine `.pdf` formatında kaydedebilirsiniz.

## ⚠️ Uyarılar

- Program, seçili olan `.exe` dosyalarını zorla (Force Kill) kapatmaktadır. Eğer engellenen programın içinde kaydedilmemiş verileriniz varsa, bu veriler kaybolabilir.
- Programın bazı sistem dosyalarını engellemesini önlemek için yalnızca kullanıcı düzeyindeki yazılımları seçmeye özen gösterin.

## 🛠️ Teknik Altyapı

- **Dil:** C# (.NET Framework / .NET Core WinForms)
- **Loglama:** Sınıf içi liste (`List<string> olayGecmisi`) ve formlar arası veri aktarımı.
- **İşlem Yönetimi:** `System.Diagnostics.Process` sınıfı üzerinden PID ve süreç takibi.

---
*Bu proje eğitim ve kişisel kullanım amacıyla geliştirilmiştir.*
