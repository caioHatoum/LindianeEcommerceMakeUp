using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LindianeEcommerceMakeUp.Entities
{
    public class Venda
    {
        [Key]
        public int? Codigo { get; set; }
        public DateTime Data { get; set; }
        [ForeignKey("UsuarioCliente")]
        public int CodigoCliente { get; set; }
        public decimal Total { get; set; }
        public ICollection<VendaProdutos> Produtos { get; set; }
        public UsuarioCliente Cliente { get; set; }
    }
}
