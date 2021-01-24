using System.Collections;
using System.Linq;
using Businnes.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace ServiceAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IpController : ControllerBase
    {
        private readonly IIpService _ipService;

        public IpController(IIpService ipService)
        {
            _ipService = ipService;
        }

        [HttpGet]
        public IEnumerable Index()
        {
            var sonuc = _ipService.GetAllList().ToList();
            return sonuc;
        }

        [HttpPost("ekle")]
        public Ip EkleTesis(Ip entity)
        {
            var sonTesis = entity;
            _ipService.Add(entity);
            return sonTesis;
        }

        [HttpGet("/ip/{id}")]
        public IEnumerable Index(int id)
        {
            var sonuc = _ipService.Get(id);
            return sonuc;
        }

        [HttpDelete]
        public void Delete(Ip entity)
        {
            _ipService.Delete(entity);
        }

        [HttpPut]
        public void Update(Ip entity)
        {
            _ipService.Update(entity);
        }
    }
}