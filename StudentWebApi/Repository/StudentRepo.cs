using StudentWebApi.IRepository;
using StudentWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebApi.Repository
{
    public class StudentRepo : IStudentRepo
    {
        List<Student> studentList = null;
        public void Delete(int id)
        {

            Student temp = studentList.FirstOrDefault(x => x.StudentId == id);
            if (temp != null)
            {
                studentList.Remove(temp);
            }
        }

        public List<Student> Get()
        {
            return studentList;
        }

        public Student Get(int id)
        {
            return studentList.FirstOrDefault(x => x.StudentId == id);
        }

        public void Post(Student student)
        {
            studentList.Add(student);

        }

        public void Put(int id, Student student)
        {
            Student temp = studentList.FirstOrDefault(x => x.StudentId == id);
            if (temp != null)
            {
                foreach (Student obj in studentList)
                {
                    if (obj.StudentId == id)
                    {
                        obj.Batch = student.Batch;
                        obj.Marks = student.Marks;
                    }
                }
            }
        }
    }
}
