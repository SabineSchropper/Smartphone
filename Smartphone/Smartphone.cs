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

        public void Add(App app)
        {
            Apps.Add(app);
        }

        public List<App> searchApps()
        {
            //x is App
            /*var list = Apps.Where(x => x.GetType().Equals(typeof(App))).ToList();
            return list;*/

            return FilterList(typeof(App));
        }
        public List<App> searchGames()
        {
            return FilterList(typeof(Game));
        }
        private List<App> FilterList(Type type)
        {
            return Apps.Where(x => x.GetType().Equals(type)).ToList();
        }
        /// <summary>
        /// if i use this generic Method, then I don't need to use two Methods searchApps() and searchGames()
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<App> search<T>() where T : App
        {
            return Apps.Where(x => x.GetType().Equals(typeof(T))).ToList();
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
