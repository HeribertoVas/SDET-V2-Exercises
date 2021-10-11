using System;

namespace Exercise_2_Development
{
    class Program
    {
        int num;
        public Program()
        {
            num = 0;
        }

        public Program(int number)
        {
            num = number;
        }

        static int add(int a, int b) { return a + b; }
        static int add(int a, int b, int c) { return a + b + c; }

        private String word;
        public String Word
        {
            get
            {
                return word;
            }
            set
            {           
                word = value;
            }
        }

        public void printDiagonal()
        {
            String spaces = " ";

            for(int i=0; i<10 ; i++)
            {
                Console.WriteLine(spaces+ i);
                spaces += " ";
            }
            
        }

        public void isPalindrome(String str)
        {
            String reverse = "";
            str = str.Replace(" ", "");
            for (int i = str.Length - 1; i > -1; i--)
            {
                reverse += str[i];
                Console.WriteLine(reverse);
            }

            if (str == reverse)
            {
                Console.WriteLine("PALINDROME!!");
            }
            else
            {
                Console.WriteLine("NOT PALINDROME!!");
            }

        }




        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.printDiagonal();
            prog.Word = "rotator";
            String st = prog.Word;
            prog.isPalindrome(st);
        }
    }
}
