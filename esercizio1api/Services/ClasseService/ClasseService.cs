global using esercizio1api.Entity;
using esercizio1api.Dd;
using esercizio1api.DTOs;
using esercizio1api.Services.ClasseService;
using Microsoft.EntityFrameworkCore;

namespace Services.ClasseService
{
	public class ClasseService : IClasseService
	{
		//costruttore per testare l'API senza database
		/* private static List<ClasseEntity> classi = new List<ClasseEntity>
			{
				new ClasseEntity
				{   ClasseId = "1",
					Sezione = "A2"
				},

				new ClasseEntity
				{   ClasseId = "2",
					Sezione = "B23"
				}
				
	       }; */

		private readonly DataContext _context;

        public ClasseService (DataContext context)
        {
			_context = context;
        }

        public async Task<List<ClasseEntity>> AddClasse(ClasseEntity request)
		{
			_context.Classi.Add(request);
			await _context.SaveChangesAsync();
			return await _context.Classi.ToListAsync();
		}

		public async Task<List<ClasseEntity>>? DeleteClasse(string id)
		{
			var classe = await _context.Classi.FindAsync(id);
			if (classe == null)
				return null;
			_context.Classi.Remove(classe);
			await _context.SaveChangesAsync();
			return await _context.Classi.ToListAsync();
		}

		public async Task<List<ClasseDTO>> GetAllClassi()
		{
			var classi = await _context.Classi.Include(x => x.Alunni).Select(y => new ClasseDTO(y)).ToListAsync();
			return classi;
		}

		public async Task<ClasseEntity>? GetSingleClasse(string id)
		{
			var classe = await _context.Classi.FindAsync(id);
			if (classe == null)
				return null;

			return classe;
		}

		public async Task<List<ClasseEntity>>? UpdateClasse(string id, ClasseEntity request)
		{
			var classe = await _context.Classi.FindAsync(id);
			if (classe == null)
				return null;

			classe.Sezione = request.Sezione;
			
			await _context.SaveChangesAsync();
			return await _context.Classi.ToListAsync();
		}
	}
}
