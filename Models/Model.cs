using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace netan.Models
{
    [Table("Models")]
    public class Model
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        
        public string Name { get; set; }
        
        // Navigation property
        
        [JsonIgnore]
        public Make Make { get; set; }
        public int MakeId { get; set; }

    }
}