using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace esercizio1api.Entity
{
	public class ClasseEntity
	{	
		/*
		public ClasseEntity()
		{

		}
		public ClasseEntity(string sezione, string alunni)
		{
			Id = Id;
			Sezione = sezione;
			Alunni = alunni;
		}*/


		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public string? Id { get; set; }
		public string Sezione { get; set; } = string.Empty;
		public List<AlunnoEntity>? Alunni { get; set; }

	}
}
