using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities;

namespace DataAccess.Abstrast
{
    public interface IKameraDal : IEntityRepository<Kamera>
    {
        List<Kamera> KameralarList(Expression<Func<Kamera, bool>> filter = null);
    }
}