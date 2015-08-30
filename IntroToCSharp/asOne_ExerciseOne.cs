using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Melissa Allee
//Intro to C#
//Assignment One
//Exercie One
namespace IntroToCSharp
{
    class asOne_ExerciseOne
    {
        public asOne_ExerciseOne()
        {
            m_iPyramidSize = 6;
            m_cPyramidSymbol = '*';
            m_strPyramid = "";
        }
        private int m_iPyramidSize; //track size of the pyramid
        //half # of symbols in the top level of the (inverted) pyramid
        public int pyramidSize
        {
            get { return m_iPyramidSize; }
            set { m_iPyramidSize = value; }
        }
        private char m_cPyramidSymbol; //character to use when drawing pyramid
        public char pyramidSymbol
        {
            get { return m_cPyramidSymbol; }
            set { m_cPyramidSymbol = value; }
        }

        private string m_strPyramid; //pyramid string
        public string pyramid
        {
            get { return UpdatePyramid(); }
        }

        private string UpdatePyramid() //logic for creating the pyramid string
        {
            int iRows = m_iPyramidSize / 2; //# rows = to half the pyramid size

            m_strPyramid = "";
            string strLine = "";
            for (int ii = 0; ii < iRows; ii++)//iterate through the rows
            {
                strLine = CreateLine(m_iPyramidSize, (ii * 2)); //create the line
                m_strPyramid += (strLine + "\n"); //the row is completed; next row
                strLine = "";
            }

            return m_strPyramid;
        }
        private string CreateLine(int iCharacterCounts, int iSpaces)
        {
            string strString = "";

            for (int ii = 0; ii < iCharacterCounts; ii++)
            {
                if (iSpaces > ii)
                    strString += " "; //spaces at the beginning of a row
                else
                    strString += m_cPyramidSymbol; //fill the string w/ symbols
            }
            char[] caReverse = strString.ToCharArray(); //flip the string
            Array.Reverse(caReverse);
            string strReverse = new string(caReverse);
            strString += (" " + strReverse); // string + " " + flippedString

            return strString;
        }
    }
}
