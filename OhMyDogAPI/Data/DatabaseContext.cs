﻿using Microsoft.EntityFrameworkCore;
using OhMyDogAPI.Mapping;
using OhMyDogAPI.Model;

namespace OhMyDogAPI.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<TipoUsuario> TiposUsuarios { get; set; }
        public DbSet<ItemCarrinho> ItensCarrinho { get; set; }
        public DbSet<FormaEnvio> FormasEnvio { get; set; }
        public DbSet<FormaPagamento> FormasPagamento { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }
        public DbSet<PromocoesAtuais> PromocoesAtuais { get; set; }
        public DbSet<ItemFavoritos> ItensFavoritos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<StatusPedido> StatusPedidos { get; set; }
        public DbSet<StatusPagamento> StatusPagamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();
            options.UseNpgsql(config.GetConnectionString("PostgreSQL"));
            options.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProdutoMap());
            builder.ApplyConfiguration(new CategoriaMap());
            builder.ApplyConfiguration(new EnderecoMap());
            builder.ApplyConfiguration(new TipoUsuarioMap());
            builder.ApplyConfiguration(new UsuarioMap());
            builder.ApplyConfiguration(new ItemCarrinhoMap());
            builder.ApplyConfiguration(new FormaEnvioMap());
            builder.ApplyConfiguration(new FormaPagamentoMap());
            builder.ApplyConfiguration(new PromocaoMap());
            builder.ApplyConfiguration(new PromocoesAtuaisMap());
            builder.ApplyConfiguration(new ItemFavoritosMap());
            builder.ApplyConfiguration(new PagamentoMap());
            builder.ApplyConfiguration(new PedidoMap());
            builder.ApplyConfiguration(new ItemPedidoMap());
            builder.ApplyConfiguration(new StatusPagamentoMap());
            builder.ApplyConfiguration(new StatusPedidoMap());
        }
    }
}
