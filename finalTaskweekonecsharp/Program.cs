// See https://aka.ms/new-console-template for more information

//Exercise 1: Calculate the sum of two integers and return triple the sum if the numbers are equal.
using System;
using System.Drawing;

class Program
{
	static int CalculateSumOrTriple(int num1, int num2)
	{
		int sum = num1 + num2;

		
		if (num1 == num2)
		{
			return sum * 3;
		}
		else
		{
			return sum; 
		}
	}

	
	static void Main()
	{
		
		Console.WriteLine("Enter the first number: ");
		int number1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the second number: ");
		int number2 = Convert.ToInt32(Console.ReadLine());

		
		int result = CalculateSumOrTriple(number1, number2);

		
		Console.WriteLine("The result is: " + result);

		//////////////////////////////////////////////////////////////////////////////////////////////////


		//Exercise 2: Check if a student is eligible for voting based on age.

		
		
		static void CheckVotingEligibility(int age)
		{
			
			if (age >= 18)
			{
				Console.WriteLine("The student is eligible to vote.");
			}
			else
			{
				Console.WriteLine("The student is not eligible to vote.");
			}
		}

		
		static void Main()
		{
			
			Console.WriteLine("Enter the student's age: ");
			int age = Convert.ToInt32(Console.ReadLine());

			
			CheckVotingEligibility(age);
		}






		/////////////////////////////////////////////////////////////////////////////////


		//Exercise 3: Determine the quadrant of a coordinate point.


		static void DetermineQuadrant(int x, int y)
		{
			if (x > 0 && y > 0)
			{
				Console.WriteLine("The point is in Quadrant 1.");
			}
			else if (x < 0 && y > 0)
			{
				Console.WriteLine("The point is in Quadrant 2.");
			}
			else if (x < 0 && y < 0)
			{
				Console.WriteLine("The point is in Quadrant 3.");
			}
			else if (x > 0 && y < 0)
			{
				Console.WriteLine("The point is in Quadrant 4.");
			}
			else if (x == 0 && y == 0)
			{
				Console.WriteLine("The point is at the origin.");
			}
			else if (x == 0)
			{
				Console.WriteLine("The point is on the y-axis.");
			}
			else if (y == 0)
			{
				Console.WriteLine("The point is on the x-axis.");
			}
		}

		static void Main()
		{
			
			Console.WriteLine("Enter the x coordinate: ");
			int x = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter the y coordinate: ");
			int y = Convert.ToInt32(Console.ReadLine());

			DetermineQuadrant(x, y);
		}
	}


	////////////////////////////////////////////////////////////////

	//Exercise 4: Determine the type of triangle.

	static void DetermineTriangleType(int side1, int side2, int side3)
	{
		if (side1 == side2 && side2 == side3)
		{
			Console.WriteLine("The triangle is equilateral.");
		}
		else if (side1 == side2 || side2 == side3 || side1 == side3)
		{
			Console.WriteLine("The triangle is isosceles.");
		}
		else if ((side1 * side1 + side2 * side2 == side3 * side3) ||
				 (side1 * side1 + side3 * side3 == side2 * side2) ||
				 (side2 * side2 + side3 * side3 == side1 * side1))
		{
			Console.WriteLine("The triangle is right-angled.");
		}
		else
		{
			Console.WriteLine("The triangle is scalene.");
		}
	}

	static void Main()
	{
		Console.WriteLine("Enter the first side: ");
		int side1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the second side: ");
		int side2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Enter the third side: ");
		int side3 = Convert.ToInt32(Console.ReadLine());

		DetermineTriangleType(side1, side2, side3);
	}
}






//////////////////////////////////////////////////////
//Exercise 5: Calculate an electricity bill.

static double CalculateElectricityBill(int units)
{
	double bill = 0;

	if (units < 300)
	{
		bill = units * 1.5;
	}
	else if (units < 450)
	{
		bill = units * 2;
	}
	else
	{
		bill = units * 2.5;
	}

	if (units > 600)
	{
		bill += bill * 0.1;
	}

	return bill;
}

