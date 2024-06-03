namespace esercizio1api.Services.AlunnoService
{
    public interface IAlunnoService
    {
		List<AlunnoEntity> GetAllAlunni();

		List<AlunnoEntity> GetSingleAlunno(string id);

		List<AlunnoEntity> AddAlunno(AlunnoEntity alunno);

		List<AlunnoEntity> UpdateAlunno(string id, AlunnoEntity request);

		List<AlunnoEntity> DeleteAlunno(string id);

	}
}
