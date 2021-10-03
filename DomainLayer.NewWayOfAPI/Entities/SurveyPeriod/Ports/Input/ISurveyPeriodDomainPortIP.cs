using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod;

/*
 * The input port is basically the logics on the Entity and Value Objects
 * This could be encaplusated in side the Class it self
 * However gramatically this could be used as well 
 * Input Port design however is bit not prominent in web
 * https://www.dossier-andreas.net/software_architecture/ports_and_adapters.html
 * https://www.c-sharpcorner.com/article/ports-and-adapter-architecture/
 * https://github.com/jasontaylordev/CleanArchitecture
 * https://github.com/ardalis/CleanArchitecture
 * 
 * 
 * Whether Domain should have any I/P or O/P port and adapter (i.e. all work on those will be handled through application layer)
 * or It Should be plain and Simple POCO 
 * with enterprice logic encapsulated 
 * is debated topics
 */
namespace DomainLayer.NewWayOfAPI.Entities.SurveyPeriod.Ports.Input
{
    public interface ISurveyPeriodDomainPortIP
    {
        bool IsValidSurveyPeriod(SurveyPeriodEntity surveyPeriod);        
        bool IsSurveyPeriodUnique(SurveyPeriodEntity surveyPeriod);
    }
}
