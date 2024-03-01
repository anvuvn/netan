using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Collections.ObjectModel;

namespace netan.Models
{
    [Table("Vehicles")]
    public class Vehicle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ModelId { get; set; }
        public Model model { get; set; }
        public bool IsRegistered { get; set; }
 
        [Required]
        [StringLength(255)]
        public string ContactName {get;set;}

        [StringLength(255)]
        public string ContactEmail  { get; set; }

        [Required]
        [StringLength(255)]
        public string ContactPhone { get; set; }

        public DateTime LastUpdate { get; set; }

        public ICollection<Feature> Features { get; set; }

        public Vehicle()
        {
            Features = new Collection<Feature>();
        }
    }
}