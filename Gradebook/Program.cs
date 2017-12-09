using System;

namespace Gradebook
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Gradebook gb1 = new Gradebook();
            gb1.AddToGrades(91);
            gb1.AddToGrades(28.2f);

            Gradebook gb2 = gb1;
            gb2.AddToGrades(29);
            gb1.AddToGrades(23);

        }
    }
}
