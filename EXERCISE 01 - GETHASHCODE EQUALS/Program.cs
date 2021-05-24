using System;

namespace EXERCISE_01___GETHASHCODE_EQUALS {
    //-----> START
    ///////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {

            string a = "Maria";
            string b = "Alex";
            string c = "Alex";

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> END
}
