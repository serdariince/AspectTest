using System.Collections.Generic;
using Entities;

namespace Businnes.Abstract
{
    public interface ITesisServices
    {
        List<Tesis> GetAllList();

        Tesis Get(int id);

        /* Tesis GetKamera(int id);*/
        void Add(Tesis tesis);
        void Update(Tesis tesis);
        void Delete(Tesis tesis);
    }
}