using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class asThree_ExerciseOne
    {
        public asThree_ExerciseOne()
        {
            minimum = 0;
            maximum = 0;
        }
        private int m_iMinimum;
        public int minimum
        {
            get { return m_iMinimum; }
            set
            {
                m_iMinimum = value;
                if (m_iMaximum > 0)
                    createOutput();
            }
        }
        private int m_iMaximum;
        public int maximum
        {
            get { return m_iMaximum; }
            set
            {
                m_iMaximum = value;
                if (m_iMaximum > 0)
                    createOutput();
            }
        }
        private String m_strAllOutput;
        public String allOutput
        {
            get { return m_strAllOutput; }
        }
        private String m_strEvenOutput;
        public String evenOutput
        {
            get { return m_strEvenOutput; }
        }
        private String m_strOddOutput;
        public String oddOutput
        {
            get { return m_strOddOutput; }
        }
        private void createOutput()
        {
            int iAllResult = 0;
            int iEvenResult = 0;
            int iOddResult = 0;

            String[] strAllResult = new string[m_iMaximum+1];
            String[] strEvenResult = new string[m_iMaximum+1];
            String[] strOddResult = new string[m_iMaximum+1];

            int count = 0;
            int iEvenCount = 0;
            int iOddCount = 0;

            for (int i = m_iMinimum; i <= m_iMaximum; i++)
            {
                iAllResult += i;
                strAllResult[count] = i.ToString();
                if (0 == (i%2))
                {
                    iEvenResult += i;
                    strEvenResult[iEvenCount] = i.ToString();

                    iEvenCount++;
                }
                else
                {
                    iOddResult += i;
                    strOddResult[iOddCount] = i.ToString();

                    iOddCount++;
                }

                count++;
            }

            m_strAllOutput = "";
            foreach (var j in strAllResult)
            {
                if ((j != strAllResult[count-1]) && (j != null))
                    m_strAllOutput += (j + " + ");
                else if (j != null)
                    m_strAllOutput += (j + " = " + iAllResult.ToString());
                else
                    break;
            }

            m_strEvenOutput = "";
            foreach (var j in strEvenResult)
            {
                if ((j != strEvenResult[iEvenCount-1]) && (j != null))
                    m_strEvenOutput += (j + " + ");
                else if (j != null)
                    m_strEvenOutput += (j + " = " + iEvenResult.ToString());
                else
                    break;
            }

            m_strOddOutput = "";
            foreach (var j in strOddResult)
            {
                if ((j != strOddResult[iOddCount-1]) && (j != null))
                    m_strOddOutput += (j + " + ");
                else if (j != null)
                    m_strOddOutput += (j + " = " + iOddResult.ToString());
                else
                    break;
            }
        }
    }
}
