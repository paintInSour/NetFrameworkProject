using lab2.Engine.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Engine.Repository
{
    public class OrderRepository
    {
        private static string filename = "orderList.txt";


        public static void writeFile(Dictionary<string, Order> carList)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            formatter.Serialize(stream, carList);
            stream.Close();
        }
        public static Dictionary<string, Order> readFile()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            try
            {
                Dictionary<string, Order> list = (Dictionary<string, Order>)formatter.Deserialize(stream);
                stream.Close();
                return list;
            }
            catch
            {
                stream.Close();
                return new Dictionary<string, Order>();
            }
        }
    }
}
