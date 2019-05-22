namespace Names.TestAnswers.ActivitySelector
{
	public class ActualActivitySelector
	{
		public Activity Select(
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