using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Traveller
{
    static class Extensions
    {
        public static bool SerializeToFile<T>(this T value, string FilePath)
        {
            try
            {
                if (value == null) return false;

                var xmlSerializer = new XmlSerializer(typeof(T));

                using (var stringWriter = new StringWriter())
                {
                    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
                    {
                        xmlSerializer.Serialize(xmlWriter, value);
                        File.WriteAllText(FilePath, stringWriter.ToString());
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static T DeserializeFromFile<T>(this T value, string FilePath)
        {
            try
            {
                var xmlSerializer = new XmlSerializer(typeof(T));
                T result;

                using (TextReader reader = new StringReader(File.ReadAllText(FilePath)))
                {
                    result = (T)xmlSerializer.Deserialize((reader));
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
