using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace esercizio1api.DTOs
{


	public class ClasseDTO
	{

		public ClasseDTO(ClasseEntity entity)
		{
			Sezione = entity.Sezione;
			Alunni = entity.Alunni.Select(x => new AlunnoDTO(x)).ToList();
		}
		public string Sezione { get; set; } = string.Empty;
		public ICollection<AlunnoDTO> Alunni { get; set; }

	}
}
