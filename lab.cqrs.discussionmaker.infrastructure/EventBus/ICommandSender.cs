using lab.cqrs.discussionmaker.infrastructure.Message;

namespace lab.cqrs.discussionmaker.infrastructure.EventBus
{
	public interface ICommandSender
	{
		void Send<T>(T command) where T : Command;
	}
}
