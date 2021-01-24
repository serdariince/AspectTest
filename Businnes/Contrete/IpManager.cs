using System.Collections.Generic;
using System.Linq;
using Businnes.Abstract;
using DataAccess.Abstrast;
using Entities;

namespace Businnes.Contrete
{
    public class IpManager : IIpService
    {
        private readonly IIpDal _ipDal;

        public IpManager(IIpDal ipDal)
        {
            _ipDal = ipDal;
        }

        public List<Ip> GetAllList()
        {
            return _ipDal.GetList().ToList();
        }

        public List<Ip> Get(int id)
        {
            return _ipDal.GetList(x => x.Id == id).ToList();
        }

        public void Add(Ip entity)
        {
            _ipDal.Add(entity);
        }

        public void Update(Ip entity)
        {
            _ipDal.Update(entity);
        }

        public void Delete(Ip entity)
        {
            _ipDal.Delete(entity);
        }
    }
}