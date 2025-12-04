using System;
public enum EmploymentStatus
{
    Active,
    OnLeave,
    Terminated
}
public class Employee
{
    public string Name { get; set; }
    public DateTime? HireDate { get; set; }
    public EmploymentStatus Status { get; set; }
    public int GetYearsWorked()
    {
        if (!HireDate.HasValue)
        {
            return -1;
        }
        DateTime currentDate = DateTime.Now;
        int years = currentDate.Year - HireDate.Value.Year;

        if (currentDate < HireDate.Value.AddYears(years))
        {
            years--;
        }
        return years;
    }
    public override string ToString()
    {
        string yearsWorked = HireDate.HasValue ? $"{GetYearsWorked()} лет" : "не указан";
        return $"{Name}, статус: {Status}, стаж: {yearsWorked}";
    }
}
class Program
{
    static void Main()
    {
        var emp = new Employee
        {
            Name = "Пётр",
            HireDate = new DateTime(2020, 3, 15),
            Status = EmploymentStatus.Active
        };
        Console.WriteLine(emp.GetYearsWorked());
        emp.HireDate = null;
        Console.WriteLine(emp.GetYearsWorked());
        Console.WriteLine(emp);
    }
}