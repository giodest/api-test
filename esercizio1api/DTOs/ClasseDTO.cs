namespace esercizio1api.DTOs
{
	public record struct ClasseDTO(
		string Sezione, 
		List<AlunnoDTO> Alunni);
}
