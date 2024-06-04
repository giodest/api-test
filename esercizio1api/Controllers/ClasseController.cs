using esercizio1api.Services;
using esercizio1api.Services.AlunnoService;
using esercizio1api.Services.ClasseService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.AlunnoService;

namespace esercizio1api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

	public class ClasseController : ControllerBase 
	{
		//CLASSE CONSTRUCTOR
		public IClasseService _classeService;

		public ClasseController(IClasseService classeService)
		{
			_classeService = classeService;
		}

		//CRUD

		[HttpGet]
		public async Task<ActionResult<List<ClasseEntity>>> GetAllClassi()
		{
			return _classeService.GetAllClassi();
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<List<ClasseEntity>>> GetSingleClasse(string id)
		{
			var result = _classeService.GetSingleClasse(id);
			if (result == null)
				return NotFound("Sorry, this Classe doesn't exist");
			return Ok(result);
		}

		[HttpPost]
		public async Task<ActionResult<List<ClasseEntity>>> AddClasse(ClasseEntity classe)
		{
			var result = _classeService.AddClasse(classe);
			return Ok(result);
		}

		[HttpPut("{id}")]
		public async Task<ActionResult<List<ClasseEntity>>> UpdateClasse(string id, ClasseEntity request)
		{
			var result = _classeService.UpdateClasse(id, request);
			if (result == null)
				return NotFound("Sorry, this Classe doesn't exist");
			return Ok(result);
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult<List<ClasseEntity>>> DeleteClasse(string id)
		{
			var result = _classeService.DeleteClasse(id);
			if (result == null)
				return NotFound("Sorry, this Classe doesn't exist");
			return Ok(result);


		}
	}
}
