using lab.cqrs.discussionmaker.infrastructure.EventBus;

namespace lab.cqrs.discussionmaker.api
{
	public static class ServiceLocator
	{
		public static FakeBus Bus { get; set; }
	}
}