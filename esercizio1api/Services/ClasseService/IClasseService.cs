using esercizio1api.DTOs;

namespace esercizio1api.Services.ClasseService
{
    public interface IClasseService
{
		Task<List<ClasseDTO>> GetAllClassi();
		Task<ClasseEntity>? GetSingleClasse(string id);
		Task<List<ClasseEntity>> AddClasse(ClasseEntity request);
		Task<List<ClasseEntity>>? UpdateClasse(string id, ClasseEntity request);
		Task<List<ClasseEntity>>? DeleteClasse(string id);
}
}
