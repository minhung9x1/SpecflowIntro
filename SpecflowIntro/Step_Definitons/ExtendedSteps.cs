using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
namespace SpecflowIntro.Step_Definitons
{
    [Binding]
    public sealed class ExtendedSteps
    {
        public readonly EmployeeDetails employee;

        public ExtendedSteps(EmployeeDetails emp)
        {
            this.employee = emp;
        }
        [Then(@"I should get the same value from Extended steps")]
        public void ThenIShouldGetTheSameValueFromExtendedSteps()
        {
         Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Age.ToString());
            Console.WriteLine(employee.Email);
        }

    }
}
