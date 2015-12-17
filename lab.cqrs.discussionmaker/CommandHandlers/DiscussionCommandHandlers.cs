using lab.cqrs.discussionmaker.Commands;
using lab.cqrs.discussionmaker.Domain;
using lab.cqrs.discussionmaker.infrastructure;

namespace lab.cqrs.discussionmaker.CommandHandlers
{
	public class DiscussionCommandHandlers
	{
		private readonly IRepository<Discussion> _repository;

		public DiscussionCommandHandlers(IRepository<Discussion> repository)
		{
			_repository = repository;
		}

		public void Handle(CreateDiscussion message)
		{
			var item = new Discussion(message.DiscussionId, message.FirstItemId, message.CreatedItemId);
			_repository.Save(item, -1);
		}
	}
}
