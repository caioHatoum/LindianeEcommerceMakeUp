using LindianeEcommerceMakeUp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LindianeEcommerceMakeUp.DAL
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<CategoriaProduto> CategoriaProduto { get; set; }
        public DbSet<Marcas> Marca { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<UsuarioCliente> Cliente { get; set; }
        public DbSet<UsuarioFuncionario> Funcionario { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<VendaProdutos> VendaProdutos { get; set; }
        public DbSet<MarcasCategorias> MarcasCategorias { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<VendaProdutos>()
                .HasKey(x => new { x.CodigoProduto, x.CodigoVenda });

            builder.Entity<VendaProdutos>()
                .HasOne(x => x.Venda)
                .WithMany(y => y.Produtos)
                .HasForeignKey(z => z.CodigoVenda);

            builder.Entity<VendaProdutos>()
                .HasOne(x => x.Produto)
                .WithMany(y => y.Venda)
                .HasForeignKey(z => z.CodigoProduto);


            builder.Entity<MarcasCategorias>()
             .HasKey(x => new { x.CodigoCategoria, x.CodigoMarca });

            builder.Entity<MarcasCategorias>()
                .HasOne(x => x.Categoria)
                .WithMany(y => y.Marcas)
                .HasForeignKey(z => z.CodigoCategoria);

            builder.Entity<MarcasCategorias>()
                .HasOne(x => x.Marca)
                .WithMany(y => y.Categorias)
                .HasForeignKey(z => z.CodigoMarca);



        }

    }
}
