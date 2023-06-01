using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.App2
{
    internal class MatchReader
    {

        public List<string> read_file(string file_path)
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

        public void filter_data(string raw_data)
        {

        }
        
        public List<User> create_people(List<string> raw_data)
        {
            int i = 0;
            List<User> users = new List<User>();
            Dictionary<string, string> diccionario_id_username = new Dictionary<string, string>();
            foreach (string info_user in raw_data)
            {
                string[] linea = info_user.Split(",");
                string username_or_password = linea[0];
                string id = linea[1];
                if (diccionario_id_username.ContainsKey(id)) 
                {
                    User user = new User(Int16.Parse(id), diccionario_id_username[id], username_or_password);
                    users.Add(user);
                }
                else
                {
                    diccionario_id_username.Add(id, username_or_password);
                }
            }
            return users;
        }
    }
}
