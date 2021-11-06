using System;
using System.Collections.Generic;

var employees = new List<(string, int)> 
{
    ("John Doe"),
    ("Adam Novak"),
    ("Robin Brown"),
    ("Rowan Cruise"),
    ("Joe Draker"),
    ("Janet Doe"),
    ("Lucy Smith"),
    ("Thomas Moore")
};

employees.Sort(new SurnameComparer());
employees.ForEach(employee => Console.WriteLine(employee));

class SurnameComparer : IComparer<(string, int)> 
{
    public int Compare((string, int) e1, (string, int) e2)
    {
        return  e1.Item1.Split()[1].CompareTo(e2.Item1.Split()[1]);
    }
}