namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Numbers()
            {
                int num1;

                num1 = 13;
                int num2 = 24;

                int sum = num1 + num2;
                Console.WriteLine("num1 " + num1 + " + num2 " + num2 + " is " + sum);

                double d1 = 3.1415;
                double d2 = 5.1;
                double dDiv = d1 / d2;
                Console.WriteLine("d1/d2 is " + dDiv);

                float f1 = 3.1415f;
                float f2 = 5.1f;
                float fDiv = f1 / f2;
                Console.WriteLine("f1/f2 is " + fDiv);

                double dIDiv = d1 / num1;
                Console.WriteLine("d1/num1 is " + dIDiv);
                Console.Read();

            }
            static void Strings()
            {
                string myname = "Rehan";

                string message = "My name is " + myname;

                string capsMessage = message.ToUpper();

                Console.WriteLine(capsMessage);
                Console.Read();
            }
            static void Read()
            {
                Console.Write("Enter a string and press enter: ");
                string readInput = Console.ReadLine();
                Console.WriteLine("You have entered {0}", readInput);

                Console.Write("Enter a string and press enter: ");
                int asciiValue = Console.Read();
                Console.WriteLine("ASCII value is {0}", asciiValue);
                Console.ReadKey();
            }
            static void NamingConventions()
            {
                // Class Names like ClientActivity
                // Method Names like CalculateValue()
                // Method Arguments like firstNumber
                // Use userControl instead of usrCtrl
                // Local Variables like itemCount
                // Constants like MAX_VALUE
                // Use Noun or Noun Phrases for Class Names
            }
            static void Casting()
            {
                // Implicit Conversion
                int num = 12390532;
                long bigNum = num;

                float myFloat = 23.37f;
                double myNewDouble = myFloat;

                double myDouble = 13.37;
                int myInt;

                // Cast double to int
                myInt = (int)myDouble; // Explicit Conversion

                // Type Conversion
                string myString = myDouble.ToString();
                string myFloatString = myFloat.ToString();
                bool sunIsShining = false;

                Console.WriteLine(myInt);
                Console.WriteLine(myString);
                Console.WriteLine(myFloatString);
                Console.WriteLine(sunIsShining.ToString());
                Console.ReadKey();
            }
            static void Parsing()
            {
                string myString = "15";
                string mySecondString = "13";
                int num1 = Int32.Parse(myString);
                int num2 = Int32.Parse(mySecondString);

                string stringForFloat = "0.85"; // datatype should be float
                string stringForInt = "12345"; // datatype should be int

                float parsedStringForFloat = float.Parse(stringForFloat);
                int parsedStringForInt = int.Parse(stringForInt);

                int result = num1 + num2;
                Console.WriteLine(result);
                Console.WriteLine("Parsed Float is {0} and Parsed Int is {1}", parsedStringForFloat, parsedStringForInt);
                Console.ReadKey();
            }
            static void StringManipulation()
            {
                // Define few variables
                int age = 31;
                string name = "Rehan";
                string job = "Developer";

                // Concatenation
                string concat = "My name is " + name + " and I am " + age;
                Console.WriteLine(concat);

                // String Formatting
                string format = string.Format("My name is {0}, I am a {2} and I am {1} years old.", name, age, job);
                Console.WriteLine(format);

                // String Interpolation
                string interpolation = $"My name is {name}, I am a {job} and I am {age} years old.";
                Console.WriteLine(interpolation);

                // Verbatim String
                string verbatim = @"This is a verbatim string, \n will not work here. 

                But spaces work";
                Console.WriteLine(verbatim);
                Console.WriteLine(@"C:\User\Admin\Dog"); // @ can be used to print paths as the standard write will treat \ as escape character
            }
            StringManipulation();
        }
    }
}
