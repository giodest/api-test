using esercizio1api.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;


namespace esercizio1api.Dd
{
	public class DataContext : DbContext 
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<AlunnoEntity> Alunni {  get; set; }
		public DbSet<ClasseEntity> Classi { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ClasseEntity>()
				.HasMany(a => a.Alunni)
				.WithOne(b => b.ClasseEntity)
				.HasForeignKey(c => c.ClasseId)
				.IsRequired();
		}

	}

	
}
