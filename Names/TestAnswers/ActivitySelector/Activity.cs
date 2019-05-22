using System;

namespace Names.TestAnswers.ActivitySelector
{
	public class Activity
	{
		private const int MaxSimplifiedNameLength = 50;

		public string Name { get; }
		public string SimplifiedName { get; }

		public Activity(string name)
		{
			Name = name ?? throw new ArgumentNullException(nameof(name));

			SimplifiedName = GetSimplifiedName(name);
		}

		private string GetSimplifiedName(string name)
		{
			var lowerCaseName = Name.ToLower();
			return lowerCaseName.Substring(0, MaxSimplifiedNameLength);
		}
	}
}