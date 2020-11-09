using Alice.Backend.DTO;
using Alice.Backend.Logic.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Alice.Backend.Controllers
{
    [Route("/")]
    [ApiController]
    public class AliceController : ControllerBase
    {
        private IMediator _mediator;

        public AliceController(IMediator mediator)
          : base()
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> DialogQuery([FromBody] MessageRequest message)
        {
            var result = await _mediator.Send(new MessageQuery()
            {
                Message = message.request.command
            });

            return Ok(new MessageResponce(result.Message, message.session));
        }
    }
}
