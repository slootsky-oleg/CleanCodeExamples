using System;

namespace Names.TestAnswers.ActivitySelector.Entities
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

		private static string GetSimplifiedName(string name)
		{
			return name
				.ToLower()
				.Substring(0, MaxSimplifiedNameLength);
		}
	}
}