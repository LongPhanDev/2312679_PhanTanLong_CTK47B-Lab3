using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Student_Management
{
    public class JsonStudentStorage :IStudentStorage
    {
        public List<Student> ReadFromFile(string filepath)
        {
            if (!File.Exists(filepath))
            {
                return new List<Student>();
            }
            var json = File.ReadAllText(filepath);
            return JsonConvert.DeserializeObject<List<Student>>(json) ?? new List<Student>();
        }
        public void WriteToFile(string filepath, List<Student> students)
        {
            var json = JsonConvert.SerializeObject(students, Formatting.Indented);
            File.WriteAllText(filepath, json);
        }
    }
}
