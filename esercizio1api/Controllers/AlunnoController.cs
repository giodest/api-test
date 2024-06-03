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

    public class AlunnoController : ControllerBase
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

        //CRUD

        [HttpGet]
        public async Task<ActionResult<List<AlunnoEntity>>> GetAllAlunni()
        {

            return Ok(alunni);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<AlunnoEntity>>> GetSingleAlunno(string id)
        {
            var alunno = alunni.Find(x => x.Id == id);
            if (alunno == null)
            {
                return NotFound("Sorry, this Alunno doesn't exist");
            }
            return Ok(alunno);
        }

        [HttpPost]
        public async Task<ActionResult<List<AlunnoEntity>>> AddAlunno(AlunnoEntity alunno)
        {
            alunni.Add(alunno);
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
