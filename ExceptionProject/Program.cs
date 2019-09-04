using System;
using My = ExceptionLibrary;

namespace ExceptionProject {

    class Program {

        void Run() {
            var ans = My.Math.Add(1, 2);
            ans = My.Math.Sub(ans, 1);
            ans = My.Math.Mult(52, ans);
            ans = My.Math.Div(17183, 1);
            Console.WriteLine($"Answer is {ans}");
        }

        static void Main(string[] args) {
            var pgm = new Program();
            pgm.Run();
        }
    }
}
