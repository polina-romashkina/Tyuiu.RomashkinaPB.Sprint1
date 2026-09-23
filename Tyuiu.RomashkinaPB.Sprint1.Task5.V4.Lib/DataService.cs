using tyuiu.cources.programming.interfaces.Sprint1;

using Tyuiu.RomashkinaPB.Sprint1.Task5.V4.Lib;

namespace Tyuiu.RomashkinaPB.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int time)
        {
            int hours = time / 3600;

            return hours;
        }
    }
}
