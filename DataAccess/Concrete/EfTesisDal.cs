using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstrast;
using DataAccess.Concrete.EntitiyRepository;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class EfTesisDal : EfEntityRepositoryBase<Tesis, EnvanterTakipContext>, ITesisDal
    {
        public List<Tesis> GetTesisler(Expression<Func<Tesis, bool>> filter = null)
        {
            using (var context = new EnvanterTakipContext())
            {
                return filter == null
                    ? context.Set<Tesis>()
                        ?.Include(x => x.Kameralar)
                        ?.ThenInclude(x => x.Ip)?.Include(x => x.KayitProgrami).ToList()
                    : context.Set<Tesis>()?.Include(x => x.Kameralar)
                        ?.ThenInclude(x => x.Ip)?.Include(x => x.KayitProgrami).Where(filter).ToList();
            }
        }
    }
}