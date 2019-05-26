using System;

namespace Names.TestAnswers.NameSelector
{
	public class ActualActivityNameSelector
	{
		private const int MaxSimplifiedNameLength = 50;

		private readonly string name;
		private readonly string simplifiedName;

		public ActualActivityNameSelector(
			Activity trainingProgramActivity,
			Activity sourceTemplateActivity,
			Activity baseLineActivity)
		{
			var activity = GetActualActivity(trainingProgramActivity, sourceTemplateActivity, baseLineActivity);

			name = activity.Name;

			simplifiedName = name
				.ToLower()
				.Substring(0, MaxSimplifiedNameLength);
		}

		public string GetName()
		{
			return name;
		}

		public string GetSimplifiedName()
		{
			return simplifiedName;
		}


		private static Activity GetActualActivity(
			Activity trainingProgramActivity,
			Activity sourceTemplateActivity,
			Activity baseLineActivity)
		{
			return
				trainingProgramActivity
				?? sourceTemplateActivity
				?? baseLineActivity
				?? throw new InvalidOperationException();
		}
	}
}