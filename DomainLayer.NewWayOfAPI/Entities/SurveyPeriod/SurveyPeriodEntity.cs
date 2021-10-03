using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * The Entity should not implement the imcoming port
 * rather should be implemented in seperate adapter in the Application (should be in the same layer as input port ... here Domain layer) layer ??
 * The Entity should mostly remain as POCO 
 * Else if consists the Enterprise logics and 
 * Imcoming Port and enterprise logic seperation need to be very deeply thought through
 * Sometime confusing as well
 */

namespace DomainLayer.NewWayOfAPI.Entities.SurveyPeriod
{
    public class SurveyPeriodEntity : AuditableEntity
    {
        public long? SurveyPeriodId { get; set; }
        public string SurveryPeriodName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
