using System;

namespace SyntaxSugarDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var myAge = 30;

            //var userAnswer = int.Parse(Console.ReadLine());

            //var firstName = "John";

            //firstName = "32";

            var x = 7;

            var y = 4;

            Compare(y, x);

            var myName = "j";
            var faveColor = "black";

            //compositeformatting
            Console.WriteLine("Hi  my name is {0}. My favorite color is {1}.",myName , faveColor);

            //Console.WriteLine(Compare(x, y));

            //Concatenation
            Console.WriteLine("Hi, my name is " + myName + ". My favorite color is " + faveColor + " . ");
            //string interp
            Console.WriteLine($"Hi my name is {myName}. My favorite color is {faveColor}.");

        }

        public static string Compare(int num1, int num2)
        {
            ////if else
            //if (num1  > num2)
            //{
            //    return $"{num1} is greater than {num2}";)
            //}
            //else
            //{
            //    return $"{num2} is greater than {num1}";
            //}

            ////TERNARY
            return (num1 > num2) ? $"{num1} is greater than {num2}" :
            $"{num2} is greater than {num1}";
            //';;
        }
         
        
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace SoloLearn
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Given the following code, change the code to implement
//            //inferred typing
//            //interpolation
//            //and the ternary operator

//            int answer = 4; //var EXPLICIT TYPING
//            string response; //Declared a variable

//            if (answer < 9)
//            {
//                response = answer + " is less than nine";
//            }
//            else
//            {
//                response = answer + " is greater than or equal to nine";
//            }

//            var newResponse = answer < 9 ? $"{answer} is less than nine woo" : $"{answer} is greater or equal to nine";

//            Console.WriteLine(newResponse);



//        }
//    }
//}

