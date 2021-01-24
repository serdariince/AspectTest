using System;
using System.Collections.Generic;
using System.Linq;
using Businnes.Abstract;
using DataAccess.Abstrast;
using Entities;

namespace Businnes.Contrete
{
    public class KameraManager : IKameraServices
    {
        private IKameraDal _kameraDal;

        public KameraManager(IKameraDal kameraDal)
        {
            _kameraDal = kameraDal;
        }

        public List<Kamera> GetAllList()
        {
          return  _kameraDal.KameralarList().ToList();
        }



        public Kamera Get(int id)
        {
            return _kameraDal.Get(x=>x.Id==id);
        }

        public void Add(Kamera kamera)
        {
            _kameraDal.Add(kamera);
        }

        public void Delete(Kamera kamera)
        {
            _kameraDal.Delete(kamera);
        }

        public void Update(Kamera kamera)
        {
            _kameraDal.Update(kamera);
        }
    }
}