using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Melissa Allee
//Intro to C#
//Assignment One
//Exercie Three
namespace IntroToCSharp
{
    class asOne_ExerciseThree
    {
        public asOne_ExerciseThree()
        {
            num1 = 0;
            num2 = 0;
            num3 = 0;
            m_fProduct = 0;
            m_fSum = 0;
        }
        private float m_fSum;
        public float sum
        {
            get { return m_fSum; }
        }
        private float m_fProduct;
        public float product
        {
            get { return m_fProduct; }
        }
        private float num1;
        public float numberOne
        {
            get { return num1; }
            set
            {
                //update all values when a number is set
                num1 = value;
                m_fSum = num1 + num2 + num3;
                m_fProduct = (num1 * num2 * num3);
            }
        }
        private float num2;
        public float numberTwo
        {
            get { return num2; }
            set
            {
                //update all values when a number is set
                num2 = value;
                m_fSum = num1 + num2 + num3;
                m_fProduct = (num1 * num2 * num3);
            }
        }
        private float num3;
        public float numberThree
        {
            get { return num3; }
            set
            {
                //update all values when a number is set
                num3 = value;
                m_fSum = num1 + num2 + num3;
                m_fProduct = (num1 * num2 * num3);
            }
        }
    }
}
