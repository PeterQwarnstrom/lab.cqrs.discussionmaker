using lab.cqrs.discussionmaker.CommandHandlers;
using lab.cqrs.discussionmaker.Commands;
using lab.cqrs.discussionmaker.Domain;
using lab.cqrs.discussionmaker.infrastructure.EventBus;
using lab.cqrs.discussionmaker.infrastructure.EventStore;
using lab.cqrs.discussionmaker.Repositories;

namespace lab.cqrs.discussionmaker.api
{
	public static class CommandHandlerConfig
	{
		public static void Register()
		{
			var bus = new FakeBus();

			var storage = new MemoryEventStore(bus);
			var rep = new Repository<Discussion>(storage);
			var commands = new DiscussionCommandHandlers(rep);

			bus.RegisterHandler<CreateDiscussion>(commands.Handle);

			ServiceLocator.Bus = bus;
		}
	}
}
