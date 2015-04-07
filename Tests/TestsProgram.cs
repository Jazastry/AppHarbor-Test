using Chat.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tests
{
    class TestsProgram
    {
        static void Main(string[] args)
        {
            //var client = new MongoClient("mongodb://localhost");
            //var server = client.GetServer();
            //var db = server.GetDatabase("Chat");
            //var mongoMessages = db.GetCollection<Message>("messages");
            //var mongoUsers = db.GetCollection<Message>("users");

            //mongoMessages.Drop();
            //mongoUsers.Drop();

            //DateTime time = DateTime.Now;

            //User us1 = new User() { UserName = "Ivo" };
            //User us2 = new User() { UserName = "Bobo" };
            //User us3 = new User() { UserName = "Joro" };

            //mongoUsers.Insert(us1);
            //mongoUsers.Insert(us2);
            //mongoUsers.Insert(us3);

            //var ids = mongoUsers.AsQueryable<User>().Select(u => u.Id).ToList();

            //Message mes1 = new Message() { MessageText = "Message 1", Time = DateTime.Now, UserId = ids[0].ToString() };
            //Message mes2 = new Message() { MessageText = "Message 2", Time = DateTime.Now, UserId = ids[1].ToString() };
            //Message mes3 = new Message() { MessageText = "Message 3", Time = time, UserId = ids[2].ToString() };

            //mongoMessages.Insert(mes1);
            //mongoMessages.Insert(mes2);
            //mongoMessages.Insert(mes3);

            //var resTime = collection.AsQueryable<Message>().Where(m => m.Time.Equals(time)).Select(m => new { Time = m.Time, Name = m.MessageText }).ToList().ToJson();
            //var resUseId = mongoMessages.AsQueryable<Message>().Where(m => m.UserId == ids[0].ToString()).Select(m => m.MessageText).ToList().ToJson();
            //Console.WriteLine(resUseId);
        }
    }
}
