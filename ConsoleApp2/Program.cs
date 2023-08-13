namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------- Hello to your Todo list -------------");
            List<string> tasks = new List<string>();
            string action = "";
            while (action != "exit")
            {
                Console.WriteLine("Tapez 1 Pour consulter vos task");
                Console.WriteLine("Tapez 2 Pour ajouter une task");
                Console.WriteLine("Tapez 3 Pour cocher une task");
                Console.WriteLine("Tapez 4 Pour supprimer toutes les taches");
                Console.WriteLine("Tapez clear supprimer la console");
                Console.WriteLine("Tapez exit pour fermer ta todoliste");
                Console.WriteLine("");
                action = Console.ReadLine();
                if (action == "1")
                {
                    if (tasks.Count > 0)
                    {
                        int i = 1;
                        foreach (var task in tasks)
                        {
                            Console.WriteLine(i + " => " + task);
                            i++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your Todo liste is empty");
                    }
                }
                else if (action == "2")
                {
                    Console.WriteLine("Tapez votre task");
                    string newTask = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newTask))
                    {
                        tasks.Add(newTask);
                    }
                }
                else if (action == "3")
                {
                    Console.WriteLine("Tapez l'ordre de la task que vous voulez delete");
                    string orderTask = Console.ReadLine();
                    try
                    {
                        int order = int.Parse(orderTask);
                        tasks.RemoveAt(order - 1);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("erreur");
                    }

                }
                else if (action == "4")
                {
                    tasks.Clear();
                }
                else if (action == "clear")
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("J'ai pas compris");
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }
    }
}