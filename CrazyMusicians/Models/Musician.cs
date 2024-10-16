using System.ComponentModel.DataAnnotations;

namespace CrazyMusicians.Models
{
    public class Musician
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Name required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Proficiency required.")]
        public string Profession { get; set; }
        public string FunFact { get; set; }
        public bool IsDeleted { get; set; }

    }
}
