class Internal
{
    internal string name = "Vakhim";
}
class Internal2
{
    internal string sex = "male";
    internal void Sex()
    {
        Internal example = new Internal();
        Console.WriteLine($"{example.name} is a {sex}");
    }
}
// public static void Main(string[] args)
// {
//     Internal2 internal2 = new Internal2();
//     internal2.Sex();
// }
