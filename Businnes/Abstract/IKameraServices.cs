using System.Collections.Generic;
using Entities;

namespace Businnes.Abstract
{
    public interface IKameraServices
    {
        List<Kamera> GetAllList();

        Kamera Get(int id);
        void Add(Kamera kamera);
        void Delete(Kamera kamera);
        void Update(Kamera kamera);
    }
}