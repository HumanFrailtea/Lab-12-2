using System;

namespace Lab_12
{
    using System;

    class GFG
    {


        static public void my_add(string str1, string str2,
                             string str3 = "GeeksforGeeks")
        {
            Console.WriteLine(str1 + str2 + str3);
        }

        static public void Main()
        {
            my_add("Welcome", "to");
            my_add("This", "is", "C# Tutorial");
        }
    }
}
