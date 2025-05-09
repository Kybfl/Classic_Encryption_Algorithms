🔐 Cryptology Project

This is a Windows Forms application built with C#, designed to demonstrate various classical encryption algorithms through a user-friendly graphical interface. The project serves as both an educational tool and a functional encryption demo platform.

🧩 Features

Login Screen:

![Ekran görüntüsü 2025-05-09 231138](https://github.com/user-attachments/assets/4710e233-783e-4361-8f8e-9b1e5f69ea1a)






  The application starts with a basic login form requiring a username and password. This adds a simple layer of access control before using the main features.


Main Page:
![Ekran görüntüsü 2025-05-09 231134](https://github.com/user-attachments/assets/ed88a225-6303-41cf-8ee9-392b02d6213d)




  After login, users are greeted with a main menu offering 10 different encryption algorithm options, displayed in a clean and organized layout. Language support (TR/EN) is available for bilingual interaction.

Supported Algorithms:

  * Shift Cipher
  * Transposition Cipher
  * Numeric Key Cipher
  * Rail Fence Cipher
  * 4 Square Cipher
  * Linear Cipher
  * Permutation Cipher
  * Rotation Cipher
  * Vigenère Cipher
  * Hill Cipher

Each algorithm opens in its own form, allowing the user to input plaintext, specify keys (if needed), and view the encrypted result. Some algorithms also support decryption.

 🧠 Technical Highlights

* Turkish alphabet support is included for all algorithms.
* Global character mapping dictionaries (`Globals.cs`) are used for consistency across ciphers.
* Random key generation (e.g., for 4 Square) is implemented with GUI feedback via list boxes.
* No external libraries are used—everything is written using pure C# and .NET Windows Forms.

 🎓 Purpose

This project was developed for educational purposes in the field of classical cryptography. It helps users understand how each cipher manipulates the input text and demonstrates the importance of key management in secure communication.

---------------------------------------------------------------------------------------------------------------------------------------------

 🔐 Kriptoloji Projesi

Bu proje, klasik şifreleme algoritmalarını görsel arayüz ile tanıtan, C# ve Windows Forms kullanılarak geliştirilmiş bir uygulamadır. Hem öğretici hem de işlevsel bir şifreleme platformu olarak tasarlanmıştır.

 🧩 Özellikler

Giriş Ekranı:
  Uygulama kullanıcı adı ve şifre isteyen basit bir giriş ekranıyla başlar. Bu ekran, temel bir erişim kontrolü sağlar.

Ana Menü:
  Giriş sonrası kullanıcıyı, 10 farklı şifreleme algoritmasının bulunduğu şık ve düzenli bir ana ekran karşılar. TR ve EN dil desteği mevcuttur.

Desteklenen Algoritmalar:

  * Shift (Kaydırma)
  * Transposition (Yer Değiştirme)
  * Numeric Key (Sayısal Anahtar)
  * Rail Fence
  * 4 Square
  * Linear
  * Permutation (Permütasyon)
  * Rotation (Rotasyon)
  * Vigenère
  * Hill

Her algoritma için ayrı form ekranı bulunur. Kullanıcılar metin girip, gerekli anahtarları tanımlayarak şifreli çıktıyı elde edebilir. Bazı algoritmalarda şifre çözme işlemi de desteklenir.

 🧠 Teknik Ayrıntılar

* Tüm algoritmalarda Türk alfabesi desteği vardır.
* `Globals.cs` sınıfında tanımlı sözlüklerle harf indeksleme işlemleri merkezi olarak yapılır.
* 4 Kare gibi algoritmalarda rastgele anahtar üretimi ve görsel yansıtma (ListBox) desteği bulunur.
* Her şey saf C# ve .NET Windows Forms ile yazılmıştır, dış kütüphane kullanılmaz.

 🎓 Proje Amacı

Bu uygulama, klasik şifreleme yöntemlerini öğrenmek ve öğretmek için geliştirilmiştir. Şifreleme sürecini adım adım görmek isteyenler için interaktif bir eğitim aracıdır.

