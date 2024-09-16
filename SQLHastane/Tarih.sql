-- HastaKayit Tablosuna Tarih Ekle
ALTER TABLE HastaKayit
ADD Tarih DATETIME DEFAULT GETDATE();

-- AcilKayit Tablosuna Tarih Ekle
ALTER TABLE AcilKayit
ADD Tarih DATETIME DEFAULT GETDATE();

-- DoktorKayit Tablosuna Tarih Ekle
ALTER TABLE DoktorKayit
ADD Tarih DATETIME DEFAULT GETDATE();

-- KullaniciKayit Tablosuna Tarih Ekle
ALTER TABLE KullaniciKayit
ADD Tarih DATETIME DEFAULT GETDATE();
