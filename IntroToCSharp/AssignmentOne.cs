using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Melissa Allee
//Logic for the exercises in the first assignment
namespace IntroToCSharp
{
    class AssignmentOne
    {
        public AssignmentOne()
        {
            // initialize the member variables

            m_eOne = new asOne_ExerciseOne();
            m_eTwo = new asOne_ExerciseTwo();
            m_eThree = new asOne_ExerciseThree();
        }
        private asOne_ExerciseOne m_eOne;
        public asOne_ExerciseOne one
        {
            get { return m_eOne; }
        }
        private asOne_ExerciseTwo m_eTwo;
        public asOne_ExerciseTwo two
        {
            get { return m_eTwo; }
        }
        private asOne_ExerciseThree m_eThree;
        public asOne_ExerciseThree three
        {
            get { return m_eThree; }
        }
    }
}
