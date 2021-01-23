using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities;

namespace DataAccess.Abstrast
{
    public interface ITesisDal : IEntityRepository<Tesis>
    {
        List<Tesis> GetTesisler(Expression<Func<Tesis, bool>> filter = null);
    }
}