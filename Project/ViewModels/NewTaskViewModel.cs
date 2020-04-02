using System.ComponentModel.DataAnnotations;

namespace Project.ViewModels
{
    public class NewTaskViewModel
    {
        [Required(ErrorMessage ="Zadanie musi posiadać tytuł")]
        public string Title { get; set; }
        public string Desc { get; set; }
    }
}
