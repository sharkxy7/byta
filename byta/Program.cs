using System;

namespace byta;

class program
{ 
    static void Main(string[]args)

    {
        Console.WriteLine("Hur gammal e du?");
        Console.Write("Skriv din ålder här: ");
        int alder = int .Parse(Console.ReadLine());
        if (  alder >= 16 && alder <=19 )

        { Console.WriteLine("Du får delta i tävlingen!"); }
        else 
        { Console.WriteLine("Tyvärr, du får inte delta i tävlingen!"); }


    }






    
}   


