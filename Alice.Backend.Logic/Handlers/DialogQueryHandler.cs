using Alice.Backend.Logic.DTO;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Alice.Backend.Logic.Handlers
{
    public class DialogQueryHandler : IRequestHandler<MessageQuery, MessageQueryResult>
    {
        public Task<MessageQueryResult> Handle(MessageQuery request, CancellationToken cancellationToken)
        {
            string answer;

            if (string.IsNullOrWhiteSpace(request.Message))
            {
                answer = "Ку";
            }
            else if (request.Message.ToLower().Contains("мя"))
            {
                answer = "Кря";
            }
            else answer = "Че";

            return Task.FromResult(new MessageQueryResult()
            {
                Message = answer
            });
        }
    }
}
