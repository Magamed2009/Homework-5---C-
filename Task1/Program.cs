string a,b,c;
int d;
Person person =new Person()
{
    FirstName = a=Console.ReadLine(),
    LastName = b=Console.ReadLine(),
    Age = d=Convert.ToInt32(Console.ReadLine()),
    Address = c=Console.ReadLine(),
    
};

System.Console.WriteLine(person.GetFullName());

class  Person
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string  Address;

    public string GetFullName()
    {
        return $"My name is {FirstName} {LastName} \nMy birth year is {2023-Age}";
    } 
}