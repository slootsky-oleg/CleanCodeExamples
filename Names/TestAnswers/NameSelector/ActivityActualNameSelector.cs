namespace Names.TestAnswers.NameSelector
{
	public class ActivityActualNameSelector
	{
		private const int MaxSimplifiedNameLength = 50;

		private readonly string name;

		public ActivityActualNameSelector(
			Activity trainingProgramActivity,
			Activity sourceTemplateActivity,
			Activity baseLineActivity)
		{
			var activity = GetActualActivity(trainingProgramActivity, sourceTemplateActivity, baseLineActivity);
			name = activity?.Name ?? string.Empty;
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
				?? null;
		}
	}
}