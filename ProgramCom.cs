using GestionCom;

class Program
{
    static void Main(string[] args)
    {
        Commercial commercial1 = new Commercial("Idriss", "Souhil", 2005);
        Commercial commercial2 = new Commercial("Cedrik", "Simonin", 2005);
        Console.WriteLine(commercial1);
        Console.WriteLine("nom"+commercial1.Nom+);
    }
}