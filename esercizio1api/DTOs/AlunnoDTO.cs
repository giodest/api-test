namespace esercizio1api.DTOs
{
	public class AlunnoDTO (ClasseEntity Sezione) {
		
		public string? Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string? Anno { get; set; } = string.Empty;
		public string Sezione { get; set; } = string.Empty;

		private readonly ClasseEntity sezione = Sezione;

	}

	
}
