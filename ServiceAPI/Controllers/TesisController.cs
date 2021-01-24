using System.Collections;
using System.Linq;
using Businnes.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace ServiceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesisController : ControllerBase
    {
        private readonly ITesisServices _tesisServices;

        public TesisController(ITesisServices tesisServices)
        {
            _tesisServices = tesisServices;
        }


        [HttpGet]
        public IEnumerable Index()
        {
            var sonuc = _tesisServices.GetAllList().ToList();
            return sonuc;
        }

        [HttpPost("ekle")]
        public Tesis EkleTesis(Tesis tesis)
        {
            var sonTesis = tesis;
            _tesisServices.Add(tesis);
            return sonTesis;
        }

        [HttpGet("/tesis/{id}")]
        public IEnumerable Index(int id)
        {
            var sonuc = _tesisServices.Get(id);
            return sonuc;
        }

        [HttpDelete]
        public void Delete(Tesis tesis)
        {
            _tesisServices.Delete(tesis);
        }

        [HttpPut]
        public void Update(Tesis tesis)
        {
            _tesisServices.Update(tesis);
        }
    }
}