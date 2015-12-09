namespace lab.cqrs.discussionmaker.infrastructure.EventBus
{
	public interface IEventPublisher
	{
		void Publish<T>(T @event) where T : Message.Event;
	}
}
