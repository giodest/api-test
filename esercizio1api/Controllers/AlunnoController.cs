using esercizio1api.DTOs;
using esercizio1api.Entity;
using esercizio1api.Services;
using esercizio1api.Services.AlunnoService;
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
        //ALUNNO CONSTRUCTOR
        public IAlunnoService _alunnoService; 

		public AlunnoController(IAlunnoService alunnoService)
        {
			_alunnoService = alunnoService;
		}

        //CRUD
        [HttpGet]
        public async Task<ActionResult<List<AlunnoEntity>>> GetAllAlunni()
        {
            return await _alunnoService.GetAllAlunni();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<AlunnoDTO>>> GetSingleAlunno(string id)
        {
            var result = _alunnoService.GetSingleAlunno(id);
            if (result == null)
				return NotFound("Sorry, this Alunno doesn't exist");
			return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<AlunnoEntity>>> AddAlunno(AlunnoEntity alunno)
        {
            var result = _alunnoService.AddAlunno(alunno);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<AlunnoEntity>>> UpdateAlunno(string id, AlunnoEntity request)
        {
			var result = _alunnoService.UpdateAlunno(id, request);
			if (result == null)
				return NotFound("Sorry, this Alunno doesn't exist");
			return Ok(result);
		}

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<AlunnoEntity>>> DeleteAlunno(string id) 
        {
            var result = _alunnoService.DeleteAlunno(id);
            if (result == null)
                return NotFound("Sorry, this Alunno doesn't exist");
            return Ok(result); 
           
        
        }



	}   

}
