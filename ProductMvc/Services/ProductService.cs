using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProductMvc.Models;
using System.Reflection.Metadata;

namespace ProductMvc.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext context;

        public ProductService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<Produk> CreateAsync(Produk produk)
        {
            var nama_Barang = new SqlParameter("@nama_Barang", produk.Nama_Barang);
            var kode_Barang = new SqlParameter("@kode_Barang", produk.Kode_Barang);
            var jumlah_Barang = new SqlParameter("@jumlah_Barang", produk.Jumlah_Barang);
            var tanggal = new SqlParameter("@tanggal", produk.Tanggal);

            var result = this.context.Produk.FromSqlRaw("EXEC SP_AddProduk @nama_Barang, @kode_Barang, @jumlah_Barang, @tanggal",
                                                        nama_Barang,
                                                        kode_Barang,
                                                        jumlah_Barang,
                                                        tanggal).AsEnumerable().SingleOrDefault();
            return result;
        }

        public async Task<Produk> DeleteAsync(int id)
        {
            var productId = new SqlParameter("@id", id);
            return this.context.Produk.FromSqlRaw("EXEC SP_DeleteProduk @id", productId).AsEnumerable().SingleOrDefault();
        }

        public async Task<IQueryable<Produk>> GetAllAsync()
        {
            var result = this.context.Produk.FromSqlRaw("EXEC SP_GetALl");
            return result;
        }

        public async Task<Produk> GetByIdAsync(int id)
        {
            var productId = new SqlParameter("@productId", id);
            var result = this.context.Produk.FromSqlInterpolated($"EXEC SP_GetById {productId}")
                .AsEnumerable().SingleOrDefault();
            return result;
        }

        public async Task<IQueryable<Produk>> SearchAsync(string search)
        {
            var searchItem = new SqlParameter("@search", search);
            return this.context.Produk.FromSqlRaw("EXEC SP_SearchProduk @search", searchItem);
        }

        public async Task<Produk> UpdateAsync(Produk produk)
        {
            var id = new SqlParameter("@id", produk.Id);
            var nama_Barang = new SqlParameter("@nama_Barang", produk.Nama_Barang);
            var kode_Barang = new SqlParameter("@kode_Barang", produk.Kode_Barang);
            var jumlah_Barang = new SqlParameter("@jumlah_Barang", produk.Jumlah_Barang);
            var tanggal = new SqlParameter("@tanggal", produk.Tanggal);

            var result = this.context.Produk.FromSqlRaw("EXEC SP_UpdateProduk @id, @nama_Barang, @kode_Barang, @jumlah_Barang, @tanggal",
                                        id,
                                        nama_Barang,
                                        kode_Barang,
                                        jumlah_Barang,
                                        tanggal).AsEnumerable().SingleOrDefault();
            return result;
        }
    }
}
