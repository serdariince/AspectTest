using Core.Concrete;

namespace Entities
{
    public class Ip : IEntitiy
    {
        public int Id { get; set; }
        public string IpName { get; set; }
        public Kamera Kamera { get; set; }
    }
}