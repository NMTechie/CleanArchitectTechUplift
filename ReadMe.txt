###************************ OpenAPI Support in .NET 5
Swagger Nuget is by deafult implemented

YAGNI principle
(https://jamboard.google.com/d/1YSQylaHARM1yIyguO00bjjG_VmZvhkVqP3fOn6RH6M0/edit?usp=sharing)


Auditable Entity ==> Should be composition with value objects

1. Anemic Entity should be discouraged (If a Object does not have any behaviour then it should be trated as value objects or DTO)

2. SurveyPeriodEntity should have the behaviour that realtes to business function of that entity
	- like Start
	- Update
	- Delete
	- view ??
3. Unit test case naming convention - Cleared on 4th Oct


************ How to mock IFormFile in ASP.NET Core https://stackoverflow.com/questions/36858542/how-to-mock-an-iformfile-for-a-unit-integration-test-in-asp-net-core
************ How to decide what to Moq and what not to Moq https://stackoverflow.com/questions/56905578/moq-non-overridable-members-may-not-be-used-in-setup-verification-expression