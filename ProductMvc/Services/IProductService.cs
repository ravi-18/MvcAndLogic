using ProductMvc.Models;

namespace ProductMvc.Services
{
    public interface IProductService
    {
        Task<Produk> CreateAsync(Produk produk);
        Task<Produk> UpdateAsync(Produk produk);
        Task<Produk> DeleteAsync(int id);
        Task<IQueryable<Produk>?> GetAllAsync();
        Task<Produk> GetByIdAsync(int id);
        Task<IQueryable<Produk>?> SearchAsync(string search);
    }
}
