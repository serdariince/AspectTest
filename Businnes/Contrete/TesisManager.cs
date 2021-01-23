using System.Collections.Generic;
using System.Linq;
using Businnes.Abstract;
using DataAccess.Abstrast;
using Entities;

namespace Businnes.Contrete
{
    public class TesisManager : ITesisServices
    {
        private readonly ITesisDal _tesisDal;

        public TesisManager(ITesisDal tesisDal)
        {
            _tesisDal = tesisDal;
        }

        public List<Tesis> GetAllList()
        {
            return _tesisDal.GetTesisler().ToList();
        }

        public Tesis Get(int id)

        {
            return _tesisDal.Get(x => x.Id == id);
        }

        public void Add(Tesis tesis)
        {
            _tesisDal.Add(tesis);
        }

        public void Update(Tesis tesis)
        {
            _tesisDal.Update(tesis);
        }

        public void Delete(Tesis tesis)
        {
            _tesisDal.Delete(tesis);
        }
    }
}