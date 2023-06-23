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
CREATE PROCEDURE SP_DeleteProduk
	-- Add the parameters for the stored procedure here
	 @id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DECLARE @ProdukExist INT;

	SELECT @ProdukExist = COUNT(Id) FROM Produk WHERE Id = @id
	IF @ProdukExist > 0
	BEGIN
		DELETE FROM Produk
		WHERE Id = @id

		SELECT * FROM Produk WHERE Id = @id
	END
	ELSE
	BEGIN
		SELECT * FROM Produk WHERE Id = @id
	END
END
GO
