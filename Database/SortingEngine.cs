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

        public void Sort(List<Core> CoreList, IComparer<Core> CompareType)
        {
            Sort(CoreList, CompareType, 0);
        }
        private void Sort(List<Core> CoreList, IComparer<Core> CompareType, int startingIndex)
        {
            int comparedVal;
            int length = coreList.Count;
            for (int j = startingIndex + 1; j < length; j++)
            {
                comparedVal = compareType.Compare(coreList[startingIndex], coreList[j]);

                if (comparedVal < 0)
                {
                    swapMethod(startingIndex, j);
                }
            }
                startingIndex++;
                if (startingIndex < length)
                {
                    Sort(CoreList, CompareType,startingIndex);
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
