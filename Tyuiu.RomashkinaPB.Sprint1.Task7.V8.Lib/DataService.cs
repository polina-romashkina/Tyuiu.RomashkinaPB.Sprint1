using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.RomashkinaPB.Sprint1.Task7.V8.Lib
{
    public class DataService : ISprint1Task7V8
    {
        public double Calculate(double x, double y)
        {
            var res = x * Math.Log(x) + y / (Math.Cos(x) - x / 3.0);
            return Math.Round(res, 3);
        }
    }
}
