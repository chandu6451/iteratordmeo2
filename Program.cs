using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDemo2
{
    public class DayofTheWeek
    {
        string[] m_day = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

        public IEnumerable<string> GetDays()
        {
            for (int i = 0; i < m_day.Length; i++)
            {
                yield return m_day[i];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DayofTheWeek week = new DayofTheWeek();

            foreach (var item in week.GetDays())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
