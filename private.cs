class Example
{
    public int secretValue = 42;

    private void ShowSecret1()
    {
        Console.WriteLine("Secret value is: " + secretValue);
    }

    public void ShowSecret2()
    {
        Console.WriteLine("Secret value is: " + secretValue);
    }
}

// public static void Main(string[] args)
// {
//     Example example = new Example();
//     example.ShowSecret2();
// }
