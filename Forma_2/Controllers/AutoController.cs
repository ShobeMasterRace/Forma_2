﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forma_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        private Forma2_Services.Repository<Forma2_Data.Models.AutoModel> Autos = new Forma2_Services.Repository<Forma2_Data.Models.AutoModel>();


        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {

            return Ok(Autos.GetAll());

        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetID(int id)
        {

            return Ok(Autos.Get(id));
        }

        [HttpPost]
        [Route("")]
        public IActionResult Add([FromBody] Forma2_Data.Models.AutoModel item)
        {
            return Ok(Autos.Add(item)); 
        }


        //EDIT, DELETE
    }
}