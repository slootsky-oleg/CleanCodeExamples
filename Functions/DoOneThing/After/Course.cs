using System;
using System.Collections.Generic;
using System.Linq;

namespace Functions.DoOneThing.After
{
	public class Course
	{
		private const int MaxNameLength = 150;

		private readonly IList<Participant> participants;

		public string Name { get; }
		public int Id { get; }

		public IReadOnlyList<Participant> ActiveParticipants => participants
			.Where(x => x.IsA && x.IsB || x.IsC)
			.ToList();

		public Course(int id, string name, IEnumerable<Participant> participants)
		{
			if (name.Length > MaxNameLength)
				throw new InvalidOperationException($"Course {id} Name is too long.");

			Id = id;
			Name = name;
			this.participants = participants?.ToList();
		}
	}
}