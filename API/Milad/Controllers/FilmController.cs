using Milad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Milad.Controllers
{
    public class FilmController : ApiController
    {
        [HttpPost]
        [Route("film/save")]
        public ResponseModel SaveFilm(BEFilm film)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                new DLFilm().SaveFilm(film);
                response.Status = true;
                response.Message = "Film Data saved";
                response.Data = null;
                return response;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = ex.Message;
                response.Data = null;
                return response;
            }
        }

        [HttpPost]
        [Route("film/get")]
        public ResponseModel SearchFilm(BEFilm film)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                response.Status = true;
                response.Message = "";
                response.Data = new DLFilm().SearchFile(film.IMDBId);
                return response;
            }
            catch (Exception ex)
            {
                response.Status = false;
                response.Message = ex.Message;
                response.Data = null;
                return response;
            }
        }
    }
}
