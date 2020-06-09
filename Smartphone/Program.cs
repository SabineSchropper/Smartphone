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
            

            while (wantsToUseSmartphone) {
                bool isInputValid = false;
                Console.WriteLine("Wählen Sie \"Apps\" oder \"Games\" aus:");
                string input = Console.ReadLine();
                input = input.ToLower();
                if (input.Equals("apps"))
                {
                    list = samsung.searchApps();
                    ShowList(list);
                    isInputValid = true;
                }
                else if (input.Equals("games"))
                {
                    list = samsung.searchGames();
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
