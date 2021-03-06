﻿using Microsoft.EntityFrameworkCore;
using ORM.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORM.Context
{
    public class PedidoContext : DbContext
    {
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<PedidoItem> PedidosItens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data source=.\Sqlexpress;Initial Catalog=Db_Senai_Pedidos_Dev");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
