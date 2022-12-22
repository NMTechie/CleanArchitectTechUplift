using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod.Ports.Input;
using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod.Ports.Output;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Whether a Concept is Entity or Value Object totally depends on the 
 * bounded context under the problem domain we are building the app
 * The main difference lies on the euality concept. If it depends upon 
 * identity equality (means even if the attributes value chnaged 
 * it will be identified same instance until ID field change) then it is Entity.
 */

namespace DomainLayer.NewWayOfAPI.Entities.SurveyPeriod
{
    public class SurveyPeriodEntity : AuditableEntity, ISurveyPeriodDomainOperation
    {
        public long? SurveyPeriodId { get; set; }
        public string SurveryPeriodName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        private ISurveyPeriodDomainRepository _domainRepository;
        public SurveyPeriodEntity(ISurveyPeriodDomainRepository surveyPeriodDomainRepository)
        {
            _domainRepository = surveyPeriodDomainRepository;
        }

        public bool IsSurveyPeriodUnique()
        {
            return _domainRepository.CheckSurveyPeriodNameIsUnique(this.SurveryPeriodName);
        }

        public bool IsValidSurveyPeriod()
        {            
            return this.StartDate < this.EndDate;
        }



    }
}
