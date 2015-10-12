using System;
using System.Collections.Generic;

namespace IntroToCSharp
{
    class AssignmentThree
    {
        public AssignmentThree()
        {
            m_eOne = new asThree_ExerciseOne();
            m_eTwo = new asThree_ExerciseTwo();
        }
        asThree_ExerciseOne m_eOne;
        asThree_ExerciseTwo m_eTwo;

        public void setMinimum(int minimum)
        {
            m_eOne.minimum = minimum;
        }

        public void setMaximum(int maximum)
        {
            m_eOne.maximum = maximum;
        }
        
        public String allResult()
        {
            return m_eOne.allOutput;
        }

        public String evenResult()
        {
            return m_eOne.evenOutput;
        }

        public String oddResult()
        {
            return m_eOne.oddOutput;
        }

        //set the LastValue, increment the count, update the string
        public void setInput(int input)
        {
            m_eTwo.integer = input;
        }

        //get the count at the LastValue
        public int getInput(int input)
        {
            return m_eTwo.integer;
        }

        //check the count in the sorted dictionary
        public int checkValue(int input)
        {
            return m_eTwo.checkValue(input);
        }

        public String getRow(int input)
        {
            String output = "";

            output = m_eTwo.integer.ToString();

            return output;
        }

        //reset the count values
        public void clearInput()
        {
            SortedDictionary<int, int> sd;
            sd = new SortedDictionary<int, int>();

            SortedDictionary<int, String> sdStrings;
            sdStrings = new SortedDictionary<int, string>();

            for (int i = 0; i < 11; i++)
            {
                sd[i] = 0;
                sdStrings[i] = i.ToString() + "   \t   0";
            }

            m_eTwo.sdInteger = sd;
            m_eTwo.sdReportStrings = sdStrings;
        }

        //return the string value to be displayed to the user
        public String getReportString(int index)
        {
            return m_eTwo.getReportString(index);
        }
    }
}
