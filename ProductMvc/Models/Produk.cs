using System;
using System.ComponentModel.DataAnnotations;

namespace ProductMvc.Models
{
    public class Produk
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Nama_Barang { get; set; }
        [Required]
        [MaxLength(50)]
	    public string Kode_Barang { get; set; }

	    public int Jumlah_Barang { get; set; }
        public DateTime Tanggal { get; set; }
    }
}
