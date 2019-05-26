using System;
using System.Collections.Generic;
using System.Linq;

namespace Functions.DoOneThing.Before
{
	public class ParticipantsProvider
	{
		public int GetCountOfActiveParticipants(OrganizationalUnit organizationalUnit)
		{
			var db = new DbManager("...");
			db.CreateCommand("[dbo].[spr_CoursesByOrganizationalUnit]");
			db.AddIntegerParameter("ouId", organizationalUnit.Id);
			var courses = db.ExecuteDataTable().To<IEnumerable<Course>>();

			int counter = 0;
			foreach (var course in courses)
			{
				var activeParticipants = course
					.Participants
					.Where(x => x.IsA && x.IsB || x.IsC);

				counter += activeParticipants.Count();

				if (course.Name.Length > 150)
					throw new InvalidOperationException($"Course {course.Id} Name is too long.");
			}

			return counter;
		}
	}
}