using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowIntro
{
    [Binding]
    public class TestFixture
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.WriteLine("Before Feature");
        }
        [AfterFeature]
        public static void AfterFeature()
        {
            Console.WriteLine("After Feature");
        }
        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Before Scenario");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("After Scenario");
        }
    }
}
