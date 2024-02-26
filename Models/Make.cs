
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace netan.Models
{
    public class Make
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<Model> Models { get; set; }
        public Make()
        {
            Models = new Collection<Model>(); 
        }
    }
}