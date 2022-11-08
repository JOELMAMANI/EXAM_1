using System.ComponentModel.DataAnnotations;

namespace exa_1.data.Entity
{
    public class Grade
    {
        public int Id { get; set; }
        [Display(Name = "numero de estudiantes")]
        public string number_students { get; set; } = null!;

        [Display(Name = "promedio")]
        public string average { get; set; }= null!;
        public bool IsActive { set; get; }

    }
}
