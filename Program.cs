using System;

namespace StackDemo
{
    class Program
    {
        static int [] num = new int[] { 0,0, 0, 0,0,0,0,0,0,0};
        static int top=-1;
        static void Main(string[] args)
        {

   string ch = "y";
    while(ch=="y")
    {
        Menu();
        int choice ;
        Console.WriteLine("Enter your choice");
        choice = Int32.Parse(Console.ReadLine());
        switch(choice)
        {
            case 1: 
            {  Console.WriteLine("Enter number");
              int x = Int32.Parse(Console.ReadLine());
            int top = Push(x);
               Console.WriteLine("Top points to " + top + " location");
            break;
            }
            case 2: {
                int top = Pop(); 
                    Console.WriteLine("Top points to " + top + " location");
                    break;
            }
            case 3 : Display(); break;

        }
         Console.WriteLine("Want to continue ? ");
         ch = Console.ReadLine();

    }      
        }
        static void Menu()
        {
            Console.WriteLine(" Main Menu ");
            Console.WriteLine("1. Insert ");
            Console.WriteLine("2. Delete ");
            Console.WriteLine("3. Display ");

        }
        static int Push(int x)
        { 
            if(top ==num.Length-1)
            Console.WriteLine("Overflow");
            else 
            num[++top] = x;
            return top;

        }
        static int Pop()
        {
            if(top < 0)
            Console.WriteLine("Underflow");
            else 
            { 
             num[top] =0;
             top = top -1;
            }
             return top;


        }
        static void Display()
        {
           for(int i = top ;i>=0; i--)
           Console.WriteLine(num[i]);
        }
    }
}
