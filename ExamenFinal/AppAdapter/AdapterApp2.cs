using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.AppAdapter
{
    internal class AdapterApp2 : IUserCreator
    {
        private MatchReader matchReader;

        public AdapterApp2(MatchReader mr) 
        { 
            this.matchReader = mr;
        }

        public List<User> create_users(List<string> list_info_users)
        {
            return matchReader.create_people(list_info_users);
        }

        public List<string> load_data(string path)
        {
            return matchReader.read_file(path);
        }
    }
}
