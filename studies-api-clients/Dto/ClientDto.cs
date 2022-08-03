namespace studies_api_clients.DTO
{
    public class ClientDto
    {
        public int? IdClient { get; set; }

        public string Name { get; set; }

        public DateTime BirthDt { get; set; }

        public decimal IdNumber { get; set; }

        public int IdBirthCountry { get; set; }

        public bool? Excluded { get; set; }

        public DateTime? RegistrationDt { get; set; }

        public DateTime? UpdateDt { get; set; }
    }
}
