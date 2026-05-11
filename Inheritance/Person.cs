namespace Inheritance;

public class Person
{
    string _firstName;
    string _lastName;

    string _emailAddress;
    DateTime _dateOfBirth;

    public Person(string fn, string ln, string email, DateTime dob)
    {
        _firstName = fn;
        _lastName = ln;
        _emailAddress = email;
        _dateOfBirth = dob;
    }

    public Person(string fn, string ln, DateTime dob) : this(fn, ln, "", dob) {}

    public string FirstName => _firstName ?? "";
    public string LastName => _lastName ?? "";
    public string EmailAddress => _emailAddress ?? "";
    public DateTime DateOfBirth => _dateOfBirth;

    public bool ValidDOB => _dateOfBirth.CompareTo(new DateTime(1900,1,1)) > 0 && _dateOfBirth.CompareTo(DateTime.Today) < 0;
    public bool IsAdult => Age() >= 18;
    public bool IsBirthday => _dateOfBirth.Day == DateTime.Today.Day && _dateOfBirth.Month == DateTime.Today.Month;
    public string UserName =>
        _firstName.First().ToString().ToLower()
        + _lastName.ToLower()
        + _dateOfBirth.ToString("ddMMyy");

    public int Age()
    {
        DateTime today = DateTime.Today;

        int age = today.Date.Year - _dateOfBirth.Date.Year;

        if (_dateOfBirth.Date > today.Date.AddYears(-age)) age--;

        return age;
    }

}
