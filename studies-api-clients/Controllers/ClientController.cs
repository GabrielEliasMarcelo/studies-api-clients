using Clients.Services.Model;
using Clients.Services.Services;
using Microsoft.AspNetCore.Mvc;
using studies_api_clients.Dto.Extensions;
using studies_api_clients.DTO;

namespace studies_api_clients.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var clients = _clientService.GetAllClients();
            return Ok(clients);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {

            return Ok();
        }

        [HttpPost]
        public IActionResult Create(ClientDto clientdto)
        {
            _clientService.InsertClient(clientdto.ClientDtoToClient());
            return Ok(new { message = "Client created" });
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id)
        {
            return Ok(new { message = "Client updated" });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            return Ok(new { message = "Client deleted" });
        }
    }
}
