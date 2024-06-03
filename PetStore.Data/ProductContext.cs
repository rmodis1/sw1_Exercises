using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Products;

namespace PetStore.Data
{
	public class ProductContext: DbContext
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }

		public string DbPath { get; }

		public ProductContext()
		{
			var folder = Environment.SpecialFolder.LocalApplicationData;
			var path = Environment.GetFolderPath(folder);
			DbPath = Path.Join(path, "products.db");
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseSqlite($"Data Source = {DbPath}");
    }
}

