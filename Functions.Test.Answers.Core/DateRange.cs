using System;

namespace Functions.Test.Answers.Core
{
	public class DateRange
	{
		public DateTime Start { get; }
		public DateTime End { get; }

		public DateRange(DateTime start, DateTime end)
		{
			if (end < start)
				throw new InvalidDateRangeException(start, end);

			Start = start;
			End = end;
		}

		public bool IsOverlap(DateRange other)
		{
			return
				End >= other.Start
				&& Start <= other.End;
		}
	}
}