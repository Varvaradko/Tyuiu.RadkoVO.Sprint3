using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RadkoVO.Sprint3.Task2.V8.Lib
{
    public class DataService : ISprint3Task2V8
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double SumSeries = 1;
            do
            {
                SumSeries = SumSeries * (1 / Math.Pow((Math.Cos(5) + 1), 2));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(SumSeries, 3);
        }
    }
}
