using GiovanniTutorial.Entity;
using Microsoft.EntityFrameworkCore;


namespace GiovanniTutorial.Dd
{
	public class DataContext : DbContext 
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<AlunnoEntity> Alunni {  get; set; }
		public DbSet<ClasseEntity> Classe { get; set; }
	}

}
