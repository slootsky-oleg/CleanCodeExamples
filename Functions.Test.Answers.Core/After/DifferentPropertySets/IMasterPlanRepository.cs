namespace Functions.Test.Answers.Core.After.DifferentPropertySets
{
	public interface IMasterPlanRepository
	{
		MasterPlan Get(long id);
		MasterPlanHeader GetHeader(long id);
	}
}