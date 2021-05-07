namespace FieldGuide_Array_ToString
{
    // C# code to illustrate the
    // Stack.ToArray() Method
    using System;
    using System.Collections;

    class CriminalOffenses
    {
        public static void Main()
        {
            // Creating a Stack
            Console.WriteLine("Naming a Stack, 'Crimes'");
            Console.ReadLine();
            Stack crimes = new Stack();

            // Inserting the elements into the Stack
            Console.WriteLine("Inserting five elements into the Stack");
            Console.ReadLine();
            crimes.Push("Felony");
            crimes.Push("Misdy");
            crimes.Push("Assault");
            crimes.Push("DUI");
            crimes.Push("Theft");

            // Converting the Stack into array
            Console.WriteLine("Converting the stack into array");
            Console.ReadLine();
            Object[] arr = crimes.ToArray();


            // Displaying the elements in array
            Console.WriteLine("Apply 'for each' loop");
            Console.ReadLine();
            foreach (Object str in arr)
            {
                Console.WriteLine(str);
            }
            
           
            Console.ReadLine();
        }
    }
}
