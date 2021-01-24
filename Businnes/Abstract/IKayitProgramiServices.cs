using System.Collections.Generic;
using Entities;

namespace Businnes.Abstract
{
    public interface IKayitProgramiServices
    {
        List<KayitProgrami> GetAllList();
        List<KayitProgrami> Get(int id);
        void Add(KayitProgrami kayitProgrami);
        void Delete(KayitProgrami kayitProgrami);
        void Update(KayitProgrami kayitProgrami);
    }
}