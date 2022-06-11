using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.CompilerServices;
using colectii_generice.colectii;

namespace colectii_generice
{
    public class Probleme
    {
        private String text;

        public Probleme()
        {
            
        }

        public bool isBalantat()
        {

            String text = "(ana)(are[asdasd])";

            Stack<char> txt = new Stack<char>();

            foreach (var c in text)
            {

                if (c == '(' || c == '[' || c == '{')
                {

                    txt.push(c);
                }
                else if (c == ')')
                {

                    if (txt.isEmpty() || txt.peek() != '(')
                    {

                        return false;


                    }
                    else if (txt.peek() == '(')
                    {
                        txt.pop();
                    }
                }
                else if (c == ']')
                {

                    if (txt.isEmpty() || txt.peek() != '[')
                    {

                        return false;


                    }
                    else if (txt.peek() == '[')
                    {
                        txt.pop();
                    }
                }
                else if (c == '}')
                {

                    if (txt.isEmpty() || txt.peek() != '{')
                    {

                        return false;


                    }
                    else if (txt.peek() == '{')
                    {
                        txt.pop();
                    }
                }

            }


            return txt.isEmpty();



        }




        public void reverse()
        {


            String text = "Ana are mere";


            Stack<char> stack = new Stack<char>();

            foreach (char c in text)
            {
                stack.push(c);
            }

            String newText = "";

            while (stack.isEmpty() == false)
            {
                newText += stack.pop();
            }

            Console.WriteLine(newText);

        }
    }
}