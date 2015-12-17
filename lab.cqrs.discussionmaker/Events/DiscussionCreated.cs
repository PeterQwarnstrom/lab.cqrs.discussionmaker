using lab.cqrs.discussionmaker.infrastructure.Message;
using System;

namespace lab.cqrs.discussionmaker.Events
{
	public class DiscussionCreated : Event
	{
		public readonly Guid Id;
		public readonly string FirstItemId;
		public readonly string CreatedItemId;

		public DiscussionCreated(Guid id, string firstItemId, string createdItemId)
		{
			Id = id;
			FirstItemId = firstItemId;
			CreatedItemId = createdItemId;
		}
	}
}
