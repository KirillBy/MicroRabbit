using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MicroRabbint.Banking.Domain.Commands;
using MicroRabbint.Banking.Domain.Events;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbint.Banking.Domain.CommandsHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }
        
        public Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            //publish event to RabbitMQ
            _bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));
            
            return Task.FromResult(true);
        }
    }
}