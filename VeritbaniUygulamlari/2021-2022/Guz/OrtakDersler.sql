/*
	1-Veritabanı yedek alma, script olustuma ve detach - attach
	2-Stored procedure
	3-Function
*/

/*

 cursor --
 transcation
 trigger
 index- olusturma yontemleri
 view - joinler (bunları detaylandırma)
  having gibi üst segment sorgularına bakalım
 Güvenlik önlemlerine bakalım

*/

/*
	Cursor Nedir ?


*/
use DbTicaret2021Guz

-- %30
update tblMusteri set Maasi = Maasi *1.3
where  Maasi>3000 and Maasi <4000

select * from tblMusteri

--%25
update tblMusteri set Maasi = Maasi *1.25
where  Maasi>4000 and Maasi <=5000

--%10
update tblMusteri set Maasi = Maasi *1.10
where  Maasi>5000 and Maasi <=6000

--%5
update tblMusteri set Maasi = Maasi *1.05
where  Maasi>6000

/*
 
 
declare @Id int , @Maasi money 

DECLARE crsMusteriMaasGuncelle CURSOR FOR 

SELECT Id,Maasi FROM tblMusteri -- where koşul yazabiliriz


OPEN crsMusteriMaasGuncelle   -- cursorı açıyoruz

FETCH NEXT FROM crsMusteriMaasGuncelle INTO @Id,@Maasi   -- ilk degeri alıyoruz

-- @Id alanı ve @Maasi  tbl musterideki sıraya göre geliyor ve ilk degeri almış alıyoruz ?
WHILE @@FETCH_STATUS = 0  
BEGIN  
		--%25
		if(@Maasi > 4000 and @Maasi <=5000)
		begin
			update tblMusteri set Maasi = Maasi *1.25
			where  Id = @Id
		end
		else if(@Maasi >5000 and @Maasi <=6000)
		begin
					--%10
			update tblMusteri set Maasi = Maasi *1.10
			where  @Maasi>5000 and @Maasi <=6000 and Id =@Id
		end
		else if (@Maasi >6000)
		begin	
			--%5
			update tblMusteri set Maasi = Maasi *1.05
			where  Maasi>6000
		end

      FETCH NEXT FROM crsMusteriMaasGuncelle INTO @Id,@Maasi 
END 

CLOSE crsMusteriMaasGuncelle  
DEALLOCATE crsMusteriMaasGuncelle 


select * from tblMusteri

*/


/*

	Nortwind Database,

	Urunlerin birim  fiyatını

	0-10 TL arası %50 zam
	10-20 arası %40 zam
	20-30 arası %30 ZAM
	30-40 arası %20 ZAM
	40 ve üzerine %10 zam

*/


/*

*/

/*
	Banka tablosunda müşterilerde K kadın ve E Erkek bunları  gösterelim


	case kullanımı
*/

use DbBanka2021Guz1O

-- En genç Erkekler

select Top 10  Id,MusteriNumarasi,Adi,Soyadi, 
	Case Cinsiyet when 'K' then 'Kadın' when 'E' then 'Erkek' else 'Belirtilmemiş' end,
	m.Email,DogumTarihi
from tblMusteri m
where Cinsiyet = 'E' 


Union all

select Top 10  Id,MusteriNumarasi,Adi,Soyadi, 
	Case Cinsiyet when 'K' then 'Kadın' when 'E' then 'Erkek' else 'Belirtilmemiş' end,
	m.Email,DogumTarihi
from tblMusteri m
where Cinsiyet = 'E' 

Union all

select Top 10  Id,MusteriNumarasi,Adi,Soyadi, 
	Case Cinsiyet when 'K' then 'Kadın' when 'E' then 'Erkek' else 'Belirtilmemiş' end,
	m.Email,DogumTarihi
from tblMusteri m
where Cinsiyet = 'K'  

Union all

select Top 10  Id,MusteriNumarasi,Adi,Soyadi, 
	Case Cinsiyet when 'K' then 'Kadın' when 'E' then 'Erkek' else 'Belirtilmemiş' end,
	m.Email,DogumTarihi
from tblMusteri m
where Cinsiyet = 'K' 






-- En yaşlı ve En genç 10 Erkeke ve kadını gösteren sorguyu yazalım

