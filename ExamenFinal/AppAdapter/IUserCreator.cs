using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.AppAdapter
{
    internal interface IUserCreator
    {
        public List<string> load_data(string path);
        public List<User> create_users(List<string> list_info_users);
    }
}
