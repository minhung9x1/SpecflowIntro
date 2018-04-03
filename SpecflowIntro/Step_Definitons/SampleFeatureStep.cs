using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
namespace SpecflowIntro.Step_Definitons
{
    [Binding]
    class SampleFeatureStep
    {
        public readonly EmployeeDetails employee;

        public SampleFeatureStep(EmployeeDetails emp)
        {
            employee = emp;
        }
        [When(@"I fill all the mandatory details in form")]
        public void WhenIFillAllTheMandatoryDetailsInForm(Table table)
        {
            var details = table.CreateDynamicSet();
            foreach (var item in details)
            {
                employee.Age = (int)item.Age;
                employee.Name = (string)item.Name;
                employee.Phone = (string)item.Phone;
                employee.Email = (string)item.Email;
            }

        }
        [When(@"I fill all the mandatory details in form with (.*) and (.*)")]
        public void WhenIFillAllTheMandatoryDetailsInFormWithAnd(string name, int age)
        {
            Console.WriteLine(name);
            Console.WriteLine(age.ToString());
        }

    }
}
