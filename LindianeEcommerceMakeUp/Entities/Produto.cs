using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LindianeEcommerceMakeUp.Entities
{
    public class Produto
    {
        [Key]
        public int? Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Quantidade { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
        [ForeignKey("Marcas")]
        public int CodigoMarca { get; set; }
        [ForeignKey("CategoriaProduto")]
        public int CodigoCategoria { get; set; }
        public Marcas Marca { get; set; }
        public CategoriaProduto Categoria { get; set; }
        public ICollection<VendaProdutos> Venda { get; set; }
    }
}
