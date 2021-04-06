using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Repositories;
using Library.Data.Models;

namespace Library.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            MessageRepository messageRepository = new MessageRepository();
            var list = messageRepository.Tlist();
            return View(list);
        }
        public IActionResult Delete(int id)
        {
            MessageRepository messageRepository = new MessageRepository();
            var x = messageRepository.TGet(id);
            messageRepository.TRemove(x);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            MessageRepository messageRepository = new MessageRepository();
            var xlist = messageRepository.TGet(id);
            return View(xlist);
        }
        [HttpPost]
        public IActionResult Update(Message p)
        {
            MessageRepository messageRepository = new MessageRepository();
            var x = messageRepository.TGet(p.MessageId);
            x.Name = p.Name;
            x.Email = p.Email;
            x.Status = p.Status;
            x.YourMessage = p.YourMessage;
            messageRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            MessageRepository messageRepository = new MessageRepository();
            var xlist = messageRepository.TGet(id);
            return View(xlist);
        }
    }
}
