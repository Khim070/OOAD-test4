class Parent
{
    protected int age = 50;
}

class Child : Parent
{
    public void ShowAge()
    {
        Console.WriteLine("Parent's age is: " + age);
    }
}

// public static void Main(string[] args)
// {
//     Child child = new Child();
//     child.ShowAge();
// }