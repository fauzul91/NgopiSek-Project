﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgopiSek_Desktop_App_V2.App.Models
{
    public class M_DetailTransaksi
    {
        [Key]
        public int id_detail_transaksi { get; set; }
        [ForeignKey("Transaksi")]
        public int id_transaksi { get; set; }
        [ForeignKey("Produk")]
        public int id_produk { get; set; }
        [Required]
        public int kuantitas { get; set; }
    }
}
