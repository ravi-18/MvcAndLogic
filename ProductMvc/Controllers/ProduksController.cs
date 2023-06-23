using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductMvc;
using ProductMvc.Models;
using ProductMvc.Services;

namespace ProductMvc.Controllers
{
    public class ProduksController : Controller
    {
        private readonly IProductService service;

        public ProduksController(IProductService service)
        {
            this.service = service;
        }

        // GET: Produks
        public async Task<IActionResult> Index(string? search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return await this.service.GetAllAsync() != null ? 
                          View(await this.service.GetAllAsync()) :
                          Problem("Table Product is null.");
            }
            else
            {
                return await this.service.SearchAsync(search) != null ?
                    View(await this.service.SearchAsync(search)) :
                          Problem("Product not found.");
            }
        }

        // GET: Produks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            try
            {
                if (id == null || this.service.GetAllAsync() == null)
                {
                    return NotFound();
                }

                var produk = await this.service.GetByIdAsync(id.Value);
                if (produk == null)
                {
                    return NotFound();
                }

                return View(produk);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        // GET: Produks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Produks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nama_Barang,Kode_Barang,Jumlah_Barang,Tanggal")] Produk produk)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await this.service.CreateAsync(produk);
                    return RedirectToAction(nameof(Index));
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.Message, ex.InnerException);
                }
            }
            return View(produk);
        }

        // GET: Produks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || this.service.GetByIdAsync(id.Value) == null)
            {
                return NotFound();
            }

            var produk = await this.service.GetByIdAsync(id.Value);
            if (produk == null)
            {
                return NotFound();
            }
            return View(produk);
        }

        // POST: Produks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nama_Barang,Kode_Barang,Jumlah_Barang,Tanggal")] Produk produk)
        {
            if (id != produk.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var result = this.service.UpdateAsync(produk);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdukExists(produk.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(produk);
        }

        // GET: Produks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || this.service.GetAllAsync() == null)
            {
                return NotFound();
            }

            var produk = await this.service.GetByIdAsync(id.Value);
            if (produk == null)
            {
                return NotFound();
            }

            return View(produk);
        }

        // POST: Produks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (this.service.GetAllAsync() == null)
            {
                return Problem("Table Produk is null.");
            }
            var produk = await this.service.GetByIdAsync(id);
            if (produk != null)
            {
                var result = this.service.DeleteAsync(produk.Id);
            }
            return RedirectToAction(nameof(Index));
        }

        private bool ProdukExists(int id)
        {
          return (this.service.GetByIdAsync(id) != null ? true : false);
        }
    }
}
