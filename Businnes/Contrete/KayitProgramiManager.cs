using System.Collections.Generic;
using System.Linq;
using Businnes.Abstract;
using DataAccess.Abstrast;
using Entities;

namespace Businnes.Contrete
{
    public class KayitProgramiManager : IKayitProgramiServices
    {
        private readonly IKayitProgramiDal _kayitProgramiDal;

        public KayitProgramiManager(IKayitProgramiDal kayitProgramiDal)
        {
            _kayitProgramiDal = kayitProgramiDal;
        }

        public List<KayitProgrami> GetAllList()
        {
            return _kayitProgramiDal.GetList().ToList();
        }

        public List<KayitProgrami> Get(int id)
        {
            return _kayitProgramiDal.GetList(x => x.Id == id).ToList();
        }

        public void Add(KayitProgrami kayitProgrami)
        {
            _kayitProgramiDal.Add(kayitProgrami);
        }

        public void Delete(KayitProgrami kayitProgrami)
        {
            _kayitProgramiDal.Delete(kayitProgrami);
        }

        public void Update(KayitProgrami kayitProgrami)
        {
            _kayitProgramiDal.Update(kayitProgrami);
        }
    }
}