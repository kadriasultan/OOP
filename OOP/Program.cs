using System;
using System.Linq.Expressions;

class person
{
    public string _name;
    public int _age;
    public string _email;


    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Neme cannot be empty or null");
            }
            _name = value;
        }
    }


    public int age
    {
        get { return age; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentNullException("age must be greater than 0.");
            }
            age = value;
        }
    }

    public person(string name, int age, string email)
    {
        name = name;
        age = age;
        email = email;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"name:{Name}");
        Console.WriteLine($"age: {age}");
        Console.WriteLine($"email:{_email}");
    }
    class program
    {
        static void Main(string[] args)
        {
            person person = new person("Hala",7,"Hala@gmail.com");
            person.PrintInfo();
        }
     
    }
}
