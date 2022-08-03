using Clients.Services.Model;
using studies_api_clients.DTO;

namespace studies_api_clients.Dto.Extensions
{
    public static class ClientDtoExtensions
    {

        public static Client ClientDtoToClient(this ClientDto clientDto)
        {
            Client client = new Client();

            if (clientDto.IdClient.HasValue)
                client.IdClient = clientDto.IdClient.Value;

            if (clientDto.UpdateDt.HasValue)
                client.UpdateDt = clientDto.UpdateDt.Value;

            if (clientDto.RegistrationDt.HasValue)
                client.RegistrationDt = clientDto.RegistrationDt.Value;

            if (clientDto.Excluded.HasValue)
                client.Excluded = clientDto.Excluded.Value;

            client.Name = clientDto.Name;
            client.BirthDt = clientDto.BirthDt;
            client.IdBirthCountry = clientDto.IdBirthCountry;
            client.IdNumber = clientDto.IdNumber;

            return client;

        }
    }
}
