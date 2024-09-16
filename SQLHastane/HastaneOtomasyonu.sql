-- Yetkiler Tablosu
CREATE TABLE Yetkiler (
    YetkiID INT PRIMARY KEY,
    YetkiAdi VARCHAR(50) NOT NULL
);

-- �rnek yetki verileri ekleyelim
INSERT INTO Yetkiler (YetkiID, YetkiAdi) VALUES (1, 'Y�netici');
INSERT INTO Yetkiler (YetkiID, YetkiAdi) VALUES (2, 'Doktor');
INSERT INTO Yetkiler (YetkiID, YetkiAdi) VALUES (3, 'Hem�ire');

-- Kullan�c�Kayit Tablosu
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

-- �rnek fiyat bilgileri ekleyelim
INSERT INTO Fiyatlar (YapilanIslem, Ucret) VALUES
('Muayene', 100.00),
('Tetkik', 75.00);

-- UygulananIslemler Tablosu
CREATE TABLE UygulananIslemler (
    IslemID INT PRIMARY KEY,
    IslemAdi VARCHAR(255) NOT NULL
);

-- �rnek i�lem bilgileri ekleyelim
INSERT INTO UygulananIslemler (IslemID, IslemAdi) VALUES
(1, '��lem 1'),
(2, '��lem 2'),
(3, '��lem 3'),
(4, '��lem 4'),
(5, '��lem 5');

-- B�lumler Tablosu
CREATE TABLE Bolumler (
    BolumID INT PRIMARY KEY,
    BolumAdi VARCHAR(255) NOT NULL
);

-- �rnek b�l�m bilgileri ekleyelim
INSERT INTO Bolumler (BolumID, BolumAdi) VALUES
(1, 'B�l�m 1'),
(2, 'B�l�m 2'),
(3, 'B�l�m 3'),
(4, 'B�l�m 4'),
(5, 'B�l�m 5');

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
