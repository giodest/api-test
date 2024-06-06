using esercizio1api.DTOs;

namespace esercizio1api.Services.AlunnoService
{
    public interface IAlunnoService
    {
		Task<List<AlunnoEntity>> GetAllAlunni();
		Task<AlunnoEntity>? GetSingleAlunno(string id);
		Task<List<AlunnoEntity>> AddAlunno(AlunnoEntity classe);
		Task<List<AlunnoEntity>>? UpdateAlunno(string id, AlunnoEntity request);
		Task<List<AlunnoEntity>>? DeleteAlunno(string id);

	}
}
