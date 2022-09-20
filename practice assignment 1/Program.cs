string grade;
do
{
    Console.WriteLine("What is your grade, type 'STOP' when done : ");
    grade = Console.ReadLine();
    int numberGrade = int.Parse(grade);
    Console.WriteLine(numberGrade);
    if (numberGrade >= 90)
        Console.WriteLine("Your grade is an 'A");
    else if (numberGrade >= 80)
        Console.WriteLine("Your grade is a 'B'");
    else if (numberGrade >= 70)
        Console.WriteLine("Your grade is a 'C'");
    else if (numberGrade >= 60)
        Console.WriteLine("Your grade is a 'D'");
    else
        Console.WriteLine("Your grade is an 'F'");
    } while (grade != "STOP");