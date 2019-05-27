namespace Names.TestAnswers.Benjamin
{
	public class ActivityNameSelector
	{
		private const int ShortNameLength = 50;

		public string NameInTrainingProgram { get; set; }
		public string NameInSourceTemplate { get; set; }
		public string NameInBaseLine { get; set; }

		public string GetName()
		{
			if (!string.IsNullOrWhiteSpace(NameInTrainingProgram))
			{
				return NameInTrainingProgram;
			}

			if (!string.IsNullOrWhiteSpace(NameInSourceTemplate))
			{
				return NameInSourceTemplate;
			}

			if (!string.IsNullOrWhiteSpace(NameInBaseLine))
			{
				return NameInBaseLine;
			}

			return string.Empty;
		}

		public string GetShortName()
		{
			var actualName = GetName();
			return actualName
				.ToLower()
				.Substring(0, ShortNameLength);
		}
	}

	public class ActivityManagerDemo
	{
		public void Demo()
		{
			var activityManager = new ActivityNameSelector
			{
				NameInSourceTemplate = "name in Source template"
			};

			var name = activityManager.GetName();
			var shortName = activityManager.GetShortName();
		}
	}
}