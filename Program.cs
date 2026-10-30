try
{
    double start = -Math.PI / 2;
    double end = Math.PI;
    double shag = 0.2;

    for (double x = start; x <= end; x += shag)
    {
        double y = 0;

        if (x > 2)
        {
            y = Math.Sqrt(Math.Log(x * x - 1));
        }
        else if (x >= 0 && x <= 2)
        {
            y = -2 * Math.Pow(x, 3);
        }
        else
        {
            y = Math.Exp(Math.Sin(x));
        }

        Console.WriteLine($"{x,10:F4} | {y,10:F4}");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
Console.ReadKey();