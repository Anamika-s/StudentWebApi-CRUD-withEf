using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]troller : ControllerBase
    public class StudentsCon
    {
        List<Student> list = null;
        void InitializeStudentsList()
        {
            list = new List<Student>()
            {
                 new Student() { Id=1, Name="Ajay", Batch="C#", Marks=90},

                 new Student() { Id=2, Name="Vijay", Batch="C", Marks=90}
            };
        }
        public StudentsController()
        {
            if(list==null)
            {
                InitializeStudentsList();
            }

        }

      // Web Api works on HTTP verbs
      // Get , Post , Put , Delete

        [HttpGet]
        public List<Student> Get()
        {
            return list;
        }

        [HttpGet]
        [Route("{id:int}")]
        public Student Get(int id)
        {
            return list.FirstOrDefault(x => x.Id == id);
        }
    }
}
