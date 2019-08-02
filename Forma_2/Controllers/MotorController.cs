using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forma_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorController : ControllerBase
    {
        private Forma2_Services.Repository<Forma2_Data.Models.MotorModel> Motos = new Forma2_Services.Repository<Forma2_Data.Models.MotorModel();


        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {

            return Ok(Motos.GetAll());

        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetID(int id)
        {

            return Ok(Motos.Get(id));
        }

        [HttpPost]
        [Route("")]
        public IActionResult Add([FromBody] Forma2_Data.Models.MotorModel item)
        {
            return Ok(Motos.Add(item));
        }

        //EDIT, DELETE
    }
}