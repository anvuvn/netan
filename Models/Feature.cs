using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Collections.ObjectModel;

namespace netan.Models
{
    [Table("Features")]
    public class Feature
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [JsonIgnore]
        public ICollection<Vehicle> Vehicles { get; set; }

        public Feature()
        {
            Vehicles = new Collection<Vehicle>();
        }
    }
}