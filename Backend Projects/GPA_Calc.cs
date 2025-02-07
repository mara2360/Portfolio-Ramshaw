using System;
					
public class GPA_Clac
{
	public static void Main()
	{
		double englishGrade = 3.7;
    		double bandGrade = 4.3;
    		double calGrade = 3.3;
    		double historyGrade = 2.3;
    		double bioGrade = 3.7;

    		int englishCredit = 4;
    		int bandCredit = 3;
    		int calCredit = 4;
    		int historyCredit = 3;
    		int bioCredit = 3;
		
		int totalCredit = englishCredit + bandCredit + calCredit + historyCredit + bioCredit;
		
		double grade = (englishGrade * englishCredit) + (bandGrade * bandCredit) + (calGrade * calCredit) + (historyGrade * historyCredit) + (bioGrade * bioCredit);
		double totalGPA = grade / totalCredit;
		
		int leadingDigit = (int) totalGPA;		
		int firstDigit = (int) (totalGPA / 10) % 10;
		int secondDigit = (int) (totalGPA /100) % 10;
		
    		string userInput = Console.ReadLine();
			
		Console.WriteLine($"{userInput}'s Transcript\n");
 
    		Console.WriteLine("Class\t\t\t\tGrade\t\t Credit Hour\n");
    		Console.WriteLine($"English 101\t\t\t{englishGrade}\t\t\t{englishCredit}");
		Console.WriteLine($"Band 105   \t\t\t{bandGrade}\t\t\t{bandCredit}");
		Console.WriteLine($"Calculus 200   \t\t{calGrade}\t\t\t{calCredit}");
		Console.WriteLine($"US History 203 \t\t{historyGrade}\t\t\t{historyCredit}");
		Console.WriteLine($"Biology 195\t\t\t{bioGrade}\t\t\t{bioCredit}\n");
		
		Console.WriteLine($"Total Credit Hours: {totalCredit}\n");
		Console.WriteLine($"GPA: {leadingDigit}.{firstDigit}{secondDigit}\n");
	}
}
