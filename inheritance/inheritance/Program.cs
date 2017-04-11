using System;


public class parentclass
{
    public parentclass()
    {
        Console.WriteLine("parentclass called");
    }
}
public class derivedclass : parentclass
{
    public derivedclass()
    {
        Console.WriteLine("derived class called");
    }
}
public class inheri
{
    public class program
    {
        public static void Main()
        {
            derivedclass dc = new derivedclass();
        }
    }
}
