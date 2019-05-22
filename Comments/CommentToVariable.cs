using System;

namespace Comments.CommentToVariable
{
	public class CommentToVariable
	{
		public void CommentToVariable()
		{
			FoxAdministration.Course currCourse = FoxAdministration.AdministrationEnityFactory.CreateCourse<FoxAdministration.Course>(CurrPortal.OriginalEntityID);

			BEFORE:
			/* Also violates DRY - Don't repeat yourself*/
			//If tp dos not have end date (01/01/2100) than hide the end date field
			if (currCourse.EndDate == DateTimeCommon.MaxFutureDate)
				EndDateTr.Visible = false;

			AFTER:
			if (currCourse.HasEndDate)
				EndDateTr.Visible = false;



			BEFORE:
			if (SystemConfiguration.EnableReferToLatestMasterPlanVersion && currCourse.ID > 0 && currCourse.CurrentCourseTemplateID > 0)
				trReferredToMasterPlanName.Style.Remove("display");
			...
			if (SystemConfiguration.EnableReferToLatestMasterPlanVersion && currCourse.ID > 0 && currCourse.CurrentCourseTemplateID > 0)
				MasterPlanNameReferredToLink.Visible = true;

			AFTER:
			var referToLatestMasterPlanVersion = 
				SystemConfiguration.EnableReferToLatestMasterPlanVersion 
				&& currCourse.ID > 0 
				&& currCourse.CurrentCourseTemplateID > 0;

			if (referToLatestMasterPlanVersion)
				trReferredToMasterPlanName.Style.Remove("display");
					...
			if (referToLatestMasterPlanVersion)
				MasterPlanNameReferredToLink.Visible = true;



			BEFORE:
			var mp = currCourse.CourseTemplate;
				...
			if (IsUserManager 
			    && currCourse.WasCreatedBasedOnFutureBaselineVersion
			    && mp.EffectiveDate > DateTime.Today 
			    && mp.VersionStatus == BOL.Enums.VersionStatus.FutureBaseline)

			AFTER:
			if (IsUserManager && currCourse.IsActiveFutureBaseLine)
		}
	}
}