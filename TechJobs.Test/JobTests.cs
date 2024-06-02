﻿using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

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
        /*[TestMethod]
        public void TestMethod()
        {
            //TODO: Task 4: remove this method before you create your first test method
        }*/
    }
}