static void Main()
{
	Console.WriteLine("Enter the number of units consumed: ");
	int units = Convert.ToInt32(Console.ReadLine());

	double totalBill = CalculateElectricityBill(units);

	Console.WriteLine("The total electricity bill is: " + totalBill);
}









///////////////////////////////////////////////////////////////////////////////
///////exercise 2/////////
/// Bank System for ATM (Deposit, Withdraw, Check Balance)
/// 





class ATM
{
	static void Main()
	{
		double balance = 0; 
		bool exit = false;

		while (!exit)
		{
			
			Console.WriteLine("\nATM Menu:");
			Console.WriteLine("1. Deposit Money");
			Console.WriteLine("2. Withdraw Money");
			Console.WriteLine("3. Check Balance");
			Console.WriteLine("4. Exit");
			Console.Write("Choose an option (1-4): ");

			string choice = Console.ReadLine();

			switch (choice)
			{
				case "1": 
					Deposit(ref balance);
					break;

				case "2": 
					Withdraw(ref balance);
					break;

				case "3": 
					Console.WriteLine($"Your current balance is: {balance:C}");
					break;

				case "4": 
					exit = true;
					Console.WriteLine("Exiting the ATM. Have a nice day!");
					break;

				default:
					Console.WriteLine("Invalid choice. Please select a valid option.");
					break;
			}
		}
	}

	static void Deposit(ref double balance)
	{
		Console.Write("Enter the amount to deposit: ");
		double amount;

		if (double.TryParse(Console.ReadLine(), out amount) && amount > 0)
		{
			balance += amount;
			Console.WriteLine($"Successfully deposited {amount:C}. New balance: {balance:C}");
		}
		else
		{
			Console.WriteLine("Invalid amount. Please enter a value greater than zero.");
		}
	}

	static void Withdraw(ref double balance)
	{
		Console.Write("Enter the amount to withdraw: ");
		double amount;

		if (double.TryParse(Console.ReadLine(), out amount) && amount > 0)
		{
			if (amount <= balance)
			{
				balance -= amount;
				Console.WriteLine($"Successfully withdrew {amount:C}. New balance: {balance:C}");
			}
			else
			{
				Console.WriteLine("Insufficient balance for this withdrawal.");
			}
		}
		else
		{
			Console.WriteLine("Invalid amount. Please enter a value greater than zero.");
		}





		//////////////////////////////////////////////////////////////////////////////
		///exercise 3 /////////////////
		/// Student Grades Analysis//////
		/// 

		class StudentGrades
	{
		static void Main()
		{
			
			Console.Write("Enter the number of students: ");
			int numStudents;

			
			while (!int.TryParse(Console.ReadLine(), out numStudents) || numStudents <= 0)
			{
				Console.Write("Invalid input. Please enter a valid number of students: ");
			}

			double[] grades = new double[numStudents];
			double total = 0;

			for (int i = 0; i < numStudents; i++)
			{
				Console.Write($"Enter grade for student {i + 1}: ");
				while (!double.TryParse(Console.ReadLine(), out grades[i]) || grades[i] < 0 || grades[i] > 100)
				{
					Console.Write("Invalid grade. Please enter a value between 0 and 100: ");
				}
				total += grades[i]; 
			}

			double minGrade = grades[0];
			double maxGrade = grades[0];
			for (int i = 1; i < numStudents; i++)
			{
				if (grades[i] < minGrade)
					minGrade = grades[i];
				if (grades[i] > maxGrade)
					maxGrade = grades[i];
			}
			double average = total / numStudents;

			int aboveAverage = 0;
			int belowAverage = 0;
			foreach (double grade in grades)
			{
				if (grade > average)
					aboveAverage++;
				else if (grade < average)
					belowAverage++;
			}

			Console.WriteLine($"\nMinimum grade: {minGrade}");
			Console.WriteLine($"Maximum grade: {maxGrade}");
			Console.WriteLine($"Average grade: {average:F2}");
			Console.WriteLine($"Number of students above average: {aboveAverage}");
			Console.WriteLine($"Number of students below average: {belowAverage}");
		}
	}
}











