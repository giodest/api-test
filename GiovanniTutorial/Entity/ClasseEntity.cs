using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GiovanniTutorial.Entity
{
	public class ClasseEntity
	{
		public ClasseEntity()
		{

		}
		public ClasseEntity(string sezione, string anno)
		{
			Id = Guid.NewGuid().ToString();
			Sezione = sezione;
			Anno = anno;
		}
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public string? Id { get; set; }
		public string Sezione { get; set; } = string.Empty;
		public string Anno { get; set; } = string.Empty;
	}
}
