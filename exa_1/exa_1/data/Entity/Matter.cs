using System.ComponentModel.DataAnnotations;


namespace exa_1.data.Entity
{
    public class Matter
    {
        public int Id { get; set; }

        [Display(Name = "nombre de la materia")]
        public string name_matter { get; set; } = null!;

        [Display(Name = "numero de aprobados ")]
        public string number_of_approved { get; set; } = null!;

        [Display(Name = "numero de reprobados")]
        public string number_of_failed { get; set; } = null!;
        public bool IsActive { set; get; }

    }
}
