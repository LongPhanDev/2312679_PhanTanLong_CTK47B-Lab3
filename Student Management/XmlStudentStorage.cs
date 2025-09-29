using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Student_Management
{
    public class XmlStudentStorage : IStudentStorage
    {
        public List<Student> ReadFromFile(string filepath)
        {
            if (!File.Exists(filepath))
            {
                return new List<Student>();
            }
            var xml_serializer = new XmlSerializer(typeof(List<Student>));
            using (var stream = new FileStream(filepath, FileMode.Open))
            {
                return (List<Student>)xml_serializer.Deserialize(stream);
            }

        }
        public void WriteToFile(string filePath, List<Student> students)
        {
            var xml_serializer = new XmlSerializer(typeof(List<Student>));
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                xml_serializer.Serialize(stream, students);
            }
        }
    }
}
