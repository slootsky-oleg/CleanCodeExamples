using System;

namespace Functions.Test.Answers.Core.After
{
	public class DateRange
	{
		public DateTime Start { get; }
		public DateTime End { get; }

		public DateRange(DateTime start, DateTime end)
		{
			if (start < end)
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