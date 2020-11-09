using MediatR;

namespace Alice.Backend.Logic.DTO
{
    public class MessageQuery : IRequest<MessageQueryResult>
    {
        public string Message { get; set; }
    }
}
