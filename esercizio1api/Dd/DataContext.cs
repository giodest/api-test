using esercizio1api.Entity;
using Microsoft.EntityFrameworkCore;


namespace esercizio1api.Dd
{
	public class DataContext : DbContext 
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<AlunnoEntity> Alunni {  get; set; }
		public DbSet<ClasseEntity> Classi { get; set; }
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<AlunnoEntity>()
			.HasOne(a => a.Sezione)
			.WithMany(c => c.Alunni)
			.HasForeignKey(a => a.ClasseId);
	}

}
