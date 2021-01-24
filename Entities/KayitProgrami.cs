using Core.Concrete;

namespace Entities
{
    public class KayitProgrami : IEntitiy
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Kanal { get; set; }

        public int? TesisId { get; set; }
        public Tesis Tesis { get; set; }
    }
}