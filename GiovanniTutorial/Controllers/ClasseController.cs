using GiovanniTutorial.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GiovanniTutorial.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	public class ClasseController : Controller
	{
		private readonly IClasseService _ClasseService;
		public ClasseController(IClasseService ClasseService)
		{
			_ClasseService = ClasseService;
		}

		[HttpGet("GetClasse")]
		[Produces("application/json")]
		public async Task<IActionResult> Get()
		{

			var result = _ClasseService.getClassi();
			//Validazione
			//badrequest errore di inserimento dati
			//notfound valore non trovato


			return Ok(result);
		}
	}
}
