using System.Reflection.Metadata;

namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode; //This is here so we can see the squares.
            Console.WriteLine("Mata in en siffra");
            int number = Int32.Parse(Console.ReadLine()); //saving users input to a variable.
            bool chess = true;
            
            
            Console.WriteLine("Här är ditt chessboard:");
            for (int i = 0; i < number; i++) //forloop for the rows
            {
               
                for (int j = 0; j < number; j++) //forloop for the columns 
                {
                    if ((j + i) % 2 == 0) // if the combined loopnumbers is dividable with 2 it will write ◼︎
                    {
                        Console.Write("◼︎");

                    }
                    else //else ◻︎
                    {
                        Console.Write("◻︎");
                    }
                        
                }
                 Console.WriteLine(); //to jump rows
            }
            Console.WriteLine("Välj ut en ruta att placera in blabla");
            int piece = Int32.Parse(Console.ReadLine());
        }
    }
}