using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Businnes.Abstract
{
    public interface IIpService
    {
        List<Ip> GetAllList();

        List<Ip> Get(int id);

        /* Tesis GetKamera(int id);*/
        void Add(Ip entity);
        void Update(Ip entity);
        void Delete(Ip entity);
    }
}
