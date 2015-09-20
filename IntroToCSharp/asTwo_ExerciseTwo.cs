using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class Titles //keep track of possible titles
    {
        public enum eTitles //this enum should stay in sync w/ titles string array
        {
            MISTER,
            MISSUS,
            MISS,
            DR,
            TOTAL_TITLES
        };
        //keep array below in sync with enum
        public static String[] m_aStrTitles = 
        {
            "Mr.",
            "Mrs.",
            "Miss",
            "Dr."
        };

        public String[] outputList() //retrieve the array
        {
            return m_aStrTitles;
        }
    }
    class asTwo_ExerciseTwo
    {
        public asTwo_ExerciseTwo()
        {
            m_strInput = "";
            m_strFirstName = "";
            m_strLastName = "";
            m_strTitle = "";
        }
        private String m_strInput;
        public String input
        {
            get { return m_strInput; }
            set
            {
                m_strInput = value; //parse the first and last name from the string
                char[] splits = { ' ', ',', '\t', '\n' };

                string[] inputs = m_strInput.Split(splits);
                double temp = 0.0;
                m_strFirstName = "";
                m_strLastName = "";
                for (int ii = 0; ii < inputs.Length; ii++)
                {
                    if (!double.TryParse(inputs[ii], out temp))
                    {
                        bool bContainsNumber = false;
                        //even if it fails to parse a number
                        //need to ensure the strings are not a mix
                        //of numbers and letters
                        for (int jj = 0; jj < 10; jj++)
                        {
                            bContainsNumber = inputs[ii].Contains(jj.ToString());
                            if (bContainsNumber)
                                break;
                        }
                        if (!bContainsNumber) //if no numbers were found, fill out the names
                        {
                            if ("" == m_strFirstName) //set the first if not set
                            {
                                m_strFirstName = inputs[ii];
                            }
                            else if ("" == m_strLastName) //set the last if not set
                            {
                                m_strLastName = inputs[ii];
                            }
                        }
                    }
                }
            }
        }
        private String m_strFirstName;
        public String firstName
        {
            get { return m_strFirstName; }
        }
        private String m_strLastName;
        public String lastName
        {
            get { return m_strLastName; }
        }
        private String m_strTitle;
        public String title
        {
            get { return m_strTitle; }
            set { m_strTitle = value; }
        }
        public String outputText() //output the string to be displayed
        {
            String output = "";
            if (0 >= m_strFirstName.Length)
                return "";
            char firstLetter = m_strFirstName[0];

            //ensure first letter of first name and last name are uppercase, but rest
            //of letters are lower case
            output = firstLetter.ToString().ToUpper() + m_strFirstName.Substring(1).ToLower();
            m_strFirstName = output;
            firstLetter = m_strLastName[0];
            output = firstLetter.ToString().ToUpper() + m_strLastName.Substring(1).ToLower();
            m_strLastName = output;

            if ("" != title)
            {
                output = "Hello, " + title + " " + m_strLastName + ".";
                output += ("\nMay I call you " + m_strFirstName + "?");
            }
            else
            {
                output = "Hello, mister (or misses) " + m_strLastName + ".";
                output += ("\nMay I call you " + m_strFirstName + "?");
            }
            return output;
        }
    }
}
