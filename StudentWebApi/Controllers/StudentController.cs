using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Student> studentList = null;
        void InitializeStudentList()
        {
            if (studentList == null)
            {
                studentList = new List<Student>()
                 {
               new Student() { StudentId=1, Name="Ajay" , Batch="B001", Marks=89, DateOfBirth=Convert.ToDateTime("12/12/2020")},
               new Student() { StudentId=2, Name="Deepak" , Batch="B002", Marks=78, DateOfBirth=Convert.ToDateTime("10/06/2020")},

                 };
            }

        }
        public StudentController()
        {
            if (studentList == null)
                InitializeStudentList();
        }

        // Get Method 


        public List<Student> Get()
        {
            return studentList;
        }

        [HttpGet]
        [Route("{id:int}")]
        public Student Get(int id)
        {
            return studentList.FirstOrDefault(x => x.StudentId == id);
        }

        [HttpPost]
        public void Post(Student student)
        {
            studentList.Add(student);
        }

        [HttpPut]
        [Route("{id:int}")]
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
        [HttpDelete]
        [Route("{id:int}")]
        public void Delete(int id)
        {
            Student temp = studentList.FirstOrDefault(x => x.StudentId == id);
            if (temp != null)
            {
                studentList.Remove(temp);
            }


        }
    }
}