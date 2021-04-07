using System.ComponentModel.DataAnnotations;

namespace CrudCarro.Entities
{
    public class Carros
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string tipo { get; set; }
        public int valor { get; set; }
    }
}
