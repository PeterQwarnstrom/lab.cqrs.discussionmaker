using System;

namespace lab.cqrs.discussionmaker.Commands
{
	public class CreateDiscussion : Command
	{
		public readonly Guid DiscussionId;
		public readonly string FirstItemId;
		public readonly string CreatedItemId;


		public CreateDiscussion(Guid discussionId, string firstItemId, string createdItemId)
		{
			DiscussionId = discussionId;
			FirstItemId = firstItemId;
			CreatedItemId = createdItemId;
		}
	}
}
