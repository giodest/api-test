using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace esercizio1api.Entity
{
	public class ClasseEntity
	{	
		
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public string? ClasseId { get; set; }
		public string Sezione { get; set; } = string.Empty;

	}
}

