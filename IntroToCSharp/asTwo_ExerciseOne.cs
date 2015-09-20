using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class asTwo_ExerciseOne
    {
        public asTwo_ExerciseOne()
        {
            m_fSum = 0.0f;
            m_fAverage = 0.0f;
            m_iAverage = 0;
            m_fDifference = 0.0f;
            m_fFirst = 0.0f;
            m_fSecond = 0.0f;
            m_fThird = 0.0f;
        }
        private float m_fSum;
        public float fSum
        {
            get
            {
                m_fSum = m_fFirst + m_fSecond + m_fThird;
                return m_fSum;
            }
        }
        private float m_fAverage;
        public float fAverage
        {
            get
            {
                m_fAverage = (fSum / 3.0f);
                return m_fAverage;
            }
        }
        private int m_iAverage;
        public int iAverage
        {
            get
            {
                m_iAverage = (int)(m_fAverage);
                return m_iAverage;
            }
        }
        private float m_fDifference;
        public float difference
        {
            get
            {
                m_fDifference = (float)(fAverage - iAverage);
                return m_fDifference;
            }
        }
        private float m_fFirst;
        private bool m_bSetFirst;
        public bool setFirst
        {
            get { return m_bSetFirst; }
            set { m_bSetFirst = value; }
        }
        public float first
        {
            get { return m_fFirst; }
            set
            {
                setFirst = true;
                m_fFirst = value;
            }
        }
        private float m_fSecond;
        private bool m_bSetSecond;
        public bool setSecond
        {
            get { return m_bSetSecond; }
            set { m_bSetSecond = value; }
        }
        public float second
        {
            get { return m_fSecond; }
            set
            {
                setSecond = true;
                m_fSecond = value;
            }
        }
        private float m_fThird;
        private bool m_bSetThird;
        public bool setThird
        {
            get { return m_bSetThird; }
            set { m_bSetThird = value; }
        }
        public float third
        {
            get { return m_fThird; }
            set
            {
                setThird = true;
                m_fThird = value;
            }
        }
        private string m_strInput;
        public string input
        {
            get { return m_strInput; }
            set
            {
                m_strInput = value;
                char[] splits = { ' ', ',', '\t', '\n' };

                string[] inputs = m_strInput.Split(splits);
                float temp = 0.0f;
                first = 0.0f;
                second = 0.0f;
                third = 0.0f;
                setFirst = false;
                setSecond = false;
                setThird = false;
                for (int ii = 0; ii < inputs.Length; ii++)
                {
                    if (float.TryParse(inputs[ii], out temp))
                    {
                        if (!setFirst)
                        {
                            first = temp;
                        }
                        else if (!setSecond)
                        {
                            second = temp;
                        }
                        else if (!setThird)
                        {
                            third = temp;
                        }
                        //else they've input too many numbers; ignore the extras
                    }
                }
            }
        }
        public String floatingAverageString()
        {
            String output = "";

            output = "Floating point average: " + first.ToString("N3");
            output += (" + " + second.ToString("N3"));
            output += (" + " + third.ToString("N3") + " = ");
            output += (fSum.ToString("N3") + " and ");
            output += (fSum.ToString("N3") + " / 3 = ");
            output += (fAverage.ToString("N3"));

            return output;
        }

        public String integerAverageString()
        {
            String output = "";

            output = "Integer average: " + first.ToString("N0");
            output += (" + " + second.ToString("N0"));
            output += (" + " + third.ToString("N0") + " = ");
            output += (fSum.ToString("N0") + " and ");
            output += (fSum.ToString("N0") + " / 3 = ");
            output += (iAverage.ToString());

            return output;
        }

        public String floatDifferenceString()
        {
            String output = "";

            output = "Difference: " + fAverage.ToString("N3");
            output += (" - " + iAverage.ToString() + " = ");
            output += difference.ToString("N3");

            return output;
        }
    }
}

