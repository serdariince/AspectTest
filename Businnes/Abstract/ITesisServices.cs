using System.Collections.Generic;
using Entities;

namespace Businnes.Abstract
{
    public interface ITesisServices
    {
        List<Tesis> GetAllList();

        List<Tesis> Get(int id);

        Tesis GetTesis(int id);
        void Add(Tesis tesis);
        void Update(Tesis tesis);
        void Delete(Tesis tesis);
    }
}