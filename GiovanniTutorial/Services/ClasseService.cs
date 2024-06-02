

using GiovanniTutorial.Entity;

namespace GiovanniTutorial.Services
{
	public interface IClasseService
	{
		public List<ClasseEntity> getClassi();

		public ClasseEntity? getClassi(string id);

	}
	public class ClasseService : IClasseService
	{
		List<ClasseEntity> classi = new List<ClasseEntity>()
			{
				new ClasseEntity("A1","5"),
				new ClasseEntity("B2","3"),
				new ClasseEntity("B5","2")
			};

		public List<ClasseEntity> getClassi() => classi;

		public ClasseEntity? getClassi(string id) => classi.FirstOrDefault(p => p.Id == id);

	}
}
