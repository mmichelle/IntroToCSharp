using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class asThree_ExerciseTwo
    {
        public asThree_ExerciseTwo()
        {
            m_sdIntegerCount = new SortedDictionary<int, int>();
            for (int i = 0; i < 11; i++)
            {
                m_sdIntegerCount[i] = 0;
            }
        }

        private SortedDictionary<int, int> m_sdIntegerCount;
        private int lastChecked;
        public int integer
        {
            get { return m_sdIntegerCount[lastChecked]; }
            set
            {
                lastChecked = value;
                m_sdIntegerCount[value]++;
            }
        }

        public SortedDictionary<int, int> sdInteger
        {
            get { return m_sdIntegerCount; }
            set { m_sdIntegerCount = value; }
        }
    }
}
