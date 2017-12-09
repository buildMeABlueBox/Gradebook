using System;
using System.Collections.Generic;

namespace Gradebook
{
    public class Gradebook
    {
        List<float> grades;
        Statistics s;
        public Gradebook()
        {
            grades = new List<float>();
        }

        public AddToGrades(float x){
            grades.Add(x);
        }
    }
}
    