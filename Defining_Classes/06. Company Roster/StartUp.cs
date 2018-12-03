using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Company_Roster
{
	class StartUp
	{
		static void Main(string[] args)
		{
			Stack<Employee> employees = GetEmployees();
			PrintEmployeesWithHighestSalary(employees);
		}

		private static void PrintEmployeesWithHighestSalary(Stack<Employee> employees)
		{
			if (employees.Count == 0)
			{
				return;
			}

			IGrouping<string,Employee> highestAverageSalaryDepartment = employees
				.GroupBy(e => e.Department)
				.OrderByDescending(g => g.Select(e => e.Salary).Sum())
				.First();

			Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment.Key}");
			Console.WriteLine(string.Join(Environment.NewLine, highestAverageSalaryDepartment
				.OrderByDescending(e => e.Salary)
				.Select(e => $"{e.Name} {e.Salary:F2} {e.Email} {e.Age}")));
		}

		private static Stack<Employee> GetEmployees()
		{
			Stack<Employee> employees = new Stack<Employee>();
			int numberOfEmployees = int.Parse(Console.ReadLine());

			while (employees.Count < numberOfEmployees)
			{
				var email = "n/a";
				var age = -1;
				var personData = Console.ReadLine().Split();

				if (personData.Length > 4)
				{
					int parsed;
					var isdigit = int.TryParse(personData[4], out parsed);

					if (isdigit)
					{
						age = parsed;
					}
					else
					{
						email = personData[4];
					}

					if (personData.Length > 5)
					{
						if (isdigit)
						{
							email = personData[5];
						}
						else
						{
							age = int.Parse(personData[5]);
						}
					}
				}

				employees.Push(new Employee(
						personData[0],
						decimal.Parse(personData[1]),
						personData[2],
						personData[3],
						email,
						age
					));
			}

			return employees;
		}
	}
}
