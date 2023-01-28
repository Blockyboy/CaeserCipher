using System;

namespace CaeserCipher
{
    class Program
    {
        public static void Initialise()
        {
            string insert = "Hello Github!";
            int position = 2;

            Console.WriteLine("Caeser Cipher");

            Console.WriteLine("");

            Information(ref insert, ref position);

            Output(insert, position);
        }

        public static void Information(ref string insert, ref int position)
        {
            Console.Write("Insert phrase you would like to cipher: ");

            insert = Console.ReadLine();

            Console.Write("Insert the cipher shift: ");

            position = Convert.ToInt32(Console.ReadLine());
        }

        public static void Output(string insert, int position)
        {
            string output = "";
            int asciiOutput = 0;


            char[] insertSplit = insert.ToCharArray();

            for (int i = 0; i < insertSplit.Length; ++i)
            {
                if (insertSplit[i] <= 90 && insertSplit[i] >= 65)
                {
                    if (insertSplit[i] + position > 90)
                    {
                        asciiOutput = (insertSplit[i] + position) - 26;
                    }

                    else
                    {
                        asciiOutput = insertSplit[i] + position;
                    }

                    output += Convert.ToChar(asciiOutput);
                }
                else if (insertSplit[i] <= 122 && insertSplit[i] >= 97)
                {
                    if (insertSplit[i] + position > 122)
                    {
                        asciiOutput = (insertSplit[i] + position) - 26;
                    }
                    else
                    {
                        asciiOutput = insertSplit[i] + position;
                    }

                    output += Convert.ToChar(asciiOutput);
                }

                if (insertSplit[i] == ' '
             || insertSplit[i] == '.'
             || insertSplit[i] == '!'
             || insertSplit[i] == '?'
             || (insertSplit[i] - 0 >= 48
             && insertSplit[i] - 0 <= 57))
                {
                    output += insertSplit[i];
                }
            }

            Output(output);
        }

        public static void Output(string output)
        {
            Console.WriteLine(output);
        }

        static void Main(string[] args)
        {
           Initialise();
        }
    }
}
