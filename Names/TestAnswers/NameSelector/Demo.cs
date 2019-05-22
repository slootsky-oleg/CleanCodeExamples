namespace Names.TestAnswers.NameSelector
{
	public class Demo
	{
		public void Execute()
		{
			var sourceTemplateActivity = new Activity("name in Source template");
			var selector = new ActivityActualNameSelector(
				null,
				sourceTemplateActivity,
				null);

			var name = selector.GetName();
			var simplifiedName = selector.GetSimplifiedName();
		}
	}
}