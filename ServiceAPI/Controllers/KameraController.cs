using System.Collections.Generic;
using Businnes.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace ServiceAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KameraController : ControllerBase
    {
        private readonly IKameraServices _kameraServices;

        public KameraController(IKameraServices kameraServices)
        {
            _kameraServices = kameraServices;
        }

        [HttpGet]
        public IEnumerable<Kamera> Index()
        {
            return _kameraServices.GetAllList().ToArray();
        }

        [HttpGet("/kamera/{id}")]
        public Kamera Detay(int id)
        {
            return _kameraServices.Get(id);
        }

        [HttpPost("ekle")]
        public Kamera Ekle(Kamera kamera)
        {
            var result = kamera;
            _kameraServices.Add(kamera);

            return result;
        }

        [HttpDelete]
        public Kamera Delete(Kamera kamera)
        {
            var result = kamera;
            _kameraServices.Delete(kamera);

            return result;
        }

        [HttpPut]
        public Kamera Update(Kamera kamera)
        {
            var result = kamera;
            _kameraServices.Update(kamera);

            return result;
        }
    }
}