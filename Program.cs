using GestionCom;

class Program
{
    static void Main(string[] args)
    {

        Categorie cat1 = new Categorie("SAL", "salariés");
        Categorie cat2 = new Categorie("SAL", "salariés");

        Commercial commercial1 = new Commercial("Souhil", "Idriss", 2005, cat1);
        Commercial commercial2 = new Commercial("Simonin", "Cedrik", 2006, cat2);
        Commercial commercial3 = new Commercial("Yasmine", "El harim", 2004, cat1);
        Console.WriteLine("Voici les infos du commercial : \n"+"\n"+commercial1+"----------------------------\n"+commercial2+"----------------------------\n"+commercial3);
        commercial1.compare(commercial2);

        
    }
}