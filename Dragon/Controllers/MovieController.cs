﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProjetoDaniel.Dto;
using ProjetoDanielApplication.Interfaces;

namespace ProjetoDaniel.Controllers
{
    [Produces("application/json")]
    [Route("api/Movie/")]
    [EnableCors("any")]
    public class MovieController : Controller
    {
        private readonly IMovieAppService _appService;
        public MovieController(IMovieAppService movieAppService)
        {
            _appService = movieAppService;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get([FromBody]MovieDto movieDto)
        {
            return Ok(_appService.GetMovie(movieDto));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(Guid id)
        {
            return Ok(_appService.GetMovieById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody]MovieDto movieDto)
        {
            return Ok(_appService.SaveMovie(movieDto));
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody]MovieDto movieDto)
        {
            _appService.UpdateMovie(movieDto);
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            _appService.DeleteMovie(id);
            return Ok();
        }
    }
}