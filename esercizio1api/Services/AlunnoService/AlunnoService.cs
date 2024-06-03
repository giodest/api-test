global using esercizio1api.Entity;
using esercizio1api.Services.AlunnoService;

namespace Services.AlunnoService
{
	public class AlunnoService : IAlunnoService
	{

		//costruttore per testare l'API senza database
		private static List<AlunnoEntity> alunni = new List<AlunnoEntity>
			{
				new AlunnoEntity
				{   Id = "1",
					Name = "Giovanni",
					LastName = "Destratis",
					Anno = "5",
				},

				new AlunnoEntity
				{   Id = "2",
					Name = "Mario",
					LastName = "Rossi",
					Anno = "4",
				}
			};
		public List<AlunnoEntity> AddAlunno(AlunnoEntity request)
		{
			alunni.Add(request);
			return alunni;
		}

		public List<AlunnoEntity>? DeleteAlunno(string id)
		{
			var alunno = alunni.Find(x => x.Id == id);
			if (alunno == null)
				return null;
			alunni.Remove(alunno);
			return alunni;
		}

		public List<AlunnoEntity> GetAllAlunni()
		{
			return alunni;
		}

		public AlunnoEntity GetSingleAlunno(string id)
		{
			var alunno = alunni.Find(a => a.Id == id);
			if (alunno == null)
				return null;

			return alunno;
		}

		public List<AlunnoEntity>? UpdateAlunno(string id, AlunnoEntity request)
		{
			var alunno = alunni.Find(x => x.Id == id);
			if (alunno == null)
				return null;

			alunno.Name = request.Name;
			alunno.LastName = request.LastName;
			alunno.Anno = request.Anno;

			return alunni;
		}
	}
}
