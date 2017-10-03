using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring. Just saying it exists.
            //int favoriteNumber;
            //Initializing. It's the "equals"
            // int favoriteNumber = "1"

            //declare an array
            //int[] favoriteNumbers;
            //Jarryd pluralized. Because when we talk about arrays we are talking about many things of the same type.
            //This plural is for us, the humans, to make sense of it.

            //initialize the array
            //int[] favoriteNumbers = { 1, 2, 3, 4, 5, 6, };

            //string[] studentNames = { "Raz", "Monica", "David", "Brian", "Ali" };

            //Console.WriteLine(favoriteNumbers[0]);
            //Console.WriteLine(studentNames[2]);

            ////Do it.
            //string[] vacationSpots = { "Aruba", "Jamaica", "Sweden", "California", "Alaska",
            //    "India", "Hawaii", "Mexico", "Switzerland", "Italy" };
            //Console.WriteLine(vacationSpots[0] + " " + vacationSpots[9]);          


            //int[] childAge = { 1, 12, 6 };
            //Console.WriteLine(childAge[0] + " " + childAge[1] + " " + childAge[2]);


            //decimal[] gpa = { 2.0m, 2.5m, 2.9m, 3.0m, 3.1m, 3.8m, 3.9m, 4.0m };
            //Console.WriteLine(gpa[7]);

            //char[] peerLetter = { 'M', 'R', 'B', 'D' };
            //Console.WriteLine(peerLetter[3]);

            //Console.WriteLine("\n\n");

            ////this is how we initialize an array when we don't know all the elements upfront.
            ////we declare an empty array.
            ////but there are four arrays, and we can only put ints in there.
            //int[] numbers = new int[4];

            //Console.WriteLine("Hello again. Can you guess my two numbers?");

            //numbers[0] = 43;  //we are storing a value in that first element in our array.
            //numbers[1] = 12;
            //numbers[2] = int.Parse(Console.ReadLine());
            //numbers[3] = int.Parse(Console.ReadLine());

            //Console.WriteLine(numbers[0] + " " + numbers[1] + " " + numbers[2] + " " + numbers[3]);

            //if (numbers[0] == numbers[2] && numbers[1] == numbers[3])
            //{
            //    Console.WriteLine("You guessed my numbers!");
            //}
            //else
            //{
            //    Console.WriteLine("You are not a good guesser.");
            //}

            //do it. this is the unsure thing.

            //string[] daysOfWeek = new string[7];
            //daysOfWeek[0] = "Sunday";
            //daysOfWeek[1] = "Mon";
            //daysOfWeek[2] = "Tues";
            //daysOfWeek[3] = "Wed";
            //daysOfWeek[4] = "Thurs";
            //daysOfWeek[5] = "Fri";
            //daysOfWeek[6] = "Sat";

            //int[] studAges = new int[5];
            //studAges[0] = 21;
            //studAges[1] = 29;
            //studAges[2] = 24;
            //studAges[3] = 11;
            //studAges[4] = 19;

            //Console.WriteLine(daysOfWeek.Length); //.Length counts characters. .Length for an array counts the indices.
            //Console.WriteLine(daysOfWeek[0].Length); //counts the characters

            //char[] lName = { 'F', 'O', 'X' };
            //Console.WriteLine(lName.Length);

            //string[] myName = { "F", "O", "X" };
            //Console.WriteLine(myName.Length);
            //Console.WriteLine(myName[1].Length);

            //string[] colors = new string[4];
            //colors[0] = "Violet";
            //colors[1] = "Red";
            //colors[2] = "Blue";
            //colors[3] = "Green";
            //Console.WriteLine(colors[1].Length);
            //Console.WriteLine(colors.Length);

            //Console.WriteLine("This is the last index, \"" + colors[colors.Length - 1] + "\"."); //if ever we need to find the last in an array,
            ////use .Length - 1

            //int index = colors.Length;
            //index = index - 2; // -1 = last index. -2 second to last index. And so on.

            //Console.WriteLine(colors[index]); //we can put a variable that is an int in this place!!!

            //string[] strArray = { "This", "is", "array", "of", "words" };
            //Console.WriteLine(strArray[strArray.Length - 1]);
            //Console.WriteLine(strArray[strArray.Length - 2]);
            //Console.WriteLine(strArray.Length);
            //you could write some intense poetry this way.

            //like have a long poem already indexed. Have user input several numbers, referring to the words. Let the words pull together.

            //week2day2 stuff. Finishing arrays
            //Console.WriteLine("Please enter the size of your array.");

            //int arraySize = int.Parse(Console.ReadLine());

            //int[] newArray = new int[arraySize];

            //Console.WriteLine("The array is of length " + newArray.Length);  //this allows user to input array size.
            ////think like, "Welcome to Party Manager! How many people are you inviting? Cool, add their names." Loop required.

            ////Let's do some examples! Helper methods!

            //string[] birthMonths = { "October", "July" , "October" , "May" };
            //Console.WriteLine(Array.IndexOf(birthMonths, "October"));
            //Console.WriteLine(Array.IndexOf(birthMonths, "August"));

            //// when returns -1, means it doesn't exist.

            //Console.WriteLine(Array.IndexOf(birthMonths, "Oct"));

            ////looks for the whole element, not the string. Will return -1
            ////There's another version of this method where we can say where to start from.
            ////indexOf for strings = put in a value. returns the FIRST index it's found.
            ////also for arrays.

            // Console.WriteLine("\n");

            // int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5, };
            // Console.WriteLine(Array.LastIndexOf(numbers, 4));

            // LastIndexOf searches from the end.Whole array.
            
            //Console.WriteLine("\n" + numbers[0]);

            // Array.Reverse(numbers);
            // Console.WriteLine(numbers[0]);

            // Console.WriteLine(numbers[numbers.Length - 1]);
            // cool you did extra biz

            // Array.Sort(numbers); //Sort will either sort in ascending order number, and alphabetical for strings.
            // Console.WriteLine(numbers[0]);//first spot
            // Console.WriteLine(numbers[numbers.Length - 1]);//last spot


            //DO it!!
            string[] firstNames = { "Monica", "Raz", "David", "Brian", "Kaitie", "Jarryd", "Ali" };
            Console.WriteLine(Array.IndexOf(firstNames, "Kaitie"));

            int[] luckyNumbers = { 13, 64, 2, 3, 7, 4, 777, 13, 2, 13, 13, 7, 777, 64, 4, 4, 4 };
            Console.WriteLine(Array.LastIndexOf(luckyNumbers, 13));

            char[] alphabet = { 'a', 'b', 'd', 'd', 'a', 'c', 'v', 'f', 'o', 'x' };
            Console.WriteLine(alphabet[0]); //should show a
            Array.Reverse(alphabet);
            Console.WriteLine(alphabet[0]);//should show x

            string[] randomNames = { "Monica", "Raz", "David", "Brian", "Kaitie", "Jarryd", "Ali" };
            Array.Sort(randomNames);
            Console.WriteLine((randomNames[0]) + " and " + (randomNames[randomNames.Length - 1])); //should show Ali and Raz

            int[] favNumbers = { 5, 3, 9, 7, 42, 11, 21, 21, 48, 21 };
            Array.Sort(favNumbers);
            Console.WriteLine((favNumbers[0]) + " and " + (favNumbers[favNumbers.Length - 1]));//should show 3 and 48

            Console.WriteLine("Let's try numbers ourselves. Can I have 5 numbers?");
            double[] userNumbers = new double[5];
            userNumbers[0] = double.Parse(Console.ReadLine());
            userNumbers[1] = double.Parse(Console.ReadLine());
            userNumbers[2] = double.Parse(Console.ReadLine());
            userNumbers[3] = double.Parse(Console.ReadLine());
            userNumbers[4] = double.Parse(Console.ReadLine());

            Array.Sort(userNumbers);
            Console.WriteLine("The smallest number is " + userNumbers[0]);
            //hell yeah it works.
            Console.WriteLine("And the biggest number is " + userNumbers[userNumbers.Length - 1]);



        }
    }
}
