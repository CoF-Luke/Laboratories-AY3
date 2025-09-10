
class Program
{
    static void Main()
    {
        Random rnd = new Random();

        List<Point> li = new();

        for (int i = 0; i < rnd.Next(3, 6); i++)
        {
            Point temp_p = new(rnd.Next(-100, 101), rnd.Next(-100, 101));

            li.Add(temp_p);
        }

        #region filling
        Figure fig;

        Point a = li[0];
        Point b = li[1];
        Point c = li[2];
        
        if (li.Count == 4)
        {
            Point d = li[3];
            fig = new(a, b, c, d);
        }
        else if (li.Count == 5)
        {
            Point d = li[3];
            Point e = li[4];
            fig = new(a, b, c, d, e);
        }
        else
        {
            fig = new(a, b, c);
        }
        #endregion

        string name_of_figure = fig.NameOfFigure;
        double perimeter = fig.PerimeterCalculator();

        Console.WriteLine($"Name of generated figure is {name_of_figure}.");
        Console.WriteLine($"Perimeter of this figure is {perimeter}.");
        Console.WriteLine("Thank you for your attention :)");
    }
}


public class Point
{
    readonly int x, y;

    public int X { get { return x; } }
    public int Y { get { return y; } }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public class Figure
{
    private List<Point> li = new List<Point>();

    public Figure(params Point[] mas)
    {
        foreach (Point i in mas)
        {
            li.Add(i);
        }
        NameOfFigure = "triangle";
    }

    public Figure(Point a, Point b, Point c, Point d) : this(a, b, c)
    {
        li.Add(d);
        NameOfFigure = "quadrilateral";
    }

    public Figure(Point a, Point b, Point c, Point d, Point e) : this(a, b, c, d)
    {
        li.Add(e);
        NameOfFigure = "pentagon";
    }

    public string NameOfFigure { get; set; }

    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public double PerimeterCalculator()
    {
        double result = 0;

        for (int i = 0; i + 1 < li.Count; i++)
        {
            result += LengthSide(li[i], li[i + 1]);
        }
        result += LengthSide(li[0], li[li.Count - 1]);

        return result;
    }
}