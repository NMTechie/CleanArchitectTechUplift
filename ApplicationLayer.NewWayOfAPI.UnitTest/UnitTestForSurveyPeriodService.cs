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
        private SurveyPeriodEntity surveyPeriodEntity;
        private Mock<ISurveyPeriodDomainPortIP> surveyPeriodDomainPortIP;
        private Mock<ISurveyPeriodRepository> surveyPeriodRepository;
        private SurveyPeriodService surveyPeriodService;
        public UnitTestForSurveyPeriodService()
        {
            surveyPeriodEntity = new SurveyPeriodEntity();
            surveyPeriodDomainPortIP = new Mock<ISurveyPeriodDomainPortIP>();
            surveyPeriodRepository = new Mock<ISurveyPeriodRepository>();
            surveyPeriodService = new SurveyPeriodService(surveyPeriodDomainPortIP.Object, surveyPeriodRepository.Object);
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
            surveyPeriodDomainPortIP.Setup<bool>(x => x.IsSurveyPeriodUnique(It.IsAny<SurveyPeriodEntity>())).Returns(false);
            surveyPeriodDomainPortIP.Setup<bool>(x => x.IsValidSurveyPeriod(It.IsAny<SurveyPeriodEntity>())).Returns(false);
            
            //ACT
            var ex = Assert.Throws<SurveyPeriodException>(() => surveyPeriodService.SaveSurveyPeriod(surveyPeriodEntity));

            //ASSERT
            Assert.Equal("Invalid Survey Period", ex.Message);
        }

        [Fact]
        public void SaveSurveyPeriod_WhenSurveyPeriodIsNotUniqueAndSurveyPeriodIsValid_ShuouldRaiseException()
        {
            //ARRANGE
            
            surveyPeriodDomainPortIP.Setup<bool>(x => x.IsSurveyPeriodUnique(It.IsAny<SurveyPeriodEntity>())).Returns(false);
            surveyPeriodDomainPortIP.Setup<bool>(x => x.IsValidSurveyPeriod(It.IsAny<SurveyPeriodEntity>())).Returns(true);
            
            var surveyPeriodService = new SurveyPeriodService(surveyPeriodDomainPortIP.Object, surveyPeriodRepository.Object);
            //ACT
            var ex = Assert.Throws<SurveyPeriodException>(() => surveyPeriodService.SaveSurveyPeriod(surveyPeriodEntity));
            //ASSERT
            Assert.Equal("Invalid Survey Period", ex.Message);
        }

        [Fact]
        public void SaveSurveyPeriod_WhenSurveyPeriodIsUniqueAndSurveyPeriodIsNotValid_ShuouldRaiseException()
        {
            //ARRANGE
            surveyPeriodDomainPortIP.Setup<bool>(x => x.IsSurveyPeriodUnique(It.IsAny<SurveyPeriodEntity>())).Returns(true);
            surveyPeriodDomainPortIP.Setup<bool>(x => x.IsValidSurveyPeriod(It.IsAny<SurveyPeriodEntity>())).Returns(false);
            
            var surveyPeriodService = new SurveyPeriodService(surveyPeriodDomainPortIP.Object, surveyPeriodRepository.Object);
            //ACT
            var ex = Assert.Throws<SurveyPeriodException>(() => surveyPeriodService.SaveSurveyPeriod(surveyPeriodEntity));
            //ASSERT
            Assert.Equal("Invalid Survey Period", ex.Message);
        }

        [Fact]
        public void SaveSurveyPeriod_WhenSurveyPeriodIsUniqueAndSurveyPeriodIsValid_ShuouldNotRaiseException()
        {
            //ARRANGE
            surveyPeriodDomainPortIP.Setup<bool>(x => x.IsSurveyPeriodUnique(It.IsAny<SurveyPeriodEntity>())).Returns(true);
            surveyPeriodDomainPortIP.Setup<bool>(x => x.IsValidSurveyPeriod(It.IsAny<SurveyPeriodEntity>())).Returns(true);
            
            surveyPeriodRepository.Setup<bool>(x => x.SaveSurveyPeriod(It.IsAny<SurveyPeriodEntity>())).Returns(true);
            var surveyPeriodService = new SurveyPeriodService(surveyPeriodDomainPortIP.Object, surveyPeriodRepository.Object);
            //ACT
            var result = surveyPeriodService.SaveSurveyPeriod(surveyPeriodEntity);
            //ASSERT
            Assert.True(result);
        }
    }
}
