using Names.TestAnswers.ActivitySelector.Entities;

namespace Names.TestAnswers.ActivitySelector
{
	public class Demo
	{
		public void Execute()
		{
			//Let's assume objects being received from an external service

			TrainingProgram trainingProgram = null;
			BaseLine baseLine = null;
			SourceTemplate sourceTemplate = new SourceTemplate()
			{
				Activity = new Activity("name in Source template")
			};

			var selector = new ActualActivitySelector();

			var actualActivity = selector.Select(
				trainingProgram,
				sourceTemplate,
				baseLine);

			var name = actualActivity.Name;
			var simplifiedName = actualActivity.SimplifiedName;
		}
	}
}