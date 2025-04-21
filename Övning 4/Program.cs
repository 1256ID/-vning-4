using System;
using System.Security.Cryptography.X509Certificates;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
                  
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {


            /*
                1. Hur fungerar stacken och heapen? Förklara gärna med exempel eller skiss på dess grundläggande funktion?
                
                Stacken är ett är ett område där 'Value-typer' så som bool, char, integer etc. lagras. Heapen däremot lagrar 
                'Referens-typer' som te.x. strings, objekt och klasser. Se exempel nedanför.
                
                public void StackExample() 
                {        
                    // Lagras i stack
                    int a = 0; 
                    int b = 1;                                   
                }

                public void HeapExample() 
                {
                    // Lagras på heapen.
                    object obj = new(); 
                    string str = "text";
                }

                En annan skillnad mellan Stack och Heap är att stacken per automatik rensar bort allt den lagrar efter användning. 
                I StackExample() betyder det att både int a och b enbart lagras i stacken så länge metoden är igång, därefter frigörs
                dem från stacken.

                Heapen har istället något som kallas Garbage collection (GC) vilket också rensar bort det som lagras men det sker inte omedelbart 
                som det gör för stack:en. Referens-typer finns därav kvar tills GC rensar bort dem.

                             
                public class MyClass 
                {
                    
                    public int a = 0;

                    public void ValueTypeInReferenceType() 
                    {
                        int b = 1;
                    }              
                }
                
                Om jag däremot deklarar integer 'a' som public i en klass så kommer den att lagras i heapen då alla fält inom en klass räknas som en referenstyp. 
                Integer 'b' lagras däremot fortfarande i stack:en då den fortfarande är en lokal variabel i detta fall. På ett sätt går det att säga att alla 
                value-typer som deklareras i en klass eller objekt lagras på heapen eftersom att de instansieras när vi deklarerar dem där.
                
            
                2. Vad är Value Types respektive Reference Types och vad skiljer dem åt?

                Value Types är typer från System.ValueType. Exempel på dessa är...

                - bool
                - char
                - int
                - byte
                - double
                - enum
                - float
                
                Reference Types är typer som ärver från System.Object (eller är System.Object.object). Exempel på dessa är...
                
                - class
                - interface
                - object
                - delegate
                - string

                Den största skillnaden mellan value och reference types är att value-types lagrar själva värdet medans reference-types lagrar
                en referens till värdet.

                3. 
                
                public int ReturnValue2()
                {
                    MyInt x = new MyInt();
                    x.MyValue = 3;
                    MyInt y = new MyInt();
                    y = x;
                    y.MyValue = 4;
                    return x.MyValue;
                }

                ReturnValue2 returnerar '4' istället för '3' eftersom att x och y är två stycken referenstyper och innehåller därför inte värden 
                utan referenser till dem. När y tilldelas x så tilldelas inte värdet utan vad som sker är att y tilldelas en referens till x objektet.
                Det i sin tur leder till x och y nu istället pekar mot samma objekt (x), när y.MyValue tilldelas 4 så tilldelas x.MyValue eftersom 
                att y nu pekar mot x objektet istället. 

             
                
              
              
             
            */

            while (true)
            {                        
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }

    
}

