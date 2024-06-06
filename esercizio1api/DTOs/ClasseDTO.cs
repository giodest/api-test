namespace esercizio1api.DTOs
{
	public record struct ClasseDTO () {

		public string Sezione { get; set; } = string.Empty;

		public ICollection<AlunnoEntity> Alunni { get; set; }

	}
		;
}
