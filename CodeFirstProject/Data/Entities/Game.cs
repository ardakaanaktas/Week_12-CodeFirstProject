using System.ComponentModel.DataAnnotations;

namespace CodeFirstProject.Data.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Platform { get; set; }
        [Range(0, 10)]
        public decimal Raiting { get; set; }
    }
}
