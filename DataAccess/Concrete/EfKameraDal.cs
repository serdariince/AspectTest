using Core.DataAccess.EntityFramework;
using DataAccess.Abstrast;
using DataAccess.Concrete.EntitiyRepository;
using Entities;

namespace DataAccess.Concrete
{
    public class EfKameraDal : EfEntityRepositoryBase<Kamera, EnvanterTakipContext>, IKameraDal
    {
    }
}