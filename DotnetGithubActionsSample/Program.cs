// See https://aka.ms/new-console-template for more information


public class Program
{
  public static void Main(string[] args)
  { 
    var p = new Person();
    p.Age = 20;
    p.Name = "TestUser";
    Console.WriteLine($"{p.Name} ({p.Age})");
  }
}
