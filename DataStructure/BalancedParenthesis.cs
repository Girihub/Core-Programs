﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using DataStructure.Utility;

namespace DataStructure
{
    public class BalancedParenthesis
    {
        public static void BalancedParenthesisFunction()
        {
            try
            {
                Stack stack = new Stack();
                Console.WriteLine("Enter arithmatic expression");
                string expression = Console.ReadLine();
                while (!Regex.IsMatch(expression, @"^[0-9-+/*)(]+$"))
                {
                    Console.WriteLine("Enter valid arithmatic expression");
                    expression = Console.ReadLine();
                }
                for(int i = 0; i < expression.Length; i++)
                {
                    if (expression[i]+"" == "(")
                    {
                        stack.push("(");
                    }
                    if (expression[i] + "" == ")")
                    {
                        stack.pop();
                    }
                }
                if (stack.IsEmpty())
                {
                    Console.WriteLine("Arithmatic expression is balanced");
                }
                else
                {
                    Console.WriteLine("Arithmatic expression is not balanced");
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}