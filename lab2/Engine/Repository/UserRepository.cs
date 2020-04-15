using netFrameworkProject.Engine.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace netFrameworkProject.Engine.Repository
{
    class UserRepository
    {
        private static string filename = "userList.txt";


        public static void writeFile(Dictionary<string, IAuthorizedUser> carList)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            formatter.Serialize(stream, carList);
            stream.Close();
        }
        public static Dictionary<string, IAuthorizedUser> readFile()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            try
            {
                Dictionary<string, IAuthorizedUser> list = (Dictionary<string, IAuthorizedUser>)formatter.Deserialize(stream);
                stream.Close();
                return list;
            }
            catch
            {
                stream.Close();
                return new Dictionary<string, IAuthorizedUser>();
            }
        }
    }
}
