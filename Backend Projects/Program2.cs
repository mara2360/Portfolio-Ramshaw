using System;
					
public class Program2
{
	public static void Main()
	{
		Console.WriteLine("Enter student's first and last name.\n");
		string userInput = Console.ReadLine();			
		Console.WriteLine($"{userInput}'s Transcript\n");
  
		Console.WriteLine("Enter First Hour Class\n");
		string class1 = Console.ReadLine();
		Console.WriteLine("Enter First Hour Number Grade\n");
		string class1Grade = Console.ReadLine();
		Console.WriteLine("Enter First Hour Credits\n");
		string class1Credit = Console.ReadLine();
		
		Console.WriteLine("Enter Second Hour Class\n");
		string class2 = Console.ReadLine();
		Console.WriteLine("Enter Second Hour Number Grade\n");
		string class2Grade = Console.ReadLine();
		Console.WriteLine("Enter Second Hour Credits\n");
		string class2Credit = Console.ReadLine();
		
		Console.WriteLine("Enter Third Hour Class\n");
		string class3 = Console.ReadLine();
		Console.WriteLine("Enter Third Hour Number Grade\n");
		string class3Grade = Console.ReadLine();
		Console.WriteLine("Enter Third Hour Credits\n");
		string class3Credit = Console.ReadLine();
		
		Console.WriteLine("Enter Fourth Hour Class\n");
		string class4 = Console.ReadLine();
		Console.WriteLine("Enter Fourth Hour Number Grade\n");
		string class4Grade = Console.ReadLine();
		Console.WriteLine("Enter Fourth Hour Credits\n");
		string class4Credit = Console.ReadLine();
		
		Console.WriteLine("Enter Fifth Hour Class\n");
		string class5 = Console.ReadLine();
		Console.WriteLine("Enter Fifth Hour Number Grade\n");
		string class5Grade = Console.ReadLine();
		Console.WriteLine("Enter Fifth Hour Credits\n");
		string class5Credit = Console.ReadLine();
		
		int credit1 = int.Parse(class1Credit);
		int credit2 = int.Parse(class2Credit);
		int credit3 = int.Parse(class3Credit);
		int credit4 = int.Parse(class4Credit);
		int credit5 = int.Parse(class5Credit);
			
		double grade1 = Convert.ToDouble(class1Grade);
		double grade2 = Convert.ToDouble(class2Grade);
		double grade3 = Convert.ToDouble(class3Grade);
		double grade4 = Convert.ToDouble(class4Grade);
		double grade5 = Convert.ToDouble(class5Grade);
		
		double grade = (grade1 *  credit1) + (grade2 * credit2) + (grade3 * credit3) + (grade4 * credit4) + (grade5 * credit5);		
		int totalCredit = credit1 + credit2 + credit3 + credit4 + credit5;		
		double totalGPA = grade / totalCredit;
		
		int leadingDigit = (int) totalGPA;
		
		int firstDigit = (int) (totalGPA / 10) % 10;
		int secondDigit = (int) (totalGPA /100) % 10;
		
    		Console.WriteLine("First Hour:");		
    		Console.WriteLine($"Class: {class1}\t\t\tGrade: {grade1}\t\t\tCredit Hours: {credit1}\n");
		Console.WriteLine("Second Hour:");	
		Console.WriteLine($"Class: {class2}\t\t\tGrade: {grade2}\t\t\tCredit Hours: {credit2}\n");
		Console.WriteLine("Third Hour:");	
		Console.WriteLine($"Class: {class3}\t\t\tGrade: {grade3}\t\t\tCredit Hours: {credit3}\n");
		Console.WriteLine("Fourth Hour:");	
		Console.WriteLine($"Class: {class4}\t\t\tGrade: {grade4}\t\t\tCredit Hours: {credit4}\n");
		Console.WriteLine("Fifth Hour:");	
		Console.WriteLine($"Class: {class5}\t\t\tGrade: {grade5}\t\t\tCredit Hours: {credit5}\n");
		
		Console.WriteLine($"Total Credit Hours: {totalCredit}");
		Console.WriteLine($"GPA: {leadingDigit}.{firstDigit}{secondDigit}\n");
	}
}
