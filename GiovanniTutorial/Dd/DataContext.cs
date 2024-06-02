using Microsoft.EntityFrameworkCore;


namespace GiovanniTutorial.Dd
{
	public class DataContext : DbContext 
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) {
		
		}
	}

}
