
using Framework.Core.Messages.Integration;

namespace Framework.Message.Bus.MessageBus

{
    public interface IMessageBus : IDisposable
    {
        Task PublishAsync<T>(T message, CancellationToken cancellationToken) where T : IntegrationEvent;
    }
}
