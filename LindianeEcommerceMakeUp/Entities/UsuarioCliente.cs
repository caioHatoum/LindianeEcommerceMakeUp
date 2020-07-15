using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LindianeEcommerceMakeUp.Entities
{
    public class UsuarioCliente
    {
        [Key]
        public int? Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF_CNPJ { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public ICollection<Venda> Vendas { get; set; }
    }
}
