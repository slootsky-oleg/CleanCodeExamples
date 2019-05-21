using System.Linq;

namespace Functions.DoOneThing.After
{
	public class ParticipantsProvider
	{
		private readonly ICourseRepository courseRepository;

		public ParticipantsProvider(ICourseRepository courseRepository)
		{
			this.courseRepository = courseRepository;
		}

		public int GetNumberOfCourseParticipants(int ownerId)
		{
			var courses = courseRepository.GetByOwner(ownerId);

			return courses
				.Select(c => c.Participants.Count)
				.Sum();
		}
	}
}