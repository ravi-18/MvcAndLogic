CREATE DATABASE ProductDb

USE ProductDb
CREATE TABLE Produk(
	Id int identity primary key,
	Nama_Barang varchar(200) not null,
	Kode_Barang varchar(50) not null,
	Jumlah_Barang int not null,
	Tanggal datetime not null
)

declare @tgl DATETIME = CONVERT(DATETIME,'2023-06-23 03:49:30.770')
exec SP_AddProduk @nama_Barang = 'Mie Kriting', @kode_Barang = 'PRO0004', @jumlah_Barang = 1000, @tanggal = @tgl

declare @tgl DATETIME = CONVERT(DATETIME,'2023-06-23 03:49:30.770')
exec SP_UpdateProduk @id = 1, @nama_Barang = 'Mie Goreng', @kode_Barang = 'PRO0003', @jumlah_Barang = 1000, @tanggal = @tgl

exec SP_DeleteProduk @id = 3

exec SP_SearchProduk @search = 'Mie'

exec SP_GetById @id = 2

EXEC SP_GetById @id = 1
