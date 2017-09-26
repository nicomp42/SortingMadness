using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMadness
{
    class SortingMadness
    {
        static void Main(string[] args)
        {
            SortingMadness sm = new SortingMadness();
            sm.BubbleSort(sm.ReadTestData("testData.txt"));
        }
        public void BubbleSort(List<String> data)
        {

        }
        public List<String> ReadTestData(String fileName)
        {
            List<String> testData = new List<String>();

            return testData;
        }
    }
}
