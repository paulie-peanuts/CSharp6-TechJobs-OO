using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        //Testing Objects
        //initalize your testing objects here
        //Testing objects
        Job job1 = new Job();

        Job job2 = new Job();

        Job job3 = new Job(
            "Product tester",
            new Employer("ACME"),
            new Location("Desert"),
            new PositionType("Quality control"),
            new CoreCompetency("Persistence")
        );

        Job job4 = new Job(
            "Product tester",
            new Employer("ACME"),
            new Location("Desert"),
            new PositionType("Quality control"),
            new CoreCompetency("Persistence")
        );

        Job job5 = new Job(
            "Product tester",
            new Employer(""),
            new Location("Desert"),
            new PositionType("Quality control"),
            new CoreCompetency("Persistence")
        );

        [TestMethod]
        public void TestSettingJobId()
        {
            string message = "A subsequent job has it's id increased by 1 by the empty constructor";
            Assert.AreEqual(job1.Id + 1, job2.Id, message);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            string message = " is set correctly by the full constructor";
            Assert.AreEqual("Product tester", job3.Name, "Name" + message);
            Assert.AreEqual("ACME", job3.EmployerName.ToString(), "Employer name" + message);
            Assert.AreEqual("Desert", job3.EmployerLocation.ToString(), "Employer location" + message);
            Assert.AreEqual("Quality control", job3.JobType.ToString(), "Job type" + message);
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.ToString(), "Job core competency" + message);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            string message = "Two objects are not equal because of different id values";
            Assert.AreNotEqual(job1, job2, message);
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            string message = "The custom ToString() begins and ends with a new line";
            Assert.AreEqual(char.Parse(Environment.NewLine), job1.ToString()[0], message);
            Assert.AreEqual(char.Parse(Environment.NewLine), job1.ToString()[^1], message);
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string nl = Environment.NewLine;
            string message = " is formatted correctly inside ToString()";
            string output = nl + "ID: " + job3.Id + nl + "Name: Product tester" + nl + "Employer: ACME" + nl + "Location: Desert" + nl + "Position Type: Quality control" + nl + "Core Competency: Persistence" + nl;

            StringAssert.Contains(job3.ToString(), "ID: 23", "ID" + message);
            StringAssert.Contains(job3.ToString(), "Name: Product tester", "Name" + message);
            StringAssert.Contains(job3.ToString(), "Employer: ACME", "Employer" + message);
            StringAssert.Contains(job3.ToString(), "Location: Desert", "Location" + message);
            StringAssert.Contains(job3.ToString(), "Position Type: Quality control", "Position Type" + message);
            StringAssert.Contains(job3.ToString(), "Core Competency: Persistence", "Core Competency" + message);
            Assert.AreEqual(output, job3.ToString(), "The entire output" + message);
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            string none = "Data not available";
            string message = "If a field is left empty, " + none + " message appears";
            Assert.AreEqual(none, job5.EmployerName.ToString(), message);
        }
    }
}
