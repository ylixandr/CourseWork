using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Data.SqlClient;

namespace CoureWork.Context
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Account> Account { get; set; }
		public DbSet<Wallet> Wallet { get; set; }
		public DbSet<Category> Category { get; set; }
		public DbSet<Smartphone> Smartphone { get; set; }
		public DbSet<Laptop> Laptop { get; set; }
		public DbSet<TV> TV { get; set; }
		public DbSet<Smartwatch> Smartwatch { get; set; }
		public DbSet<Cart> Cart { get; set; }

		public ApplicationDbContext() : base("name=DBConnection")
		{
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

			// Конфигурация связи между Account и Wallet
			modelBuilder.Entity<Account>()
				.HasOptional(a => a.Wallet)
				.WithRequired(w => w.Account);
				
		}

		
	}
}
