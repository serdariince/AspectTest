using Core.DataAccess.EntityFramework;
using DataAccess.Abstrast;
using DataAccess.Concrete.EntitiyRepository;
using Entities;

namespace DataAccess.Concrete
{
    public class EfIpDal : EfEntityRepositoryBase<Ip, EnvanterTakipContext>, IIpDal
    {
    }
}