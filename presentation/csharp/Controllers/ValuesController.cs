﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using data;
using shared;

namespace csharp.Controllers
{
    // [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [HttpPost]
        [Route("Personajes")]
        public ActionResult<IEnumerable<Personaje>> Get()
        {
            var o = new ListaPersonajes();
            var p = o.ObtenerPersonajes();
            return Ok(p);
        }

        [HttpPut]
        [Route("Personajes")]
        public ActionResult<Personaje> CrearPersonaje([FromBody] dynamic datosEntrada)
        {
            string nombre = datosEntrada.Nombre;
            return Ok(new Personaje(){
                Nombre = nombre
            });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // // POST api/values
        // [HttpPost]
        // public void Post([FromBody] string value)
        // {
        // }

        // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
