namespace esercizio1api.Services.ClasseService
{
    public interface IClasseService
{
		List<ClasseEntity> GetAllClassi();
		ClasseEntity? GetSingleClasse(string id);
		List<ClasseEntity> AddClasse(ClasseEntity request);
		List<ClasseEntity>? UpdateClasse(string id, ClasseEntity request);
		List<ClasseEntity>? DeleteClasse(string id);
}
}
