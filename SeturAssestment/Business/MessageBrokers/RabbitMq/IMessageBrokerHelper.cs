


using Core.Entities.ViewModels;

namespace Business.MessageBrokers.RabbitMq
{
    public interface IMessageBrokerHelper
    {
        void QueueMessage(IRequestModel model);
    }
}
