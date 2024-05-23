using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace PROIECTWAP.Classes
{
    public static class Serialization
    {
        public static void SerializeBinary<T>(List<T> data, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                var formatter = new DataContractSerializer(typeof(List<T>));
                formatter.WriteObject(fs, data);
            }
        }

        public static List<T> DeserializeBinary<T>(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<T>();

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                var formatter = new DataContractSerializer(typeof(List<T>));
                return (List<T>)formatter.ReadObject(fs);
            }
        }

        public static void SerializeXML<T>(List<T> data, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                serializer.Serialize(fs, data);
            }
        }

        public static List<T> DeserializeXML<T>(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<T>();

            // Check if the file is not empty
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Length == 0)
                return new List<T>();

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                return (List<T>)serializer.Deserialize(fs);
            }
        }
    }
}
