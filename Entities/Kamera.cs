using System.ComponentModel.DataAnnotations;
using Core.Concrete;

namespace Entities
{
    public class Kamera : IEntitiy
    {

        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string SeriNo { get; set; }


        public int? IpId { get; set; }
        public Ip Ip { get; set; }
        public int? TesisId { get; set; }
        public Tesis Tesis { get; set; }
    }
}