using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.App1
{
    internal class UserCreator
    {
        public List<string> load_data(Reader reader, string file_path)
        {
            return reader.read_data(file_path);
             
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
