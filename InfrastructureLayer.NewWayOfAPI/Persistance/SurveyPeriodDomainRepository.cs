using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod;
using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod.Ports.Output;

namespace InfrastructureLayer.NewWayOfAPI.Persistance
{
    public class SurveyPeriodDomainRepository : ISurveyPeriodDomainRepository
    {
        public bool CheckSurveyPeriodNameIsUnique(string surveyPeriodName)
        {
            throw new NotImplementedException();
        }

        public bool Create()
        {
            throw new NotImplementedException();
        }

        public bool Delete()
        {
            throw new NotImplementedException();
        }

        public SurveyPeriodEntity GetSurveyPeriod()
        {
            throw new NotImplementedException();
        }

        public IList<SurveyPeriodEntity> SelectAllSurveyPeriod()
        {
            throw new NotImplementedException();
        }

        public bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
