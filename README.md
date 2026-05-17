# ✈️ Travel Trip Project

> **ASP.NET MVC 5** ile geliştirilmiş, seyahat tutkunları için dinamik bir seyahat blog ve yönetim sistemi.

![ASP.NET MVC](https://img.shields.io/badge/ASP.NET%20MVC-5-blue?style=for-the-badge&logo=dotnet)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-Code%20First-purple?style=for-the-badge)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5-7952B3?style=for-the-badge&logo=bootstrap)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoftsqlserver)

---

## 📌 Proje Hakkında

**Travel Trip**, seyahat destinasyonlarını keşfetmeyi, blog yazıları okumayı ve admin paneli aracılığıyla tüm içerikleri yönetmeyi sağlayan tam kapsamlı bir web uygulamasıdır.

Ziyaretçiler; destinasyonları, blog yazılarını ve şirket hakkında bilgileri keşfedebilirken, yöneticiler güvenli bir admin paneli üzerinden tüm içerikleri (CRUD) kolayca yönetebilir.

---

## 🚀 Özellikler

### 🌐 Kullanıcı Tarafı
- 🏠 **Ana Sayfa** – Dinamik hero alanı ve öne çıkan içerikler
- 🗺️ **Destinasyonlar** – Top 10 ve En İyi Yerler listeleri
- 📝 **Blog** – Seyahat yazıları ve yorum sistemi
- ℹ️ **Hakkımızda** – Şirket ve ekip tanıtımı
- 📬 **İletişim** – Mesaj gönderme formu

### 🔐 Admin Paneli
- 📊 **Dashboard** – Blog, destinasyon ve mesaj sayılarının anlık görüntülenmesi
- ✏️ **Blog Yönetimi** – Blog ekleme, düzenleme, silme
- 📍 **Destinasyon Yönetimi** – Yer ekleme, düzenleme, silme; Top 10 & En İyi Yer etiketleme
- 💬 **Yorum Yönetimi** – Blog yorumlarını görüntüleme ve silme
- 📩 **Mesaj Yönetimi** – İletişim formundan gelen mesajları okuma ve silme
- 🏠 **Ana Sayfa Yönetimi** – Hero içeriklerini düzenleme
- ℹ️ **Hakkımızda Yönetimi** – Hakkımızda bölümünü güncelleme

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|---|---|
| **ASP.NET MVC 5** | Uygulama mimarisi |
| **C#** | Backend programlama dili |
| **Entity Framework 6 (Code First)** | ORM ve veritabanı yönetimi |
| **SQL Server** | Veritabanı |
| **Bootstrap 5** | Responsive UI framework |
| **Glassmorphism CSS** | Modern arayüz tasarımı |
| **Font Awesome** | İkon kütüphanesi |
| **Forms Authentication** | Admin güvenlik sistemi |
| **Razor View Engine** | Şablon motoru |
| **Partial Views** | Modüler sayfa yapısı |

---

## 🗄️ Veritabanı Modelleri

```
📦 Models
 ┣ 📄 About.cs         → Hakkımızda içerikleri
 ┣ 📄 Address.cs       → Adres bilgileri
 ┣ 📄 Admin.cs         → Admin kullanıcı bilgileri
 ┣ 📄 Blog.cs          → Blog yazıları
 ┣ 📄 BlogComment.cs   → Blog yorumları (ilişkisel)
 ┣ 📄 Comments.cs      → Yorum yönetimi
 ┣ 📄 Contact.cs       → İletişim formu mesajları
 ┣ 📄 Country.cs       → Ülkeler
 ┣ 📄 Destination.cs   → Destinasyonlar (Country ile ilişkili)
 ┣ 📄 Home.cs          → Ana sayfa içerikleri
 ┗ 📄 Context.cs       → Entity Framework DbContext
```

---

## 📁 Proje Yapısı

```
Travel_Trip_Project/
│
├── Controllers/
│   ├── AdminController.cs         # Tüm admin CRUD işlemleri
│   ├── AdminLoginController.cs    # Güvenli giriş/çıkış
│   ├── DefaultController.cs       # Kullanıcı ana sayfası
│   ├── BlogController.cs          # Blog listeleme
│   ├── CommentController.cs       # Yorum işlemleri
│   ├── ContactController.cs       # İletişim formu
│   └── AboutController.cs         # Hakkımızda sayfası
│
├── Models/Classes/
│   └── (Tüm entity sınıfları + Context.cs)
│
├── Views/
│   ├── Admin/                     # Admin panel sayfaları
│   ├── AdminLogin/                # Giriş ekranı
│   ├── Default/                   # Ana sayfa
│   ├── Blog/                      # Blog sayfaları
│   ├── Comment/                   # Yorum sayfaları
│   ├── Contact/                   # İletişim sayfası
│   ├── About/                     # Hakkımızda sayfası
│   └── Shared/                    # Layout ve Partial Views
│
├── Migrations/                    # EF Code First migration dosyaları
└── Web.config                     # Uygulama yapılandırması
```

---

## ⚙️ Kurulum ve Çalıştırma

### Gereksinimler
- Visual Studio 2019 veya üzeri
- .NET Framework 4.7.2+
- SQL Server (LocalDB veya Express)

### Adımlar

**1. Repoyu klonlayın:**
```bash
git clone https://github.com/kullanici-adi/Travel_Trip_Project.git
```

**2. Visual Studio'da açın:**
```
Travel_Trip_Project.sln dosyasını açın
```

**3. Veritabanını oluşturun:**

`Package Manager Console`'u açın ve şu komutları çalıştırın:
```powershell
Update-Database
```

**4. Uygulamayı çalıştırın:**
```
F5 veya Ctrl+F5
```

---

## 🔑 Admin Girişi

Admin paneline erişmek için:

```
URL: /AdminLogin/Login
```

> ⚠️ Admin bilgileri veritabanına seed data olarak eklenmelidir.

---

## 📸 Ekran Görüntüleri

> *(Projenizin ekran görüntülerini buraya ekleyebilirsiniz)*

| Sayfa | Açıklama |
|---|---|
| Ana Sayfa | Dinamik hero ve destinasyon bölümleri |
| Admin Dashboard | İstatistik kartları ve hızlı erişim menüsü |
| Destinasyon Listesi | Top 10 ve En İyi Yer yönetimi |
| Blog Yönetimi | CRUD işlemleri |

---

## 💡 Öğrenilen Konular

Bu proje kapsamında şu konularda deneyim kazanıldı:

- ✅ ASP.NET MVC 5 mimari yapısı (Model-View-Controller)
- ✅ Entity Framework Code First yaklaşımı
- ✅ CRUD (Create, Read, Update, Delete) operasyonları
- ✅ Forms Authentication ile güvenli oturum yönetimi
- ✅ Partial View ile modüler sayfa tasarımı
- ✅ Bootstrap 5 ile responsive arayüz geliştirme
- ✅ Glassmorphism efektli modern UI tasarımı
- ✅ Ülke-Destinasyon gibi ilişkisel veritabanı yapıları
- ✅ ViewBag ile View'a dinamik veri aktarımı

---

## 📄 Lisans

Bu proje eğitim amaçlı geliştirilmiştir.

---

<div align="center">
  <p>⭐ Projeyi beğendiyseniz yıldız vermeyi unutmayın!</p>
  <p>Geliştirici: <strong>Esra Oğuz</strong></p>
</div>
