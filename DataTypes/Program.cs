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

                Console.WriteLine("this is a \"string \" with a backslash \\ and a colon: :");
            }
            static void Challenge1()
            {
                string varl;
                Console.Write("Please enter your name and press enter: ");
                varl = Console.ReadLine();
                Console.WriteLine($"Upper case: {varl.ToUpper()}");
                Console.WriteLine(varl.ToLower());
                Console.WriteLine(varl.Trim());
                Console.WriteLine(varl.Substring(0, 3));
            }
            static void Challenge2()
            {
                
                string varl;
                Console.Write("Enter a string here: ");
                varl = Console.ReadLine();
                Console.Write("Enter the character to search: ");
                char varl2 = Console.ReadLine()[0];
                Console.WriteLine(varl.IndexOf(varl2));
                

                Console.Write("Please enter your first name: ");
                string firstName = Console.ReadLine();
                Console.Write("Please enter your last name: ");
                string lastName = Console.ReadLine();
                string fullName = $"{firstName} {lastName}";
                Console.WriteLine($"Your name is {fullName}");
            }
            static void Challenge3()
            {
                byte number1 = 2;
                sbyte number2 = -3;
                int number3 = -5;
                uint number4 = 8;
                short number5 = -13;
                ushort number6 = 21;
                long number7 = -34;
                ulong number8 = 55;
                float number9 = 89.0f;
                double number10 = -144.0;
                char letter1 = 'a';
                bool isTrue = true;
                string name = "Rehan";
                decimal number11 = 233.0m;
                string string1 = "I control text";
                string string2 = "15";
                int number12 = Int32.Parse(string2);
                Console.WriteLine($"number 1: {number1}, number2: {number2}, " +
                    $"number3: {number3}, number4: {number4}, number5: {number5}, " +
                    $"number6: {number6}, number7: {number7}, number8: {number8}, " +
                    $"number9: {number9}, number10: {number10}, letter1: {letter1}, " +
                    $"isTrue: {isTrue}, name: {name}, number11: {number11}, string1: " +
                    $"{string1}, string2: {string2}, number12: {number12}");
            }
            static void Constants()
            { 
                const double PI = 3.14159265359;
                const int weeks = 52, months = 12;
                const int days = 365;
                const string birthday = "01/01/1980";
                Console.WriteLine("My birthday is always going to be: {0}", birthday);
            }
            /*
            WriteSomething();
            WriteSomethingSpecific("Hi, Rehan");
            Console.WriteLine(Add(15, 31));
            Console.WriteLine(Multiply(15, 31));
            Console.WriteLine(Divide(15, 31));
            Greeting("Rehan");
            Greeting("Rohan");
            Greeting("Rihan");
            Console.ReadKey();
            */
            Calculate();
        }
        // Start Section 3:
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }
        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
        public static int Add(int num1, int num2)
        { 
            return num1 + num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
        public static void Greeting(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        public static void Calculate()
        {
            Console.WriteLine("Please enter the first number: ");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your function: Add / Subtract / Multiply / Divide");
            string function = Console.ReadLine();
            if (function == "Add") Console.WriteLine(Add(num1, num2));
            else if (function == "Subtract") Console.WriteLine(Subtract(num1, num2));
            else if (function == "Multiply") Console.WriteLine(Multiply(num1, num2));
            else if (function == "Divide") Console.WriteLine(Divide(num1, num2));
            else Console.WriteLine("Invalid function");
        }
    }
}
