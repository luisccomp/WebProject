using System.ComponentModel.DataAnnotations;

namespace Webapp.Models
{
    public class Category
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório")]
        [Display(Name = "Nome")]
        public string Name { get; set; }
    }
}