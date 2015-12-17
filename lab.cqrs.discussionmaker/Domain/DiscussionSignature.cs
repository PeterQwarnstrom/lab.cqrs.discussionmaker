namespace lab.cqrs.discussionmaker.Domain
{
	public class DiscussionSignature
	{
		private string _firstItemId;
		private string _createdItemId;

		public DiscussionSignature(string firstItemId, string createdItemId)
		{
			_firstItemId = firstItemId;
			_createdItemId = createdItemId;
		}

		public string FirstItemId { get { return _firstItemId; } }
		public string CreatedItemId { get { return _createdItemId; } }

	}
}
