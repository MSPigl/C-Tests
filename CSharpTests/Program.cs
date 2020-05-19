using System;
using System.Timers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace CSharpTests
{
    class Morse
    {
        static string toMorse(string text)
        {
            text = text.ToLower();

            char[] arr = text.ToCharArray();

            StringBuilder morse = new StringBuilder("");

            foreach (char c in arr)
            {
                if (Char.IsWhiteSpace(c))
                {
                    morse.Append(" / ");
                    continue;
                }

                switch(c)
                {
                    case 'a':
                        morse.Append(".-");
                        break;
                    case 'b':
                        morse.Append("-...");
                        break;
                    case 'c':
                        morse.Append("-.-.");
                        break;
                    case 'd':
                        morse.Append("-..");
                        break;
                    case 'e':
                        morse.Append(".");
                        break;
                    case 'f':
                        morse.Append("..-.");
                        break;
                    case 'g':
                        morse.Append("--.");
                        break;
                    case 'h':
                        morse.Append("....");
                        break;
                    case 'i':
                        morse.Append("..");
                        break;
                    case 'j':
                        morse.Append(".---");
                        break;
                    case 'k':
                        morse.Append("-.-");
                        break;
                    case 'l':
                        morse.Append(".-..");
                        break;
                    case 'm':
                        morse.Append("--");
                        break;
                    case 'n':
                        morse.Append("-.");
                        break;
                    case 'o':
                        morse.Append("---");
                        break;
                    case 'p':
                        morse.Append(".--.");
                        break;
                    case 'q':
                        morse.Append("--.-");
                        break;
                    case 'r':
                        morse.Append(".-.");
                        break;
                    case 's':
                        morse.Append("...");
                        break;
                    case 't':
                        morse.Append("-");
                        break;
                    case 'u':
                        morse.Append("..-");
                        break;
                    case 'v':
                        morse.Append("...-");
                        break;
                    case 'w':
                        morse.Append(".--");
                        break;
                    case 'x':
                        morse.Append("-..-");
                        break;
                    case 'y':
                        morse.Append("-.--");
                        break;
                    case 'z':
                        morse.Append("--..");
                        break;
                    case '0':
                        morse.Append("-----");
                        break;
                    case '1':
                        morse.Append(".----");
                        break;
                    case '2':
                        morse.Append("..---");
                        break;
                    case '3':
                        morse.Append("...--");
                        break;
                    case '4':
                        morse.Append("....-");
                        break;
                    case '5':
                        morse.Append(".....");
                        break;
                    case '6':
                        morse.Append("-....");
                        break;
                    case '7':
                        morse.Append("--...");
                        break;
                    case '8':
                        morse.Append("---..");
                        break;
                    case '9':
                        morse.Append("----.");
                        break;
                    case '.':
                        morse.Append(".-.-.-");
                        break;
                    case ',':
                        morse.Append("--..--");
                        break;
                    case ':':
                        morse.Append("---...");
                        break;
                    case '?':
                        morse.Append("..--..");
                        break;
                    case '\'':
                        morse.Append(".----.");
                        break;
                    case '-':
                        morse.Append("-....-");
                        break;
                    case '/':
                        morse.Append("-..-.");
                        break;
                    case '(':
                    case ')':
                        morse.Append("-.--.-");
                        break;
                    case '=':
                        morse.Append("-...-");
                        break;
                    case '\n':
                        morse.Append(".-.-");
                        break;
                }

                morse.Append(" ");
            }

            return morse.ToString();
        }

        static void playMorse(string morse)
        {
            char[] list = morse.ToCharArray();

            foreach(char c in list)
            {
                if (Char.IsWhiteSpace(c))
                {
                    Thread.Sleep(500);
                }
                else if (c == '.')
                {
                    Console.Beep();
                }
                else if (c == '-')
                {
                    Thread.Sleep(250);
                }
                else
                {
                    Thread.Sleep(750);
                }
            }
        }

        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 5; i++)
            {               
                Console.Beep();
                Console.Beep();
                Console.Beep();
                Thread.Sleep(1000);
            }
            */

            string morse = toMorse("4 + 4 = 8");

            Console.WriteLine(morse);
            playMorse(morse);
        }
    }
}