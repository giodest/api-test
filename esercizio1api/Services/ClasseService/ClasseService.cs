global using esercizio1api.Entity;
using esercizio1api.Services;
using esercizio1api.Services.ClasseService;

namespace Services.ClasseService
{
	public class ClasseService : IClasseService
	{
		//costruttore per testare l'API senza database
		private static List<ClasseEntity> classi = new List<ClasseEntity>
			{
				new ClasseEntity
				{   Id = "1",
					Sezione = "A2"
				},

				new ClasseEntity
				{   Id = "2",
					Sezione = "B23"
				}
				
		};

		public List<ClasseEntity> AddClasse(ClasseEntity request)
		{
			classi.Add(request);
			return classi;
		}

		public List<ClasseEntity>? DeleteClasse(string id)
		{
			var classe = classi.Find(x => x.Id == id);
			if (classe == null)
				return null;
			classi.Remove(classe);
			return classi;
		}

		public List<ClasseEntity> GetAllClassi()
		{
			return classi;
		}

		public ClasseEntity? GetSingleClasse(string id)
		{
			var classe = classi.Find(a => a.Id == id);
			if (classe == null)
				return null;

			return classe;
		}

		public List<ClasseEntity>? UpdateClasse(string id, ClasseEntity request)
		{
			var classe = classi.Find(x => x.Id == id);
			if (classe == null)
				return null;

			classe.Sezione = request.Sezione;
			
			return classi;
		}
	}
}
