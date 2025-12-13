using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RadkoVO.Sprint3.Task4.V15.Lib
{
    public class DataService : ISprint3Task4V15
    {
        public double Calculate(int startValue, int stopValue)
        {
            double mult = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else
                {
                    mult = (((Math.Sin(i) + i) / i) + 0.75) * mult;
                }

            }
            return Math.Round(mult, 3);
        }
    }
}
