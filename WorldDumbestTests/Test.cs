using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldDumbestTests
{
    internal class Test
    {
        // Naming convention ClassName_MethodName_ExpectedResult
        public static void WorldDumbestFunction_TrafficLight_ReturnStatus()
        {
            try
            {
                // Arrange: get variables, classes nctions
                string test1 = "RED";
                string test2 = "Green";
                string test3 = " ";
                string test4 = "red";
                WorldDumbestFunction worldDumbest = new WorldDumbestFunction();

                // Act: execute functions
                string result1 = worldDumbest.TrafficLights(test1);
                string result2 = worldDumbest.TrafficLights(test2);
                string result3 = worldDumbest.TrafficLights(test3);
                string result4 = worldDumbest.TrafficLights(test4);

                // Assert: return if the test PASS!
                if (result1 == "STOP") Console.WriteLine("TEST 1: PASS"); else Console.WriteLine("TEST 1: FAILED");
                if (result2 == " ") Console.WriteLine("TEST 2: PASS"); else Console.WriteLine("TEST 2: FAILED");
                if (result3 == " ") Console.WriteLine("TEST 3: PASS"); else Console.WriteLine("TEST 3: FAILED");
                if (result4 == " ") Console.WriteLine("TEST 4: PASS"); else Console.WriteLine("TEST 4: FAILED");


            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
