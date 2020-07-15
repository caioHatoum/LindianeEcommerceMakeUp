using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LindianeEcommerceMakeUp.Entities
{
    public class VendaProdutos
    {
        public int CodigoProduto { get; set; }
        public int CodigoVenda { get; set; }
        public float Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
    }
}
