using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dapper_Project.Controllers
{
    public class QA : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReadQuestions()
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            List<Questions> QS = Questions.Read();
            return View(QS);
        }

        public IActionResult AskQuestion()
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            return View();
        }

        public IActionResult AddQuestion(string username, string title, string detail, string category, string tags)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            Questions.Create(username, title, detail, category, tags);

            return RedirectToAction("ReadQuestions", "QA");
            //return Content($"{tags}");
        }

        public IActionResult EditQuestion(long id)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            Questions questions = Questions.Read(id);


            return View(questions);
        }

        public IActionResult UpdateQuestion(int id, string username, string title, string detail, string category, string tags)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            ViewBag.Message = "Your entry has been saved.";
            Questions.Update(id, username, title, detail, category, tags);
            return RedirectToAction("ReadQuestions", "QA");
        }

        public IActionResult RemoveQuestion(int id)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            Thread t = Thread.AssembleThread(id);
            Thread.DeleteThread(t);

            return RedirectToAction("ReadQuestions", "QA");
        }

        public IActionResult RemoveAnswer(int thisID)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            Answers a = Answers.Read(thisID);
            
            int qid = a.QuestionID;
            Answers.Delete(thisID);
            

            return RedirectToAction("ReadAnswers", "QA", new { id = qid});

        }

        public IActionResult ReadAnswers(int id)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            Thread t = new Thread();
            t.A = Answers.ReadAll(id);
            t.Q = Questions.Read(id);
            
            return View(t);
        }

        public IActionResult PostAnswer(string username, string detail, int questionID)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            ViewBag.Message = "Your Answer has been posted.";
            Answers.Create(username, detail, questionID);
            Thread t = Thread.AssembleThread(questionID);
            return View("ReadAnswers", t);

        }

        public IActionResult WriteAnswer(int id)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            Thread t = Thread.AssembleThread(id);
            return View("PostAnswer", t);
        }


        /*
         //Prints comments in comments thread. 
            Same user should be able to add multiple answers to the same question
         
        public IActionResult ReadAnswers(long id)
        {
            List<Answers> answers = Answers.Read();
            return View(answers);

        }
        */
    }
}
