using Core.DataAccess.EntityFramework;
using DataAccess.Abstrast;
using DataAccess.Concrete.EntitiyRepository;
using Entities;

namespace DataAccess.Concrete
{
    public class EfKayitProgramiDal : EfEntityRepositoryBase<KayitProgrami, EnvanterTakipContext>, IKayitProgramiDal
    {
    }
}