using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsApi.Domain;
using PersonsApi.Dto;

namespace PersonsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        [HttpPut]
        public ActionResult<PersonDto> UpdatePerson([FromBody] UpdatePersonDto dto)
        {
            var person = new Person
            {
                Id = Guid.Parse(dto.Id),
                FirstName = dto.FirstName,
                LastName = dto.LastName,
            };

            // llamar al servicio para actualizar persona
            
            // respuesta a la llamada al servicio
            var response = new PersonDto();

            return Ok(response);
        }
    }
}
