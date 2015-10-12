using System;
using System.Collections.Generic;

namespace IntroToCSharp
{
    class asThree_ExerciseTwo
    {
        public asThree_ExerciseTwo()
        {
            //initialize
            m_sdIntegerCount = new SortedDictionary<int, int>();
            m_sdReportStrings = new SortedDictionary<int, string>();
            for (int i = 0; i < 11; i++)
            {
                m_sdIntegerCount[i] = 0;
                if (0 == i)
                    m_sdReportStrings[i] = "Number   \t   Count";
                else
                    m_sdReportStrings[i] = (i.ToString() + "   \t\t   0");

            }
        }
        private SortedDictionary<int, String> m_sdReportStrings;
        public SortedDictionary<int, String> sdReportStrings
        {
            get { return m_sdReportStrings; }
            set { m_sdReportStrings = value; }
        }
        //get the output string at the requested value
        public string getReportString(int index)
        {
            return m_sdReportStrings[index];
        }
        private SortedDictionary<int, int> m_sdIntegerCount;
        private int lastChecked;
        //set the lastChecked value, increment the count at that value
        //update the string for that value
        public int integer
        {
            get { return m_sdIntegerCount[lastChecked]; }
            set
            {
                lastChecked = value;
                m_sdIntegerCount[value]++;
                m_sdReportStrings[value] = value.ToString() + "   \t\t   " + m_sdIntegerCount[value].ToString();
            }
        }

        //check the count at the requested value
        public int checkValue(int input)
        {
            return m_sdIntegerCount[input];
        }

        public SortedDictionary<int, int> sdInteger
        {
            get { return m_sdIntegerCount; }
            set { m_sdIntegerCount = value; }
        }
    }
}
