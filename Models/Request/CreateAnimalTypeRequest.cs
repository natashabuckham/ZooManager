using System.ComponentModel.DataAnnotations;

namespace ZooManager.Models.Request
{
    public class CreateAnimalTypeRequest
    {
        [Required]
        public string Species { get; set; }
        
        [Required]
        public string Classification { get; set; }
 
    }
}