# Extensions to the .NET framework

Brings ruby style string formatting to .NET

    "Hello {Name}".Extensions().Format(new {Name="World"}); // => Hello World

You can easily bind to the properties of the current object using this:

    public class Person
    {        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        
        public string Name { get; private set; }
        
        public int Age { get; private set; }
                
        public override string ToString()
        {
            return "{Name} is {Age} years old.".Extensions().Format(this);
        }        
    }
    
Formatting output:
    
    var bob = new Person("Bob", 22);
    
    bob.ToString(); // => Bob is 22 years old.
    "{Age} years ago {Name} was born.".Extensions().Format(bob); // => 22 years ago Bob was born.