using System.Collections;
using System.Linq;
using Businnes.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace ServiceAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KayitProgramiController : ControllerBase
    {
        private readonly IKayitProgramiServices _kayitProgramiServices;

        public KayitProgramiController(IKayitProgramiServices kayitProgramiServices)
        {
            _kayitProgramiServices = kayitProgramiServices;
        }

        [HttpGet]
        public IEnumerable Index()
        {
            var sonuc = _kayitProgramiServices.GetAllList().ToList();
            return sonuc;
        }

        [HttpPost("ekle")]
        public KayitProgrami EkleTesis(KayitProgrami entity)
        {
            var sonTesis = entity;
            _kayitProgramiServices.Add(entity);
            return sonTesis;
        }

        [HttpGet("/Kayitprogrami/{id}")]
        public IEnumerable Index(int id)
        {
            var sonuc = _kayitProgramiServices.Get(id);
            return sonuc;
        }

        [HttpDelete]
        public void Delete(KayitProgrami entity)
        {
            _kayitProgramiServices.Delete(entity);
        }

        [HttpPut]
        public void Update(KayitProgrami entity)
        {
            _kayitProgramiServices.Update(entity);
        }
    }
}