namespace OrderByAge
{
    class Student
    {
        public string Name { get; set; }
        public int IDNumber { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} with ID: {IDNumber} is {Age} years old.";
        }
    }
}
