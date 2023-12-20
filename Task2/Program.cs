using System.Drawing;
int a,b;
Rectangle Arr = new Rectangle();
System.Console.Write("width = ");
Arr.Width = a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("height = ");
Arr.Height = b=Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Arr.GetArea());

class Rectangle
{
    public int Width;
    public int Height;

    public string GetArea()
    {
        return $"Area = {Width * Height}";
    }
}