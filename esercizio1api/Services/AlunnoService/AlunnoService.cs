global using esercizio1api.Entity;
using esercizio1api.Dd;
using esercizio1api.DTOs;
using esercizio1api.Services.AlunnoService;
using Microsoft.EntityFrameworkCore;

namespace Services.AlunnoService
{
	public class AlunnoService : IAlunnoService
	{

		//costruttore per testare l'API senza database
		/* private static List<AlunnoEntity> alunni = new List<AlunnoEntity>
			{
				new AlunnoEntity
				{   AlunnoId = "1",
					Name = "Giovanni",
					LastName = "Destratis",
					Anno = "5",									
				},

				new AlunnoEntity
				{   AlunnoId = "2",
					Name = "Mario",
					LastName = "Rossi",
					Anno = "4",
				}
			}; */

		//Injecting datacontext to alunnoservice 

		private readonly DataContext _context;

		public AlunnoService(DataContext context)
        {
			_context = context;
		}

        public async Task<List<AlunnoEntity>> AddAlunno(AlunnoEntity alunno)
		{
			_context.Alunni.Add(alunno);
			await _context.SaveChangesAsync();
			return await _context.Alunni.ToListAsync();
		}

		public async Task<List<AlunnoEntity>>? DeleteAlunno(string id)
		{
			var alunno = await _context.Alunni.FindAsync(id);
			if (alunno == null)
				return null;
			_context.Alunni.Remove(alunno);
			await _context.SaveChangesAsync();
			return await _context.Alunni.ToListAsync();
		}

		public async Task<List<AlunnoEntity>> GetAllAlunni()
		{
			var alunni = await _context.Alunni.ToListAsync(); 
			return alunni;
		}

		public async Task<AlunnoEntity> GetSingleAlunno(string id)
		{
			var alunno = await _context.Alunni.FindAsync(id);
			if (alunno == null)
				return null;

			return alunno;
		}

		public async Task<List<AlunnoEntity>>? UpdateAlunno(string id, AlunnoEntity request)
		{
			var alunno = await _context.Alunni.FindAsync(id);
			if (alunno == null)
				return null;

			alunno.Name = request.Name;
			alunno.LastName = request.LastName;
			alunno.Anno = request.Anno;

			await _context.SaveChangesAsync();
			return await _context.Alunni.ToListAsync();
		}
	}
}
