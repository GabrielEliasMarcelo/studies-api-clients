using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clients.Services.Model
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdClient { get; set; }

        public string Name { get; set; }

        public DateTime BirthDt { get; set; }

        public decimal IdNumber { get; set; }

        [ForeignKey("Country")]
        public int IdBirthCountry { get; set; }

        public virtual Country Country { get; set; }

        public bool Excluded { get; set; }

        public DateTime RegistrationDt { get; set; }

        public DateTime UpdateDt { get; set; }
    }
}
