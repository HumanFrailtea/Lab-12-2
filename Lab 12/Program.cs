/// Homework No.__ Exercise No.__
/// File Name:     Lab 12-2.sln
/// @author:       Upendra Samaranayake
/// Date:          November 9, 2020
///
/// Problem Statement: Write a program that uses optional parameters, named parameter and variable number of parameters.
///   
using System;

namespace Lab_12
{
    using System;

    class GFG
    {


        static public void my_add(string str1, string str2,
                             string str3 = "Lab work")
        {
            Console.WriteLine(str1 + str2 + str3);
        }

        static public void Main()
        {
            my_add("Welcome", "to");
            my_add("This", "is", "Sparta!");
        }
    }
}
