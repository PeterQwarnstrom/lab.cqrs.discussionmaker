using System;
using System.Collections.Generic;

namespace lab.cqrs.discussionmaker.infrastructure.EventStore
{
	public interface IEventStore
	{
		void SaveEvents(Guid aggregateId, IEnumerable<Message.Event> events, int expectedVersion);
		List<Message.Event> GetEventsForAggregate(Guid aggregateId);
	}
}
