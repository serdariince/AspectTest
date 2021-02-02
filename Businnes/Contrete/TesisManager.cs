using System.Collections.Generic;
using System.Linq;
using Businnes.Abstract;
using Core.Aspect.Autofac.Logging;
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

        [LogAspect]
        public List<Tesis> Get(int id)

        {
            return _tesisDal.GetTesisler(x => x.Id == id);
        }

/*        [LogAspect(typeof(Serilogger))]
*/
        public Tesis GetTesis(int id)
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

        public List<Tesis> GetAllList()
        {
            return _tesisDal.GetTesisler().ToList();
        }
    }
}