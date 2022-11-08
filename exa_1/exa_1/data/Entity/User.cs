using System.ComponentModel.DataAnnotations;


namespace exa_1.data.Entity
{
    public class User
    {
        public Guid Id { get; set; }

        [Display(Name = "nombre")]
        public string Name { get; set; } = null!;

        [Display(Name = "codigo")]
        public string code { get; set; } = null!;

        [Display(Name = "promedio")]
        public string average { get; set; } = null!;
        public bool IsActive { set; get; }

    }
}
