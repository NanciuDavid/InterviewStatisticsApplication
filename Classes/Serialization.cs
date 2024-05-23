using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace PROIECTWAP.Classes
{
    public static class Serialization
    {
        private static readonly string BinaryFilePath = "people.dat";
        private static readonly string XmlFilePath = "people.xml";

        public static void SerializeBinary(List<Person> people)
        {
            using (FileStream fs = new FileStream(BinaryFilePath, FileMode.Create))
            {
                var formatter = new DataContractSerializer(typeof(List<Person>));
                formatter.WriteObject(fs, people);
            }
        }

        public static List<Person> DeserializeBinary()
        {
            if (!File.Exists(BinaryFilePath))
                return new List<Person>();

            using (FileStream fs = new FileStream(BinaryFilePath, FileMode.Open))
            {
                var formatter = new DataContractSerializer(typeof(List<Person>));
                return (List<Person>)formatter.ReadObject(fs);
            }
        }

        public static void SerializeXML(List<Person> people)
        {
            using (FileStream fs = new FileStream(XmlFilePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
                serializer.Serialize(fs, people);
            }
        }

        public static List<Person> DeserializeXML()
        {
            if (!File.Exists(XmlFilePath))
                return new List<Person>();

            // Check if the file is not empty
            FileInfo fileInfo = new FileInfo(XmlFilePath);
            if (fileInfo.Length == 0)
                return new List<Person>();

            using (FileStream fs = new FileStream(XmlFilePath, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
                return (List<Person>)serializer.Deserialize(fs);
            }
        }
    }
}
