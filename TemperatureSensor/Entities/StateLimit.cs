using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TemperatureSensor.Entities
{
    public class StateLimit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StateLimitsId { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public StateLimit()
        {
            
        }

        public StateLimit(string name, int limit)
        {
            Name = name;
            Value = limit;
        }
    }
}
