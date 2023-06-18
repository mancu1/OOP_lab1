namespace lab1;

internal static class Program
{
    public static double DegToRad(double deg)
    {
        return deg * Math.PI / 180;
    }
    public static void Main(string[] args)
    {
        for (double startDeg = 0; startDeg <= 180; startDeg += 10)
        {
            double rad = DegToRad(startDeg);
            double functionResult = Math.Tanh(rad);
            
            //display to console table with angle in degrees and radians and function result
            // first column 4 symbols and 2 after point
            // second column 5 symbols and 2 after point
            // third column 12 symbols and 5 after point
            // align right
            // use string interpolation
            
            Console.WriteLine($"{startDeg,4:0} {rad,5:0.00} {functionResult,12:0.00000}");
        }
    }
}