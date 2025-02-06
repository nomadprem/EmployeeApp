namespace EmployeeApp.Models
{
    public class Employee
    {
        private static int _idCounter = 1; // Auto-increment ID

        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }

        // Parameterless constructor (required for model binding)
        public Employee()
        {
            EmployeeID = _idCounter++; // Auto-generate ID even when using parameterless constructor
        }

        // Constructor with parameters
        public Employee(string firstName, string lastName, string jobTitle, decimal salary)
        {
            EmployeeID = _idCounter++;
            FirstName = firstName;
            LastName = lastName;
            JobTitle = jobTitle;
            Salary = salary;
        }
    }
}
