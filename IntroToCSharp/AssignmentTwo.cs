using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Melissa Allee
//Logic for the exercises in the second assignment
namespace IntroToCSharp
{
    class AssignmentTwo
    {
        public AssignmentTwo()
        {
            m_eOne = new asTwo_ExerciseOne();
            m_eTwo = new asTwo_ExerciseTwo();
        }
        private asTwo_ExerciseOne m_eOne;
        public asTwo_ExerciseOne one
        {
            get { return m_eOne; }
        }
        private asTwo_ExerciseTwo m_eTwo;
        public asTwo_ExerciseTwo two
        {
            get { return m_eTwo; }
        }
    }
}