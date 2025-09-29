using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    public class TextStudentStorage : IStudentStorage   
    {
        public List<Student> ReadFromFile(string filePath)
        {
            var list = new List<Student>();
            if (!File.Exists(filePath))
                return list;

            foreach (var line in File.ReadAllLines(filePath))
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var sv = Student.Parse(line);
                if (sv != null)
                    list.Add(sv);
            }
            return list;
        }

        public void WriteToFile(string filePath, List<Student> students)
        {
            using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                foreach (var sv in students)
                {
                    writer.WriteLine(sv.ToString());
                }
            }
        }
    }
}
