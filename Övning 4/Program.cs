using System;
using System.ComponentModel.Design;


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

            List<string> theList = [];
            string tryAgain = "\nFörsök igen genom att klicka på valfri tangent.";
            string? input = "";

            /* 
                Har lagt till denna kod för att se listans Count/Capacity värden innan vi börjar lägga till värden i listan.
                Console.WriteLine("List count: " + theList.Count);
                Console.WriteLine("List capacity: " + theList.Capacity);
                Console.WriteLine("\nKlicka på valfri tangent för att fortsätta.");
                Console.ReadKey();
            */

            // Använder en do-while loop för att denna metod ska vara igång tills användaren själv avslutar den.
            // Har valt kontrollera ifall inmatningen är lika med 'exit' för att avgöra om loop:en ska fortsätta gå.
            do
            {
                // Använder en try-catch för felhantering av användar-inmatning samt en if-statement som kollar ifall inmatningen är lika med null eller om strängen är tom.
                try
                {
                    Console.Clear();
                    Console.WriteLine
                        (
                            "Lägg till eller ta bort ett ord i listan genom att skriva "
                            + "+ eller - framför ordet. T.ex. +Bil eller -Bil." +
                            "\nSkriv 'exit' för att gå tillbaka till huvudmenyn.\n"
                        );
                    Console.Write("Ange (+/-)ord: ");
                    input = Console.ReadLine();
                    if (input == null || input == "")
                    {
                        Console.WriteLine("Var vänlig och använd tecken." + tryAgain);
                        Console.ReadKey();
                        continue;
                    }
                    char nav = input[0];
                    string value = input[1..];
                    Console.Clear();

                    /*
                        Övning 1.

                        2.  När ökar listans kapacitet?

                                Listan kapacitet ökar när vi lägger till det första värdet och därefter när vi lagt till 4 värden till.              

                        3.  Med hur mycket ökar kapaciteten?

                                Bortsett från första gången listans kapacitet ökar (till 4) så dubbleras kapaciteten varje gång.
                        
                        4.  Varför ökar inte listans kapacitet i samma takt som element läggs till?

                                Varje gång kapaciteten ökar så skapas en ny intern array och ifall en ny array skulle behöva skapas 
                                varje gång ett element läggs till så skulle det innebära en onödig stor mängd minnesallokering. Så 
                                anledningen till varför den inte gör det är av prestandaskäl. 

                        5.  Minskar kapaciteten när element tas bort ur listan?
                        
                                Nej, ifall kapaciteten har ökat en gång så behåller listan sin kapacitet.

                        6.  När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
                                
                                När antalet element är fördefinerat/bestämt.                               
                            
                    */


                    // Använder switch för kontrollera användarens inmatning
                    // Ifall användaren har lagt till +/- så kommer de två första alternativen att genomföras, annars blir det default.
                    // Enkel theList.Add() och Remove() som används för att lägga till eller ta bort inmatning från listan.

                    switch (nav)
                    {
                        
                        case '+':
                            theList.Add(value);
                            Console.WriteLine("List count: " + theList.Count);
                            Console.WriteLine("List capacity: " + theList.Capacity);
                            Console.WriteLine("\nKlicka på valfri tangent för att fortsätta.");
                            Console.ReadKey();
                            break;

                        case '-':
                            theList.Remove(value);
                            Console.WriteLine("List count: " + theList.Count);
                            Console.WriteLine("List capacity: " + theList.Capacity);
                            Console.WriteLine("\nKlicka på valfri tangent för att fortsätta.");
                            Console.ReadKey();
                            break;

                        default:
                            Console.WriteLine
                                (
                                    "Var vänlig och använd + eller - framför det ord " +
                                    "du vill lägga till/ta bort." + tryAgain
                                );
                            Console.ReadKey();
                        break;
                    }                                                                                                          
                }

                catch
                {
                    Console.WriteLine("Ogiltig inmatning." + tryAgain);
                    Console.ReadKey();
                }
                
            } while (input != "exit");

            Console.Clear();
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
            

            
                Övning 2.
            
                    1.  Simulera följande kö på papper:
                        a.  ICA öppnar och kön till kassan är tom
                        b.  Kalle ställer sig i kön
                        c.  Greta ställer sig i kön
                        d.  Kalle blir expedierad och lämnar kön
                        e.  Stina ställer sig i kön
                        f.  Greta blir expedierad och lämnar kön
                        g.  Olle ställer sig i kön
                        h.  Stina blir expedierad och lämnar kön 

                                         
                    2.
                         Liknande struktur till övning 1 med skillnad att Queue<string> används här samt theQueue.Enqueue() och Dequeue().

                        Har valt att använda en List<string> vid sidan om Queue<string> då det är enklare att simulera den exakta ICA-kön som finns med i uppgiften.

                        Genom att mata in följande så kan ICA-kön simuleras...

                        - +Kalle
                        - +Greta
                        - -Kalle
                        - +Stina
                        - -Greta
                        - +Olle
                        - -Stina

            */

            Queue<string> theQueue = [];
            List<string> theList = [];
            string tryAgain = "\nFörsök igen genom att klicka på valfri tangent.";
            string? input = "";
                      
            do
            {
                try
                {
                    Console.Clear();                    
                    Console.WriteLine
                        (
                            "Lägg till eller ta bort ett element i kön genom att skriva "
                            + "+ eller - framför ordet. T.ex. +Bengt eller -Bengt." +
                            "\nSkriv 'exit' för att gå tillbaka till huvudmenyn.\n"                         
                        );

                    Console.WriteLine("ICA öppnar och kön till kassan är tom");
                    foreach (string str in theList)
                    {
                        Console.WriteLine(str);
                    }

                    Console.Write("\nAnge (+/-)ord: ");
                    input = Console.ReadLine();
                    if (input == null || input == "")
                    {
                        Console.WriteLine("Var vänlig och använd tecken." + tryAgain);
                        Console.ReadKey();
                        continue;
                    }
                    
                    Console.Clear();
                    char nav = input[0];
                    string value = input[1..];
                    Console.Clear();


                    switch (nav)
                    {

                        case '+':
                            theQueue.Enqueue(input);
                            theList.Add(input + " ställer sig i kön");                      
                            break;

                        case '-':
                            theList.Add(theQueue.Dequeue() + " blir expedierad och lämnar kön"); 
                            break;
                      
                        
                        default:
                            Console.WriteLine
                                (
                                    "Var vänlig och använd + eller - framför det ord " +
                                    "du vill lägga till/ta bort." + tryAgain
                                );
                            Console.ReadKey();
                            break;
                    }
                }

                catch
                {
                    Console.WriteLine("Ogiltig inmatning." + tryAgain);
                    Console.ReadKey();
                }

            } while (input != "exit");

            Console.Clear();
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
              
              1.    Att använda en stack skulle bli väldigt mycket extra arbete istället för Queue då
                    en Queue tar allt i ordning medans ifall vi skulle använda en Stack i en ICA-Kö så skulle vi
                    behöva skriva ut kön baklänges vilket inte alls skulle fungera i ett verkligt sammanhang.
              
                Återanvänder samma kod/struktur som i de andra metoderna.
            */

            Stack<string> theStack = [];
            List<string> theList = [];
            string tryAgain = "\nFörsök igen genom att klicka på valfri tangent.";
            string? input = "";

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine
                        (
                            "Lägg till eller ta bort ett element i stack:en genom att skriva "
                            + "+ eller - framför ordet. T.ex. +Bengt eller -Bengt." +
                            "\nSkriv 'exit' för att gå tillbaka till huvudmenyn.\n" +
                            "Använd * framför ett ord för att skriva ut det baklänges med" +
                            "hjälp av stack."
                        );

                    Console.WriteLine("ICA öppnar och kön till kassan är tom");
                    foreach (string str in theList)
                    {
                        Console.WriteLine(str);
                    }

                    Console.Write("\nAnge (+/-)ord: ");
                    input = Console.ReadLine();
                    if (input == null || input == "")
                    {
                        Console.WriteLine("Var vänlig och använd tecken." + tryAgain);
                        Console.ReadKey();
                        continue;
                    }

                    Console.Clear();
                    char nav = input[0];
                    string value = input[1..];
                    Console.Clear();


                    switch (nav)
                    {

                        case '+':
                            theStack.Push(input);
                            theList.Add(input + " ställer sig i kön");
                        break;

                        case '-':
                            theList.Add(theStack.Pop() + " blir expedierad och lämnar kön");
                        break;

                        case '*':
                            string reversedText = ReverseText(input);
                            Console.WriteLine(reversedText);
                            Console.WriteLine("\nKlicka på valfri tangent för att fortsätta.");
                            Console.ReadKey();
                        break;

                        default:
                            Console.WriteLine
                                (
                                    "Var vänlig och använd + eller - framför det ord " +
                                    "du vill lägga till/ta bort." + tryAgain
                                );
                            Console.ReadKey();
                            break;
                    }
                }

                catch
                {
                    Console.WriteLine("Ogiltig inmatning." + tryAgain);
                    Console.ReadKey();
                }

            } while (input != "exit");

            Console.Clear();
        }

        public static string ReverseText(string input)
        {
            // Tar bort * från inmatningen.
            input = input[1..];

            // Använder en Stack<char> för att uttnyttja stack:en i detta fall.

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
                stack.Push(input[i]);
                        
            string reversedText = "";

            //  Matar på strängen med Pop() vilket då returnerar sista char:en i stacken
            //  vilket resulterar i 'Reversed' sträng.
                
            while (stack.Count > 0)
            {
                reversedText += stack.Pop(); 
            }

            return reversedText; 
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             
             1. 
                Stack<char> fungerar bättre när vi har hittat en 'match' och ska ta bort paranteserna.            
             */

            Stack<char> theStack = [];
            string tryAgain = "\nFörsök igen genom att klicka på valfri tangent.";
            string? input = "";

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Skriv in 'exit' för att återvända till huvudmenyn.");
                    Console.Write("Var vänlig och fyll i en sträng: ");
                    input = Console.ReadLine();
                    if (input == null || input == "")
                    {
                        Console.WriteLine("Var vänlig och använd tecken." + tryAgain);
                        Console.ReadKey();
                        continue;
                    }
                               
                    bool correctFormat = true;

                    // For-loop som används för att gå igenom alla tecken i inmatningssträngen.

                    for (int i = 0; i < input.Length; i++)
                    {

                        // Kontrollerar först ifall det nuvarande tecknet är lika med (, [, { och lägger till det i stacken.

                        if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                            theStack.Push(input[i]);

                        // Om en motsvarande parantes upptäcks så kollas det först att stack:en inte är tom.

                        else if (input[i] == ')' || input[i] == ']' || input[i] == '}')
                        {
                            if (theStack.Count == 0)
                            {
                                correctFormat = false;
                                break;
                            }

                            // Ifall stacken inte är tom så kontrolleras den nuvarande parantesen mot matchande parantes i stack:en.
                            // och om den matchar så tas matchande parantes bort från stacken då paranteserna 'matchar'. 

                            if
                            (
                                input[i] == ')' && theStack.Peek() == '(' ||
                                input[i] == ']' && theStack.Peek() == '[' ||
                                input[i] == '}' && theStack.Peek() == '{'
                            )
                            {
                                theStack.Pop();
                            }
                          

                            else
                            {
                                correctFormat = false;
                                break;
                            }
                        }                       
                    }

                    if (theStack.Count > 0)
                        correctFormat = false;

                    if (!correctFormat)
                        Console.WriteLine("Strängen har inkorrekt format.");

                    else
                        Console.WriteLine("Strängen har korrekt format.");

                    Console.WriteLine("\nTryck på valfri tangent för att fortsätta.");
                    Console.ReadKey();


                }

                catch
                {
                    Console.WriteLine("Ogiltig inmatning." + tryAgain);
                    Console.ReadKey();
                }

            } while (input != "exit");

            Console.Clear();

        }

    }

    
}

