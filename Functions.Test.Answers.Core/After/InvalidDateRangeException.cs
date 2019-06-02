using System;

namespace Functions.Test.Answers.Core.After
{
	public class InvalidDateRangeException : Exception
	{
		public DateTime Start { get; }
		public DateTime End { get; }

		public InvalidDateRangeException(DateTime start, DateTime end)
			: base($"Invalid date range {start} - {end}")
		{
			Start = start;
			End = end;
		}
	}
}