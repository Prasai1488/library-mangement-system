using System;
using System.Collections.Generic;


// Abstract class representing a Person in the system (Member or Staff)
public abstract class Person
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Person(string name, int id)
    {
        this.Name = name;
        this.Id = id;
    }

    public abstract void DisplayInfo();
}