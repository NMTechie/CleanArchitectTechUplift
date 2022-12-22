using System;
using Xunit;
using Moq;
using ApplicationLayer.NewWayOfAPI.UseCases.SurveyPeriod.Ports.Input;
using ApplicationLayer.NewWayOfAPI.UseCases.SurveyPeriod.Ports.Output;
using ApplicationLayer.NewWayOfAPI.Exceptions;
using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod;
using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod.Ports.Input;
using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod.Ports.Output;

namespace ApplicationLayer.NewWayOfAPI.UnitTest
{    
    public class UnitTestForSurveyPeriodService
    {
        private SurveyPeriodEntity surveyPeriodEntity;
        private Mock<ISurveyPeriodRepository> surveyPeriodRepository;
        private SurveyPeriodService surveyPeriodService;
        private Mock<ISurveyPeriodDomainRepository> surveyPeriodDomainRepository;
        public UnitTestForSurveyPeriodService()
        {
            surveyPeriodDomainRepository = new Mock<ISurveyPeriodDomainRepository>();
            surveyPeriodEntity = new SurveyPeriodEntity(surveyPeriodDomainRepository.Object);
            surveyPeriodRepository = new Mock<ISurveyPeriodRepository>();
            surveyPeriodService = new SurveyPeriodService(surveyPeriodRepository.Object);
        }
        [Fact]
        public void Save_Survey_Period_Test_For_Exceptions()
        {
            //ARRANGE
            //The arrangement has done in constructor

            //ACT
            //var ex = Assert.Throws<SurveyPeriodException>(() => surveyPeriodService.SaveSurveyPeriod(surveyPeriodEntity));

            //ASSERT
            Assert.Throws<SurveyPeriodException>(() => surveyPeriodService.SaveSurveyPeriod(surveyPeriodEntity));
        }

        [Fact]
        public void SaveSurveyPeriod_WhenSurveyPeriodIsNotUniqueAndSurveyPeriodIsNotValid_ShuouldRaiseException()
        {
            //ARRANGE            
            surveyPeriodEntity.StartDate = DateTime.Now;
            surveyPeriodEntity.EndDate = DateTime.Now.AddDays(-1);
            surveyPeriodDomainRepository.Setup(x=>x.CheckSurveyPeriodNameIsUnique(surveyPeriodEntity.SurveryPeriodName)).Returns(false);  

            //ACT
            var ex = Assert.Throws<SurveyPeriodException>(() => surveyPeriodService.SaveSurveyPeriod(surveyPeriodEntity));

            //ASSERT
            Assert.Equal("Invalid Survey Period", ex.Message);
        }

        [Fact]
        public void SaveSurveyPeriod_WhenSurveyPeriodIsNotUniqueAndSurveyPeriodIsValid_ShuouldRaiseException()
        {
            //ARRANGE
            surveyPeriodEntity.StartDate = DateTime.Now;
            surveyPeriodEntity.EndDate = DateTime.Now.AddDays(1);
            surveyPeriodDomainRepository.Setup(x => x.CheckSurveyPeriodNameIsUnique(surveyPeriodEntity.SurveryPeriodName)).Returns(false);

            var surveyPeriodService = new SurveyPeriodService(surveyPeriodRepository.Object);
            //ACT
            var ex = Assert.Throws<SurveyPeriodException>(() => surveyPeriodService.SaveSurveyPeriod(surveyPeriodEntity));
            //ASSERT
            Assert.Equal("Invalid Survey Period", ex.Message);
        }

        [Fact]
        public void SaveSurveyPeriod_WhenSurveyPeriodIsUniqueAndSurveyPeriodIsNotValid_ShuouldRaiseException()
        {
            //ARRANGE
            surveyPeriodEntity.StartDate = DateTime.Now;
            surveyPeriodEntity.EndDate = DateTime.Now.AddDays(-1);
            surveyPeriodDomainRepository.Setup(x => x.CheckSurveyPeriodNameIsUnique(surveyPeriodEntity.SurveryPeriodName)).Returns(true);

            var surveyPeriodService = new SurveyPeriodService(surveyPeriodRepository.Object);
            //ACT
            var ex = Assert.Throws<SurveyPeriodException>(() => surveyPeriodService.SaveSurveyPeriod(surveyPeriodEntity));
            //ASSERT
            Assert.Equal("Invalid Survey Period", ex.Message);
        }

        [Fact]
        public void SaveSurveyPeriod_WhenSurveyPeriodIsUniqueAndSurveyPeriodIsValid_ShuouldNotRaiseException()
        {
            //ARRANGE
            surveyPeriodEntity.StartDate = DateTime.Now;
            surveyPeriodEntity.EndDate = DateTime.Now.AddDays(1);
            surveyPeriodDomainRepository.Setup(x => x.CheckSurveyPeriodNameIsUnique(surveyPeriodEntity.SurveryPeriodName)).Returns(true);

            surveyPeriodRepository.Setup<bool>(x => x.SaveSurveyPeriod(It.IsAny<SurveyPeriodEntity>())).Returns(true);
            var surveyPeriodService = new SurveyPeriodService(surveyPeriodRepository.Object);
            //ACT
            var result = surveyPeriodService.SaveSurveyPeriod(surveyPeriodEntity);
            //ASSERT
            Assert.True(result);
        }
    }
}
