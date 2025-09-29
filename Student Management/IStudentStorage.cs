using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    public interface  IStudentStorage
    {
        List<Student> ReadFromFile(string filename);
        void WriteToFile(string filename, List<Student> list);
    }
}
