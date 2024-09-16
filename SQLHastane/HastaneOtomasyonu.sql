-- Yetkiler Tablosu
CREATE TABLE Yetkiler (
    YetkiID INT PRIMARY KEY,
    YetkiAdi VARCHAR(50) NOT NULL
);

-- Örnek yetki verileri ekleyelim
INSERT INTO Yetkiler (YetkiID, YetkiAdi) VALUES (1, 'Yönetici');
INSERT INTO Yetkiler (YetkiID, YetkiAdi) VALUES (2, 'Doktor');
INSERT INTO Yetkiler (YetkiID, YetkiAdi) VALUES (3, 'Hemþire');

-- KullanýcýKayit Tablosu
CREATE TABLE KullaniciKayit (
    KullaniciID INT PRIMARY KEY,
    Ad VARCHAR(255) NOT NULL,
    Soyad VARCHAR(255) NOT NULL,
    TC VARCHAR(11) NOT NULL,
    Numara VARCHAR(15) NOT NULL,
    Cinsiyet VARCHAR(10) NOT NULL,
    YetkiID INT,
    FOREIGN KEY (YetkiID) REFERENCES Yetkiler(YetkiID)
);

-- Fiyatlar Tablosu
CREATE TABLE Fiyatlar (
    YapilanIslem VARCHAR(255) PRIMARY KEY,
    Ucret DECIMAL(10, 2) NOT NULL
);

-- Örnek fiyat bilgileri ekleyelim
INSERT INTO Fiyatlar (YapilanIslem, Ucret) VALUES
('Muayene', 100.00),
('Tetkik', 75.00);

-- UygulananIslemler Tablosu
CREATE TABLE UygulananIslemler (
    IslemID INT PRIMARY KEY,
    IslemAdi VARCHAR(255) NOT NULL
);

-- Örnek iþlem bilgileri ekleyelim
INSERT INTO UygulananIslemler (IslemID, IslemAdi) VALUES
(1, 'Ýþlem 1'),
(2, 'Ýþlem 2'),
(3, 'Ýþlem 3'),
(4, 'Ýþlem 4'),
(5, 'Ýþlem 5');

-- Bölumler Tablosu
CREATE TABLE Bolumler (
    BolumID INT PRIMARY KEY,
    BolumAdi VARCHAR(255) NOT NULL
);

-- Örnek bölüm bilgileri ekleyelim
INSERT INTO Bolumler (BolumID, BolumAdi) VALUES
(1, 'Bölüm 1'),
(2, 'Bölüm 2'),
(3, 'Bölüm 3'),
(4, 'Bölüm 4'),
(5, 'Bölüm 5');

-- DoktorKayit Tablosu
CREATE TABLE DoktorKayit (
    DoktorID INT PRIMARY KEY,
    Ad VARCHAR(255) NOT NULL,
    Soyad VARCHAR(255) NOT NULL,
    TC VARCHAR(11) NOT NULL,
    Numara VARCHAR(15) NOT NULL,
    Cinsiyet VARCHAR(10) NOT NULL,
    BolumID INT,
    FOREIGN KEY (BolumID) REFERENCES Bolumler(BolumID)
);

-- HastaKayit Tablosu
CREATE TABLE HastaKayit (
    HastaID INT PRIMARY KEY,
    Ad VARCHAR(255) NOT NULL,
    Soyad VARCHAR(255) NOT NULL,
    TC VARCHAR(11) NOT NULL,
    Numara VARCHAR(15) NOT NULL,
    Cinsiyet VARCHAR(10) NOT NULL,
    YapilanIslemID INT,
    BolumID INT,
    DoktorID INT,
    Ucret DECIMAL(10, 2),
    FOREIGN KEY (YapilanIslemID) REFERENCES UygulananIslemler(IslemID),
    FOREIGN KEY (BolumID) REFERENCES Bolumler(BolumID),
    FOREIGN KEY (DoktorID) REFERENCES DoktorKayit(DoktorID)
);

-- AcilKayit Tablosu
CREATE TABLE AcilKayit (
    AcilID INT PRIMARY KEY,
    Ad VARCHAR(255) NOT NULL,
    Soyad VARCHAR(255) NOT NULL,
    TC VARCHAR(11) NOT NULL,
    Numara VARCHAR(15) NOT NULL,
    Cinsiyet VARCHAR(10) NOT NULL,
    YapilanIslemID INT,
    Ucret DECIMAL(10, 2),
    FOREIGN KEY (YapilanIslemID) REFERENCES UygulananIslemler(IslemID)
);
