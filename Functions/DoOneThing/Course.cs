using System.Collections.Generic;
using System.Linq;

namespace Functions.DoOneThing
{
	public class Course
	{
		private readonly IList<Participant> participants;

		public string Name { get; }
		public int Id { get; }

		public IReadOnlyList<Participant> Participants => participants
			.Where(x => x.IsA && x.IsB || x.IsC)
			.ToList();

		public Course(int id, string name, IEnumerable<Participant> participants)
		{
			Id = id;
			Name = name;
			this.participants = participants.ToList();
		}
	}
}