using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void setInput(int input)
        {
            m_eTwo.integer = input;
        }

        public int getInput(int input)
        {
            return m_eTwo.integer;
        }

        public String getRow(int input)
        {
            String output = "";

            output = m_eTwo.integer.ToString();

            return output;
        }
        public void clearInput()
        {
            SortedDictionary<int, int> sd;
            sd = new SortedDictionary<int, int>();
            for (int i = 0; i < 11; i++)
            {
                sd[i] = 0;
            }

            m_eTwo.sdInteger = sd;
        }
    }
}
