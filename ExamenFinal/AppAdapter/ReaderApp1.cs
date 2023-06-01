using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.AppAdapter
{
    internal class ReaderApp1:IUserCreator
    {
        public List<string> load_data( string file_path)
        {
            try
            {

                using (StreamReader reader = new StreamReader(file_path))
                {
                    string line;
                    string cadena = "";

                    while ((line = reader.ReadLine()) != null)
                    {
                        cadena = cadena + ";" + line;
                    }
                    string[] users_array = cadena.Split(";");
                    List<string> users_list = new List<string>(users_array);
                    return users_list.GetRange(1, users_list.Count - 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new List<string>();
            }

        }
        public List<User> create_users(List<string> user_data)
        {
            int i = 0;
            List<User> users = new List<User>();
            foreach (string info_user in user_data)
            {
                i += 1;
                string[] linea = info_user.Split(",");
                string username = linea[0];
                string password = linea[1];
                string id = linea[2];
                User user = new User(Int16.Parse(id), username, password);
                users.Add(user);
        }
            return users;
        }    
    }
}
