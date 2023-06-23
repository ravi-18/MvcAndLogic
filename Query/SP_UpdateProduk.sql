-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
USE ProductDb;
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE SP_UpdateProduk
	-- Add the parameters for the stored procedure here
	 @id int,
	 @nama_Barang varchar(200),
	 @kode_Barang varchar(50),
	 @jumlah_Barang int,
	 @tanggal datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	
    DECLARE @ProdukExist INT

	SELECT @ProdukExist = COUNT(Id) FROM Produk WHERE Id = @id

	IF @ProdukExist > 0
	BEGIN
		UPDATE Produk SET Nama_Barang = @nama_Barang, Kode_Barang = @kode_Barang, Jumlah_Barang = @jumlah_Barang, Tanggal = @tanggal
		WHERE Id = @id
	
		SELECT Id, Nama_Barang, Kode_Barang, Jumlah_Barang, Tanggal 
		FROM Produk 
		where Id = @id
	END
	ELSE
	BEGIN
		SELECT Id, Nama_Barang, Kode_Barang, Jumlah_Barang, Tanggal 
		FROM Produk 
		where Id = @id
	END
END
GO
