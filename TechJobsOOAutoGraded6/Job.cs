using System;

namespace TechJobsOOAutoGraded6
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency)
            : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
            // if (EmployerName.ToString() = "")
            // {

            // }
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string nl = Environment.NewLine;
            if (Name == "")
            {
                Name = "Data not available";
            }
            return nl + "ID: " + Id + nl + "Name: " + Name + nl + "Employer: " + EmployerName + nl + "Location: " + EmployerLocation + nl + "Position Type: " + JobType + nl + "Core Competency: " + JobCoreCompetency + nl;
        }
        // TODO: Task 3: Add the two necessary constructors.

        // TODO: Task 3: Generate Equals() and GetHashCode() methods.

        // TODO: Task 5: Generate custom ToString() method.
        //Until you create this method, you will not be able to print a job to the console.

    }
}
