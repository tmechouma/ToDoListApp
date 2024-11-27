using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    class Program
    {
        // Liste globale pour stocker les tâches
        static List<Task> tasks = new List<Task>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== Gestion de Tâches =====");
                Console.WriteLine("1. Ajouter une tâche");
                Console.WriteLine("2. Afficher les tâches");
                Console.WriteLine("3. Marquer une tâche comme terminée");
                Console.WriteLine("4. Supprimer une tâche");
                Console.WriteLine("5. Modifier une tâche");
                Console.WriteLine("6. Sauvegarder les tâches");
                Console.WriteLine("7. Charger les tâches");
                Console.WriteLine("8. Quitter");
                Console.Write("Choisissez une option : ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                       case "1":
                       // Fonctionalité 1 : tâchesAddTask();
                        break;
                    case "2":
                       // Fonctionalité 2 : DisplayTasks();
                        break;
                    case "3":
                       // Fonctionalité 3 : CompleteTask();
                        break;
                    case "4":
                       // Fonctionalité 4 : DeleteTask();
                        break;
                    case "5":
                       // Fonctionalité 5 : EditTask();
                        break;
                    case "6":
                       // Fonctionalité 6 : SaveTasksToFile();
                        break;
                    case "7":
                       // Fonctionalité 7 : LoadTasksFromFile();
                        break;
                    case "8":
                        Console.WriteLine("Au revoir !");
                        return;
                    default:
                        Console.WriteLine("Option invalide. Appuyez sur Entrée pour réessayer.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        // Fonctionnalité 1 : Ajouter une tâche





    }

    // Classe de base pour une tâche
    class Task
    {
        public string Name { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string name)
        {
            Name = name;
            IsCompleted = false;
        }
    }
}