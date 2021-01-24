using System.Collections.Generic;
using Core.Concrete;

namespace Entities
{
    public class Tesis : IEntitiy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adres { get; set; }


        public ICollection<Kamera> Kameralar { get; set; }
        public KayitProgrami KayitProgrami { get; set; }
    }
}