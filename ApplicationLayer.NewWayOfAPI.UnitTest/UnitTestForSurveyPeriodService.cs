using System;
using Xunit;
using Moq;
using ApplicationLayer.NewWayOfAPI.UseCases.SurveyPeriod.Ports.Input;
using ApplicationLayer.NewWayOfAPI.UseCases.SurveyPeriod.Ports.Output;
using ApplicationLayer.NewWayOfAPI.Exceptions;
using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod;
using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod.Ports.Input;

namespace ApplicationLayer.NewWayOfAPI.UnitTest
{
    public class UnitTestForSurveyPeriodService
    {
        [Fact]
        public void Save_Survey_Period_Test_For_Exceptions()
        {
            //ARRANGE
            var surveyPeriodEntity = new SurveyPeriodEntity();
            var surveyPeriodDomainPortIP = new Mock<ISurveyPeriodDomainPortIP>();
            var surveyPeriodRepository = new Mock<ISurveyPeriodRepository>();
            var surveyPeriodService = new SurveyPeriodService(surveyPeriodDomainPortIP.Object, surveyPeriodRepository.Object);

            //ACT
            //var ex = Assert.Throws<SurveyPeriodException>(() => surveyPeriodService.SaveSurveyPeriod(surveyPeriodEntity));

            //ASSERT
            Assert.Throws<SurveyPeriodException>(() => surveyPeriodService.SaveSurveyPeriod(surveyPeriodEntity));
        }

        [Fact]
        public void Save_Survey_Period_Test_For_Exceptions_Messages()
        {
            //ARRANGE
            var surveyPeriodEntity = new SurveyPeriodEntity();
            var surveyPeriodDomainPortIP = new Mock<ISurveyPeriodDomainPortIP>();
            var surveyPeriodRepository = new Mock<ISurveyPeriodRepository>();
            var surveyPeriodService = new SurveyPeriodService(surveyPeriodDomainPortIP.Object, surveyPeriodRepository.Object);

            //ACT
            var ex = Assert.Throws<SurveyPeriodException>(() => surveyPeriodService.SaveSurveyPeriod(surveyPeriodEntity));

            //ASSERT
            Assert.Equal("Invalid Survey Period", ex.Message);
        }

    }
}
