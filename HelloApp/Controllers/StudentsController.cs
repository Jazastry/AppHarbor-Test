using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloApp.Models;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using System.Configuration;

namespace HelloApp.Controllers
{
    public class StudentsController : ApiController
    {
        private static string mongoString = ConfigurationManager.AppSettings.Get("MONGOLAB_URI");
        //private static string mongoString = "mongodb://localhost"; // mongodb://appharbor_593207f5-794f-4cd5-aeca-045582055f4d:8n3c5lemofr3cea0qs23cj5uk3@ds037581.mongolab.com:37581/appharbor_593207f5-794f-4cd5-aeca-045582055f4d
        private static MongoUrl url = new MongoUrl(mongoString);
        private static MongoClient client = new MongoClient(url);
        private static MongoServer server = client.GetServer();
        private static MongoDatabase database = server.GetDatabase(url.DatabaseName); //url.DatabaseName
        private MongoCollection<StudentDataModel> students = database.GetCollection<StudentDataModel>("students");

        [HttpGet]
        public IHttpActionResult GetStudents()
        {
            var studentsJson = students.AsQueryable<StudentDataModel>().ToList().ToJson();
            return this.Ok(studentsJson);
        }
        [HttpPost]
        public IHttpActionResult PostStudents(string name, string birthDay)
        {
            try
            {
                StudentDataModel newStudent = new StudentDataModel() { Id = new ObjectId(), Name = name, BirthDay = birthDay };
                this.students.Save(newStudent);
                return this.Ok(name + " " + birthDay);
            }
            catch (Exception)
            {
                return this.InternalServerError(new InvalidCastException());
            }            
        }
    }
}
