﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNew
{
    class ReverseTheString
    {

        static void Main()
        {
            reverse();
        }
        static void reverse()
        {
            Console.WriteLine("Enter Your Sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }
        }

    }

}


