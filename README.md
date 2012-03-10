# Extensions to the .NET framework

## String Extensions
Simple string formatting for .NET

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

## Integer Extensions
Simple enumeration for .NET
    3.Extensions().Times(DoSomething); // => DoSomething(); DoSomething(); DoSomething();
    3.Extensions().Times(DoSomethingWithIndex); // => DoSomethingWithIndex(0); DoSomethingWithIndex(1); DoSomethingWithIndex(2); 
