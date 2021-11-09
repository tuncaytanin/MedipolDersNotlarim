
declare @KayitSayisi int ,@MaxId int, @RastgeleId int , @Varmi int
declare @Adi nvarchar(100), @Soyadi nvarchar(100), @Email nvarchar(100), @Cinsiyet char(1), @MusteriNumaraasi varchar(12), @DogumTarihi date, @CepTelefonuKodu varchar(6) , @CepTelefonu char(10)

set @KayitSayisi = 50000



while  @KayitSayisi > 0
begin

	set @MaxId = (select max(Id) from tblisimler)
	set @RastgeleId  =  rand()*@MaxId +1 -- 1-1293 arasında rastgele bir sayi üretiyorum
	set @Adi = (select Adi from tblisimler where Id = @RastgeleId)
	set @Cinsiyet = (select Cinsiyet from tblisimler where Id = @RastgeleId)

	set @MaxId = (select max(Id) from tblSoyisimler)
	set @RastgeleId  = rand()*@MaxId +1 -- 1-1603 arasında rastgele bir sayi üretiyorum
	set @Soyadi = (select Soyadi from tblSoyisimler where Id = @RastgeleId)

	--Müşteri Numarasi oluşturma
	set @Varmi = 1
	
	while @Varmi > 0
	begin

		set @MaxId = (select max(Id) from tblSube)
		set @RastgeleId  =  rand()*@MaxId +1 -- 1-1293 arasında rastgele bir sayi üretiyorum
		set @MusteriNumaraasi = (select SubeKodu from tblSube where Id = @RastgeleId)
		if @MusteriNumaraasi is not null
		begin
			set @RastgeleId =  RAND()*100000000+100000000
			set @MusteriNumaraasi = (@MusteriNumaraasi + CONVERT(char(9), @RastgeleId) )
			print(Convert(varchar(12),@MusteriNumaraasi))
			set @Varmi = (select COUNT(*) from tblMusteri where MusteriNumarasi = @MusteriNumaraasi)

			if LEN(@MusteriNumaraasi) !=12
			begin
			print( 'Musteri numarası Boyutu : ' + Convert(varchar(12),LEN(@MusteriNumaraasi)))
				set @Varmi = 1
			end
		end
		
	end

	-- @DogumTarihi rastgele oluşturalım
	set @DogumTarihi = (select GETDATE() -(RAND()*50*365+18*365))

	--@Email Rastgele oluşturalım
	set @Varmi = 1
	while @Varmi > 0
	begin
		set @RastgeleId =  RAND()*999+1
		set @Email = @Adi + '.'+@Soyadi + CONVERT(varchar(3),@RastgeleId) + '@gmail.com'

		set @Varmi = (select COUNT(*) from tblMusteri where Email = @Email)
	end
	
	-- CepTelefonu Kodu

	set @MaxId = (select MAX(CountryID) from tblCountry)

	set @RastgeleId = RAND()* @MaxId + 1
	
	set @CepTelefonuKodu = (select PhoneCode from  tblCountry where CountryID = @RastgeleId )

	-- cep telefonu
	--declare @CepTelefonu char(10)
	set @Varmi = 1
	while @Varmi !=10
	begin
	set @CepTelefonu =   CONVERT(varchar(3), CONVERT(int, RAND()*30+530)) + CONVERT(varchar(7), CONVERT(int, RAND()*10000000))
	--select @CepTelefonu
	 set @Varmi =  LEN(@CepTelefonu)
	end
		insert into tblMusteri( MusteriNumarasi, OlusturmaTarihi, Adi, Soyadi, DogumTarihi, Cinsiyet, Email, CepTelefonuKodu, CepTelefonu, IsPersonel)
		values(@MusteriNumaraasi,GETDATE(),@Adi,@Soyadi,@DogumTarihi ,@Cinsiyet,@Email,@CepTelefonuKodu,@CepTelefonu,0)
	set @KayitSayisi = (@KayitSayisi-1)
end


