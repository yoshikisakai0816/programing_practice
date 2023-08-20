using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    internal class Linq1
    {
        public List<int> QueryWhere1(List<int> numbers)
        {
            var eventNumbers = (List<int>)numbers.Where(n => n % 2 == 0);
            return eventNumbers;
        }

        public List<int> QueryMapping1(List<int> numbers)
        {
            List<int> squaredNumbers = (List<int>)numbers.Select(n => n * n);
            return squaredNumbers;
        }

        public List<int> QueryTake1(List<int> numbers)
        {
            List<int> firstNumbers = (List<int>)numbers.Take(5);
            return firstNumbers;
        }

        public List<int> QueryOrderby1(List<int> numbers)
        {
            List<int> firstNumbers = (List<int>)numbers.OrderByDescending(b => b)
                .Select(b => b);
            return firstNumbers;
        }

        public bool QueryAny1(List<int> numbers)
        {
            return numbers.Any(n => n > 3);
        }

        public void Write(List<int> numbers)
        {
            foreach(int n in numbers)
            {
                Console.Write(n + " ");
            }
        }



    }
}
