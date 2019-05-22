namespace Names.TestAnswers.ActivitySelector
{
	public class Demo
	{
		public void Execute()
		{
			//Let's assume activities being received from an external service
			Activity trainingProgramActivity = null;
			Activity sourceTemplateActivity = new Activity("name in Source template");
			Activity baseLineActivity = null;

			var selector = new ActualActivitySelector();

			var actualActivity = selector.Select(
				trainingProgramActivity,
				sourceTemplateActivity,
				baseLineActivity);

			var name = actualActivity.Name;
			var simplifiedName = actualActivity.SimplifiedName;
		}
	}
}