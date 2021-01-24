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
    public class EfKameraDal : EfEntityRepositoryBase<Kamera, EnvanterTakipContext>, IKameraDal
    {
      public List<Kamera> KameralarList(Expression<Func<Kamera, bool>> filter = null)
        {
            using (var context = new EnvanterTakipContext())
            {
                return filter == null
                    ? context.Set<Kamera>()
                       
                        ?.Include(x => x.Ip).ToList()
                    : context.Set<Kamera>()?.Include(x=>x.Ip)?.Where(filter).ToList();
            }
        }
    }
}