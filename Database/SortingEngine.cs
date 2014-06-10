using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class SortingEngine
    {
        List<Core> coreList;
        IComparer<Core> compareType;

        public SortingEngine(List<Core> CoreList, IComparer<Core> CompareType)
        {
            coreList = CoreList;
            compareType = CompareType;
            sortTool(0);
        }
        public void sortTool(int interval)
        {
            int comparedVal;
            int length = coreList.Count;
            for (int j = interval + 1; j < length; j++)
            {
                comparedVal = compareType.Compare(coreList[interval], coreList[j]);

                if (comparedVal < 0)
                {
                    swapMethod(interval, j);
                }
            }
                interval++;
                if (interval < length)
                {
                    sortTool(interval);
                }
        }
        public void swapMethod(int x, int y)
        {
            Core holder = coreList[x];
            coreList[x] = coreList[y];
            coreList[y] = holder;
        }
        public List<Core> setCore()
        {
            return coreList;
        }
    }
}
