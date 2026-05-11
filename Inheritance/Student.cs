using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inheritance;


public class Student : Person
{
    int _yearGroup;
    public Student(string fn, string ln, DateTime dob, int yearGroup)
        : base(fn, ln, dob)
    {
        _yearGroup = yearGroup;
    }

    public Student(string fn, string ln, DateTime dob)
        : base(fn, ln, dob)
    {
        _yearGroup = (Age() < 5) ? 0 : Age() - 4;
    }

    public Student(string fn, string ln, string email, DateTime dob)
        : base(fn, ln, email, dob)
    {
        _yearGroup = (Age() < 5) ? 0 : Age() - 4;

    }

    public new string UserName => base.UserName + "-" + _yearGroup.ToString();
}