using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LindianeEcommerceMakeUp.Entities
{
    public class CategoriaProduto
    {
        [Key]
        public int? Codigo { get; set; }
        public string NomeCategoria { get; set; }
        public ICollection<Produto> Produtos { get; set; }
        public ICollection<MarcasCategorias> Marcas { get; set; }
    }
}
