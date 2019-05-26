using System;
using System.Data;
using Names.TestAnswers.ActivitySelector.Entities;

namespace Names.TestAnswers.ActivitySelector
{
	public class ActualActivitySelector
	{
		public Activity Select(
			TrainingProgram trainingProgram,
			SourceTemplate sourceTemplate,
			BaseLine baseLine)
		{
			return
				trainingProgram?.Activity
				?? sourceTemplate?.Activity
				?? baseLine?.Activity
				?? throw new InvalidOperationException();
		}
	}
}