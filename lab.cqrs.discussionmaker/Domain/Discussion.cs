using lab.cqrs.discussionmaker.Events;
using lab.cqrs.discussionmaker.infrastructure;
using System;

namespace lab.cqrs.discussionmaker.Domain
{
	public class Discussion : AggregateRoot
	{
		private Guid _id;
		private DiscussionSignature _signature;

		private void Apply(DiscussionCreated e)
		{
			_id = e.Id;
			_signature = new DiscussionSignature(e.FirstItemId, e.CreatedItemId);
		}

		public override Guid Id
		{
			get { return _id; }
		}

		public Discussion()
		{
			// used to create in repository ... many ways to avoid this, eg making private constructor
		}

		public Discussion(Guid id, string firstItemId, string createdItemId)
		{
			ApplyChange(new DiscussionCreated(id, firstItemId, createdItemId));
		}
	}
}
