set STATISTICS  IO off
set STATISTICS  time off
insert into tblMusteri( MusteriNumarasi, OlusturmaTarihi, Adi, Soyadi, DogumTarihi, Cinsiyet, Email, CepTelefonuKodu, CepTelefonu, IsPersonel)
select top (400000) MusteriNumarasi, OlusturmaTarihi, Adi, Soyadi, DogumTarihi, Cinsiyet, Email, CepTelefonuKodu, CepTelefonu, IsPersonel
from tblMusteri
--indexsiz çalışma
--  cPU : 293 ms , Server : 156 ms , logic read - > 21451
set STATISTICS  IO on
set STATISTICS  time on
select COUNT(*) from tblMusteri
select * from tblMusteri  where adi ='Rafi'
-- index ile çalışma
-- CPU 0 MS , Server 0 Ms, Logic read -> 480
select * from tblMusteri where Id =58012


/*
Indexli fakat fragma olmuş data  516 Ms
logic read - > 879
*/

drop 


IF EXISTS (SELECT name FROM sys.indexes  
            WHERE name = N'IX_tblMusteri_Adi')   
    DROP INDEX IX_tblMusteri_Adi ON tblMusteri.Adi; 
CREATE NONCLUSTERED INDEX IX_tblMusteri_Adi   
    ON tblMusteri(Adi);  