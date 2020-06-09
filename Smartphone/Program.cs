using System;
using System.Collections.Generic;

namespace Smartphone
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone samsung = new Smartphone();
            List<App> list = new List<App>();
            bool wantsToUseSmartphone = true;

            App toDoApp = new App(2, 1.2m, "To Do Control");
            App whatsApp = new App(5, 3.2m, "Whats App");
            App word = new App(1, 4.0m, "Word");
            Game superMario = new Game("Super Mario", 2.0m, true, 8, 2.0m);
            Game bestGameEver = new Game("Best Game Ever", 3.5m, false, 10, 2.5m);
            Game snake = new Game("Snake", 0.0m, true, 5, 0.5m);
            samsung.Add(toDoApp);
            samsung.Add(word);
            samsung.Add(whatsApp);
            samsung.Add(superMario);
            samsung.Add(bestGameEver);
            samsung.Add(snake);

            while (wantsToUseSmartphone) {
                bool isInputValid = false;
                Console.WriteLine("Wählen Sie \"Apps\" oder \"Games\" aus:");
                string input = Console.ReadLine();
                input = input.ToLower();
                if (input.Equals("apps"))
                {
                    list = samsung.search<App>();
                    ShowList(list);
                    isInputValid = true;
                }
                else if (input.Equals("games"))
                {
                    list = samsung.search<Game>();
                    ShowList(list);
                    isInputValid = true;
                }
                else if (input.Equals("x"))
                {
                    wantsToUseSmartphone = false;
                }
                else
                {
                    Console.WriteLine("Halten Sie sich bitte an die Auswahlmöglichkeiten.");
                }
                if (isInputValid)
                {
                    Console.WriteLine("Mit \"Start:Name\" starten Sie die App oder das Spiel.");
                    input = Console.ReadLine();
                    var appList = samsung.ControlInput(input);
                    if(appList != null)
                    {
                        appList[0].Start();
                    } 
                }
                
            }
        }
        public static void ShowList(List<App> List)
        {
            for(int i = 0; i < List.Count; i++)
            {
                Console.WriteLine(List[i].Name);
            }
            Console.WriteLine("");
        }
    }
}
