using Moq;
using NUnit.Framework;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using static Service.MethodClass;

namespace NUnit_Assignment_9
{
    [TestFixture]
    public class TestCaseClass
    {
        private MethodClass _service;
        private AgeData _ageData;
        private AgeData _originalData;
        [SetUp]
        public void Setup()
        {
            _service = new MethodClass();
            _originalData = new AgeData();

            // Mock  Method Setup
            // Mock Object Creation
            var ageDatabase = new Mock<AgeData>();

            //Setup and Ovverride 
            ageDatabase.Setup(m => m.DataUsers()).Returns(new List<AgeData>()
            {
                 new AgeData { Name = "Devyani", Age = 19, Address = "Gujarat" },
                new AgeData { Name = "Sanjay", Age = 51, Address = "Keral" },
                new AgeData { Name = "Vandana", Age = 41, Address = "Goa" },
            });

            // Object Assigning

            _ageData = ageDatabase.Object;
            // End of Mock method setup
        }

        // Test Case 1
        [Test]
        public void CheckDataListAge()
        {
            var result = _service.GetUserData();
            Assert.That(result, Has
                .Count.EqualTo(5)
                .And.Exactly(5).Property("Age").GreaterThan(18)
                );
        }

        // Test Case 2
        [Test]
        public void Check_Name_In_DataList()
        {
            var result = _service.GetUserData();
            Assert.That(result, Has
                .Some.Property("Name").EqualTo("Devyani"));
        }

        // Test Case 3
        [Test]
        public void Check_Address()
        {
            var result = _service.GetUserData();
            Assert.That(result, Has
                .Count.EqualTo(5)
                .And.No.Some.Property("Address").EqualTo("America"));
        }

        // Test Case 4
        [Test]
        public void Equal_Vs_Equivalent()
        {
            var a = new List<int> { 1, 3, 5 };
            var b = new List<int> { 5, 3, 1 };
            Assert.That(a, Is.Not.EqualTo(b));
            Assert.That(b, Is.EquivalentTo(a));

        }

        // Test Case 5
        [Test]
        [Obsolete]
        public void Mapping_In_List()
        {
            Assert.That(List.Map(new List<string>() { "1", "22", "333" }).Property("Length"), Is.EqualTo(new List<int>() { 1, 2, 3 }));

        }

        [TearDown]
        public void CleanUpAfterTest()
        {
            //REngineExecutionContext.ClearLog();
        }

        [OrderedTest(0)]
        public void Test1() { }

        [OrderedTest(1)]
        public void Test2() { }

        [OrderedTest(2)]
        public void Test3() { }

        [TestCaseSource(sourceName: "TestSource")]
        public void MainTest(TestStructure test)
        {
            test.Test();
        }

        public static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                var assembly = Assembly.GetExecutingAssembly();
                Dictionary<int, List<MethodInfo>> methods = assembly
                    .GetTypes()
                    .SelectMany(x => x.GetMethods())
                    .Where(y => y.GetCustomAttributes().OfType<OrderedTestAttribute>().Any())
                    .GroupBy(z => z.GetCustomAttribute<OrderedTestAttribute>().Order)
                    .ToDictionary(gdc => gdc.Key, gdc => gdc.ToList());

                foreach (var order in methods.Keys.OrderBy(x => x))
                {
                    foreach (var methodInfo in methods[order])
                    {
                        MethodInfo info = methodInfo;
                        yield return new TestCaseData(
                            new TestStructure
                            {
                                Test = () =>
                                {
                                    object classInstance = Activator.CreateInstance(info.DeclaringType, null);
                                    info.Invoke(classInstance, null);
                                }
                            }).SetName(methodInfo.Name);
                    }
                }
            }
        }

        [Test]
        public void CustomConstraint_Lower()
        {
            string value = "sanjay";

            Assert.That(value, Is.IsLower(value));
        }

        [Test]
        public void Custom_TestCase_Oject_Type_string()
        {
            string value = "SANJAY";

            Assert.That("sANJAY", Is.IsLower(value));
        }

        [Test]
        public void Custom_TestCase_example3()
        {
            string value = "Chetan More";

            Assert.That("chetan More", Is.IsLower(value));
        }

        [Test]
        public void Upper_CustomConstraint_check()
        {
            string value = "chetan";
            Assert.That("Chetan", Is.IsUpper(value));
        }

        [Test]
        public void Upper_CustomConstraint_check_Multi_String()
        {
            string value = "chetan more";
            Assert.That("Chetan more", Is.IsUpper(value));
        }

        [Test]
        public void AgeData_original_AgeData_Check()

        {
            var result = _originalData.DataUsers();
            Assert.That(result, Has
                .Count.EqualTo(5)
                .And.Exactly(5).Property("Age").GreaterThan(18)
                );
        }

        [Test]
        public void Mock_False1_Checking_Count_List_False_Check()
        {
            //Assert
            Assert.False(_ageData.DataUsers().Count == 4);
        }

        [Test]
        public void Mock_True2_Checking_Count_List_True_Check()
        {
            //Assert
            Assert.True(_ageData.DataUsers().Count == 3);
        }

        [Test]
        public void Mock_Assert_That3_Checking_Count_List_With_Assert_That_Function()
        {

            //Assert
            Assert.That(_ageData.DataUsers(), Has
                     .Count.EqualTo(3)
                     .And.Exactly(3).Property("Age").GreaterThan(18)
                     );
        }

        [Test]
        public void Mock_Name4_Checking_Count_List_Name_Search_Check()
        {
            // Act
            var result = _ageData.DataUsers();
            //Assert
            Assert.That(result, Has
                .Some.Property("Name").EqualTo("Devyani"));
        }

        [Test]
        public void Mock_Address5_Checking_Count_List_Address_Check()
        {
            var result = _ageData.DataUsers();
            Assert.That(result, Has
                .Count.EqualTo(3)
                .And.Some.Property("Address").EqualTo("Goa"));
        }

    }

}
