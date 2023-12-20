using System.Drawing;
string a;
double b,c;
Student person = new  Student();
person.Name = a=Console.ReadLine();
person.GradeLevel = b=Convert.ToInt32(Console.ReadLine());
person.TestScores = c=Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(person.GetAverage());

class Student
{
    public string Name;
    public double GradeLevel;
    public double TestScores;

    public string GetAverage()
    {
        if(TestScores < 85) 
        {
            return $"{Name},if you're having difficulties with your studies, don't hesitate to \nseek help. Your current average score is {TestScores}.0 in grade {GradeLevel}";
        }
        else 
        {
            return $"Congratulations {Name} on achieving above average scores {TestScores} in grade {GradeLevel}!\nKeep up the good work!";
        }
    }
}