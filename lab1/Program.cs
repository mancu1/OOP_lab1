/*
 Вывести на консоль значения функции в диапазоне углов от 0 до 180 
градусов с шагом в 10 градусов. Для расчета использовать статические 
функции библиотечного класса Math. Вывод организовать в виде таблицы, 
состоящей из столбцов, выровненных по правому краю:
Первый столбец – значение аргумента функции в градусах, ширина поля 
вывода 4 символа.
Второй столбец – значение аргумента в радианах в формате с 
фиксированной точкой с точностью два знака после запятой с округлением, 
ширина поля вывода пять знаков.
Третий столбец – значение функции в формате с фиксированной точкой с 
точностью до четырех знаков после запятой, ширина поля вывода двенадцать 
знаков.
9. F(x)= tgh(x)
 */


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