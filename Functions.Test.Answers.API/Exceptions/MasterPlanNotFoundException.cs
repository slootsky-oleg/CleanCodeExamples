using System;

namespace Functions.Test.Answers.API.Exceptions
{
	public class MasterPlanNotFoundException : Exception
	{
		public long Id { get; set; }

		public MasterPlanNotFoundException(long id)
			:base($"Master plan with Id {id} not found.")
		{
			Id = id;
		}
	}
}