using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Smartphone
{
    class Smartphone
    {
       public List<App> Apps = new List<App>();

       public Smartphone()
        {
            App toDoApp = new App(2,1.2m,"To Do Control");
            App whatsApp = new App(5, 3.2m, "Whats App");
            App word = new App(1, 4.0m, "Word");
            Game superMario = new Game("Super Mario", 2.0m, true, 8, 2.0m);
            Game bestGameEver = new Game("Best Game Ever", 3.5m, false, 10, 2.5m);
            Game snake = new Game("Snake", 0.0m, true, 5, 0.5m);
            Apps.Add(toDoApp);
            Apps.Add(word);
            Apps.Add(whatsApp);
            Apps.Add(superMario);
            Apps.Add(bestGameEver);
            Apps.Add(snake);
            
        }

        public List<App> searchApps()
        {
            var list = Apps.Where(x => x.GetType().Equals(typeof(App))).ToList();
            return list;
        }
        public List<App> searchGames()
        {
            var list = Apps.Where(x => x.GetType().Equals(typeof(Game))).ToList();
            return list;
        }
        public List<App> ControlInput(string input)
        {
            List<App> list = null;
            string[] stringArray = input.Split(":");
            stringArray[0] = stringArray[0].ToLower().Trim();
            if (stringArray[0].Equals("start"))
            {
                string appToSearch = stringArray[1];
                appToSearch = appToSearch.Trim();
                list = Apps.Where(x => x.Name.Contains(appToSearch, StringComparison.OrdinalIgnoreCase)).ToList();
            }
           
            return list;
        }
    }
}
