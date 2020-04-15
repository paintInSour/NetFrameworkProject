﻿using lab2.Engine.Model;
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
    public class CarRepository
    {
        private static string filename = "carList.txt";


        public static void writeFile(Dictionary<string, Car> carList)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            formatter.Serialize(stream, carList);
            stream.Close();
        }
        public static Dictionary<string, Car> readFile()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            try
            {
                Dictionary<string, Car> list = (Dictionary<string, Car>)formatter.Deserialize(stream);
                stream.Close();
                return list;
            }
            catch
            {
                stream.Close();
                return new Dictionary<string, Car>();
            }
            //   return new Dictionary<string, Car>();
        }
    }
}
