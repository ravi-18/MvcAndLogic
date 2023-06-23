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
CREATE PROCEDURE SP_AddProduk
	-- Add the parameters for the stored procedure here
	 @nama_Barang varchar(200),
	 @kode_Barang varchar(50),
	 @jumlah_Barang int,
	 @tanggal datetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Produk (Nama_Barang, Kode_Barang, Jumlah_Barang, Tanggal)
	VALUES (@nama_Barang, @kode_Barang, @jumlah_Barang, @tanggal)

	SELECT Id, Nama_Barang, Kode_Barang, Jumlah_Barang, Tanggal 
	FROM Produk 
	where Nama_Barang = @nama_Barang AND Kode_Barang = @kode_Barang AND Tanggal = @tanggal
END
GO
