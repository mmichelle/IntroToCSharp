using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Melissa Allee
//Intro to C#
//Assignment One
//Exercie Two
namespace IntroToCSharp
{
    class asOne_ExerciseTwo
    {
        public asOne_ExerciseTwo()
        {
            m_iDogYears = 0;
        }
        private int m_iDogYears;
        public int dogYears
        {
            get { return m_iDogYears; }
            //when the user enters their age, update the "dog years"
            set { m_iDogYears = (value * 4); }
        }
    }
}
