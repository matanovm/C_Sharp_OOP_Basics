using _03.Man_Kind;
using System;


namespace _03.Mankind
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] studentData = Console.ReadLine().Split(' ');
			string studentFirstName = studentData[0];
			string studentLastName = studentData[1];
			string studentFacultyNumber = studentData[2];

			string[] workerData = Console.ReadLine().Split(' ');
			string workerFirstName = workerData[0];
			string workerLastName = workerData[1];
			decimal workerWeekSalary = decimal.Parse(workerData[2]);
			decimal workerWorkHoursPerDay = decimal.Parse(workerData[3]);

			try
			{
				Student student = new Student(studentFirstName, studentLastName, studentFacultyNumber);
				Worker worker = new Worker(workerFirstName, workerLastName, workerWeekSalary, workerWorkHoursPerDay);
				Console.WriteLine(student);
				Console.WriteLine();
				Console.WriteLine(worker);
			}
			catch (Exception exception)
			{
				Console.WriteLine(exception.Message);
			}
		}
	}
}

