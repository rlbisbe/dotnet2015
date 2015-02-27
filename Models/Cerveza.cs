using System.ComponentModel.DataAnnotations;

namespace MvcSample.Web.Models
{
    public class Cerveza
    {
        [Required]
        [MinLength(4)]
        public string Nombre { get; set; }
        public double Percent { get; set; }
    }
}