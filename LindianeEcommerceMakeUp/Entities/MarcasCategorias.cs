using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LindianeEcommerceMakeUp.Entities
{
    public class MarcasCategorias
    {
        public int CodigoMarca { get; set; }
        public int CodigoCategoria { get; set; }
        public Marcas Marca { get; set; }
        public CategoriaProduto Categoria { get; set; }
    }
}
