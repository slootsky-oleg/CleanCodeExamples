namespace Functions.Test.Answers.Core.DifferentPropertySets
{
	public interface IMasterPlanRepository
	{
		MasterPlan Get(long id);
		MasterPlanHeader GetHeader(long id);
	}
}