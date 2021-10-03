using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod;

namespace DomainLayer.NewWayOfAPI.Entities.SurveyPeriod.Ports.Output
{
    public interface ISurveyPeriodDomainRepository
    {
        public bool Create();
        public bool Update();
        public bool Delete();
        public IList<SurveyPeriodEntity> SelectAllSurveyPeriod();
        public SurveyPeriodEntity GetSurveyPeriod();

        public bool CheckSurveyPeriodNameIsUnique(string surveyPeriodName);
    }
}
