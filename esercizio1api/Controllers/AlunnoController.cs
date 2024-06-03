using esercizio1api.Entity;
using esercizio1api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace esercizio1api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AlunnoController : ControllerBase {

        private static List<AlunnoEntity> alunni = new List<AlunnoEntity> 
		    {
				new AlunnoEntity
				{   Id = "1",
					Name = "Giovanni",
					LastName = "Destratis",
					Anno = "5",
				}

			};


		[HttpGet]
        public async Task<ActionResult<List<AlunnoEntity>>> GetAllAlunni() {

                return Ok(alunni);
            }
         
    }
	/*
    [Route("api/[controller]")]
    [ApiController]
    public class AlunnoController : Controller
    {
		
        private readonly IAlunnoService _AlunnoService;
        public AlunnoController(IAlunnoService AlunnoService)
        {
            _AlunnoService = AlunnoService;
        }

        [HttpGet("GetAlunno")]
        [Produces("application/json")]
        public async Task<IActionResult> Get()
        {

            var result = _AlunnoService.getAlunnos();
            //Validazione
            //badrequest errore di inserimento dati
            //notfound valore non trovato


            return Ok(result);
        }

        [HttpGet("GetAlunno{id}")]
        [Produces("application/json")]
        public async Task<IActionResult> Get(string id)
        {

            var result = _AlunnoService.getAlunno(id);
            //Validazione
            //badrequest errore di inserimento dati
            //notfound valore non trovato


            return Ok(result);

        } 
   }*/
}
