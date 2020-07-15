using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LindianeEcommerceMakeUp.Entities
{
    public class Marcas
    {
        [Key]
        public int? Codigo { get; set; }
        public string NomeMarca { get; set; }
        public ICollection<Produto> Produtos { get; set; }
        public ICollection<MarcasCategorias> Categorias { get; set; }
    }
}
