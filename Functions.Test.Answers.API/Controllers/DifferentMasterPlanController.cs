using System.Linq;
using System.Web.Http;
using Functions.Test.Answers.API.Models.MasterPlans;
using Functions.Test.Answers.API.Models.MasterPlans.Different;
using Functions.Test.Answers.API.Models.MasterPlans.Participants;
using Functions.Test.Answers.Core;
using Functions.Test.Answers.Core.DifferentPropertySets;

namespace Functions.Test.Answers.API.Controllers
{
	public class DifferentMasterPlanController : ApiController
	{
		private readonly IMasterPlanRepository masterPlanRepository;

		public DifferentMasterPlanController(IMasterPlanRepository masterPlanRepository)
		{
			this.masterPlanRepository = masterPlanRepository;
		}

		public IHttpActionResult Get(long id)
		{
			var masterPlan = GetMasterPlan(id);

			var masterPlanDto = new MasterPlanDto(masterPlan);

			return Ok(masterPlanDto);
		}

		public IHttpActionResult GetPopupInfo(long id)
		{
			var masterPlan = masterPlanRepository.GetHeader(id)
			                 ?? throw new MasterPlanNotFoundException(id);

			var masterPlanPopUpDto = new MasterPlanPopUpDto(masterPlan);

			return Ok(masterPlanPopUpDto);
		}

		public IHttpActionResult GetFixedParticipants(long id)
		{
			var masterPlan = GetMasterPlan(id);

			var builder = new FixedParticipantBuilder(masterPlan);

			var participantsDto = masterPlan
				.FixedParticipants
				.Select(builder.Build);

			return Ok(participantsDto);
		}


		private MasterPlan GetMasterPlan(long id)
		{
			var masterPlan = masterPlanRepository.Get(id)
			                 ?? throw new MasterPlanNotFoundException(id);
			return masterPlan;
		}
	}
}