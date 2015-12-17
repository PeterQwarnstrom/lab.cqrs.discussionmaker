using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.cqrs.discussionmaker.infrastructure
{
	public interface IRepository<T> where T : AggregateRoot, new()
	{
		void Save(AggregateRoot aggregate, int expectedVersion);
		T GetById(Guid id);
	}

}
