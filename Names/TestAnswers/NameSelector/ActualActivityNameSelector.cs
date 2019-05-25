using System;

namespace Names.TestAnswers.NameSelector
{
	public class ActualActivityNameSelector
	{
		private const int MaxSimplifiedNameLength = 50;

		private readonly string name;

		public ActualActivityNameSelector(
			Activity trainingProgramActivity,
			Activity sourceTemplateActivity,
			Activity baseLineActivity)
		{
			var activity = GetActualActivity(trainingProgramActivity, sourceTemplateActivity, baseLineActivity);
			name = activity.Name;
		}

		public string GetName()
		{
			return name;
		}

		public string GetSimplifiedName()
		{
			var lowerCaseName = name.ToLower();

			return lowerCaseName.Substring(0, MaxSimplifiedNameLength);
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