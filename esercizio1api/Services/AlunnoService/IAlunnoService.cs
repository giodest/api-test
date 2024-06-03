namespace esercizio1api.Services.AlunnoService
{
    public interface IAlunnoService
    {
		List<AlunnoEntity> GetAllAlunni();
		AlunnoEntity? GetSingleAlunno(string id);
		List<AlunnoEntity> AddAlunno(AlunnoEntity request);
		List<AlunnoEntity>? UpdateAlunno(string id, AlunnoEntity request);
		List<AlunnoEntity>? DeleteAlunno(string id);

	}
}
