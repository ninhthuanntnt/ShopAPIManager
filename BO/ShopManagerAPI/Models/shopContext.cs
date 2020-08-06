using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ShopManagerAPI.Models
{
    public class shopContext : DbContext
    {
        public shopContext()
        {
        }

        public shopContext(DbContextOptions<shopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TaAutAuthorization> TaAutAuthorization { get; set; }
        public virtual DbSet<TaAutUser> TaAutUser { get; set; }
        public virtual DbSet<TaMatMaterial> MatMaterial { get; set; }
        public virtual DbSet<TaMatMaterialDetail> MatMaterialDetail { get; set; }
        public virtual DbSet<TaMatPricing> MatPricing { get; set; }
        public virtual DbSet<TaMatStock> MatStock { get; set; }
        public virtual DbSet<MatStockIoModel> MatStockIo { get; set; }
        public virtual DbSet<TaMatUnit> MatUnit { get; set; }
        public virtual DbSet<TaMatWarehouse> MatWarehouse { get; set; }
        public virtual DbSet<TaPerPerson> PerPerson { get; set; }
        public virtual DbSet<TaSorOrder> SorOrder { get; set; }
        public virtual DbSet<TaSorOrderDetail> SorOrderDetail { get; set; }
        public virtual DbSet<TaSysLock> SysLock { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=198lytutrong.hnvgrp.com,1444;Initial Catalog=shop;Persist Security Info=True;User ID=thienphat;Password=thienphat");
            }
        }
    }
}
