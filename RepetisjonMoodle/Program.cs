namespace RepetisjonMoodle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hello, World!");
                Console.WriteLine("What's your name?");
                string Name = Console.ReadLine();
                Console.WriteLine($"Hello, welcome {Name}");
                Console.WriteLine("");
                Console.WriteLine("Please Pick one to do: ");
                Console.WriteLine("0 To exit the program");
                Console.WriteLine("1 To see DataTypes");
                Console.WriteLine("2 To see the sum of two numbers");
                Console.WriteLine("3 To add your own numbers to see the result");
                int AppCoice = Console.Read();
                if (AppCoice == '0')
                {
                    break;
                }
                if (AppCoice == '1')
                {
                    ShowDataTypes();
                }
                else if (AppCoice == '2')
                {
                    GetTheSum();
                }
                else if (AppCoice == '3')
                {
                    VariabelTilordning();
                }
                
            }
            //int, long, float, decimal, double, string, char og bool.
            static void ShowDataTypes()
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("These are the different Variable types within C#");
                    Console.WriteLine("");
                    int aNumber = 4; // a whole number, no decimals allowed.
                    long aBiggerNumber = 129584; // A whole number, it has a larger range than int does. 
                    float aDecimalNumber = 1.0f; // A small Decimal number, not much more than 6 or 7 decimals. 
                    double anotherDecimalNumber = 5.99; //This is the default one, so you don't need to put d behind it, but you can to specify that it is a double. it can hold 15 decimals.
                    string aLineOfText = "This is a line of text"; //string can hold just that, a string of text.
                    char aCharacter = 'B'; //It can hold a single character, make sure to use '' unlike string.
                    bool trueOrFalse = true; // This is a standard boolean, it can be true or false.

                    //To print the variables it is very straight forwards, use $"" around it and the {}, you can also put the dollar sign straight in front of the curly brackets.
                    Console.WriteLine($"This is an int variable: {aNumber}");
                    Console.WriteLine($"This is a long variable: {aBiggerNumber}");
                    Console.WriteLine($"This is a float variable: {aDecimalNumber}");
                    Console.WriteLine($"This is a double variable: {anotherDecimalNumber}");
                    Console.WriteLine($"This is a string variable: {aLineOfText}");
                    Console.WriteLine($"This is a single character variable: {aCharacter}");
                    Console.WriteLine($"This is a true or false boolean variable: {trueOrFalse}");

                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Press x to return to the main menu again.");
                    string ButtonToReturn = Console.ReadLine();
                    if (ButtonToReturn == "x")
                    {
                        break;
                    }
                }
            }

            void GetTheSum()
            {
                //Oppgave 2: 

                //Lag en konsoll - applikasjon som lager 3 variabler.De kan hete a, b og sum. 
                //-a skal være en int.
                //- b skal være en decimal.

                //    Verdiene variablene skal ha er:

                //-a = 5;
                //-b = 3;
                //-sum = a + b;
                //Hva slags type variabel må sum være ?
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Here we will see how variable's has to match up to work properly. press x to return to main.");
                    int a = 5; 
                    float b = 3.4F;
                    float sum = a + b; //Når b er et decimal tall må også sum være det. Du vil ha med decimal tallene også når du regner ut en slik sum.

                    Console.Write($"{a} + {b} = ");
                    Console.WriteLine("");
                    Console.WriteLine($"the sum of a and b is {sum}");
                    Console.WriteLine("");
                    Console.WriteLine("please press x to return to main:");
                    string Return = Console.ReadLine();
                    if (Return == "x" ) { break; }
                }
            }

            void VariabelTilordning()
            {
                //Oppgave 1:

                //Lag en metode som tar inn og returnerer summen av to tall

                //------------------------------------------------------------------

                //    Oppgave 2:

                //Lag en metode som skal printe setningen "Denne metoden returnerer ingenting" til konsollen.

                //    Denne metoden skal altså ikke returnere noe verdi;)  

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Please input a number:");
                    int number1 = Console.Read();
                    Console.WriteLine("");
                    Console.WriteLine("Please input another number:");
                    int number2 = Console.Read();
                    Console.WriteLine("");
                    int sum = number1 + number2;
                    Console.WriteLine($"The sum of the two input numbers is: {sum}");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("This method returns nothing!");
                    Console.WriteLine("");
                    Console.WriteLine("Please input x to return to main");
                    string Return = Console.ReadLine();
                    if (Return == "x") { break;}
                }
            }






        }

       
    }
}
