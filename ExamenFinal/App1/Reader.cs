namespace ExamenFinal.App1
{
    public class Reader
    {
        public List<string> read_data(string file_path)
        {
            try
            {

                using (StreamReader reader = new StreamReader(file_path))
                {
                    string line;
                    string cadena = "";

                    while ((line = reader.ReadLine()) != null)
                    {
                        cadena = cadena + ";" + line ;
                    }
                    string[] users_array = cadena.Split(";");
                    List<string> users_list = new List<string>(users_array);
                    return users_list.GetRange(1, users_list.Count -1);
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
                return new List<string>();
            }

        } 

        public void process_data(string raw_data)
        {
            string[] linea = raw_data.Split(",");
            string username = linea[0];
            string password = linea[1];
            string id = linea[2];
            User user = new User(Int16.Parse(id), username, password);
        }
    }
}