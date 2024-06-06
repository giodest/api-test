using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace esercizio1api.DTOs
{


	public class AlunnoDTO
	{


		public AlunnoDTO(AlunnoEntity entity)
		{
			Name = entity.Name;
			LastName = entity.LastName;
			Anno = entity.Anno;
		}
		public string Name { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string? Anno { get; set; } = string.Empty;

	}
}
