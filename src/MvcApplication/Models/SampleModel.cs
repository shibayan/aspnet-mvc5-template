using System.ComponentModel.DataAnnotations;

namespace MvcApplication.Models
{
    public class SampleModel
    {
        [Required]
        public string Name { get; set; }
    }
}