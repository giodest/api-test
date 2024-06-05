using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using esercizio1api.Migrations;

namespace esercizio1api.Entity
{
	public class ClasseEntity
	{	
		
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public string? ClasseId { get; set; }
		public string Sezione { get; set; } = string.Empty;		
		public ICollection<AlunnoEntity> Alunni { get; set; }

	}
}

