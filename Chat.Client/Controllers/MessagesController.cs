using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Chat.Data.Repositories;
using Chat.Data;
using Chat.Model;
using System.Data.Entity;
using Microsoft.AspNet.Identity;

namespace Chat.Client.Controllers
{
    [Authorize]
    public class MessagesController : BaseController
    {

        public MessagesController()
            : this (new ChatData(new ChatDbContext()))
        {            

        }

        public MessagesController(IChatData data)
            : base (data)
        {

        }


        // GET api/values
        public IEnumerable<string> Get()
        {
            return this.Data.Messages.All().Select(m => m.MessageText).ToList();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public IHttpActionResult Post([FromUri]string text)
        {
            var currentUserId = this.User.Identity.GetUserId();
            if (currentUserId == null)
            {
                return this.BadRequest("Not logged please logg in !");
            }

            Message newMessage = new Message()
            {
                MessageText = text,
                Time = DateTime.Now,
                UserId = currentUserId,
                GroupId = 1
            };

            this.Data.Messages.Add(newMessage);
            this.Data.SaveChanges();
            return Ok();
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
