using System;
namespace TechJobsOOAutoGraded6
{
	public class PositionType
	{
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }

        public PositionType(string value) : this()
        {
            Value = value;
            if (Value == "")
            {
                Value = "Data not available";
            }
        }

        // TODO: Task 2: Add custom Equals(), GetHashCode(), and ToString() methods.

        
        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object obj)
        {
            return obj is PositionType type &&
                   Id == type.Id;
        }
        /*public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }*/
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}

