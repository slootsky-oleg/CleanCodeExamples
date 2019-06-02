using System;
using Functions.Test.Answers.Core.After;

namespace Functions.Test.Answers.API.Models.Common
{
	public class DateRangeDto
	{
		public DateTime Start { get; }
		public DateTime End { get; }

		public DateRangeDto(DateRange source)
		{
			if (source is null)
				throw new NullReferenceException();

			Start = source.Start;
			End = source.End;
		}
	}
}