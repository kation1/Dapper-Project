using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            //ViewBag.SaveMessage = "Your entry has been saved.";
            //ViewBag.DeleteMessage = "Your entry has been Deleted.";
            List<Questions> QS = Questions.Read();
            return View(QS);
        }


        [HttpGet]
        public IActionResult AskQuestion()
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            return View();
        }


        [HttpPost]
        public IActionResult AddQuestion(string username, string title, string detail, string category, string tags)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            ViewBag.SaveMessage = "Your entry has been saved.";
            Questions.Create(username, title, detail, category, tags);
            return RedirectToAction("ReadQuestions", "QA");
        }


        [HttpGet]
        public IActionResult EditQuestion(int id)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            ViewBag.SaveMessage = "Your entry has been saved.";
            Questions questions = Questions.Read(id);

            return View(questions);
        }


        [HttpPost]
        public IActionResult UpdateQuestion(int id, string username, string title, string detail, string category, string tags)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            ViewBag.SaveMessage = "Your entry has been saved.";
            ViewBag.DeleteMessage = "Your entry has been Deleted.";
            Questions.Update(id, username, title, detail, category, tags);
            return RedirectToAction("ReadQuestions", "QA");
        }


        [HttpGet]
        public IActionResult RemoveQuestion(int id)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            ViewBag.DeleteMessage = "Your entry has been deleted.";
            Thread t = Thread.AssembleThread(id);
            Thread.DeleteThread(t);

            return RedirectToAction("ReadQuestions", "QA");
        }


        [HttpGet]
        public IActionResult RemoveAnswer(int thisID)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];

            Answers a = Answers.Read(thisID);

            int qid = a.QuestionID;
            Answers.Delete(thisID);


            return RedirectToAction("ReadAnswers", "QA", new { id = qid });

        }



        public IActionResult ReadAnswers(int id)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            ViewBag.SaveMessage = "Your answer has been saved";
            ViewBag.DeleteMessage = "Your entry has been Deleted.";
            Thread t = new Thread();
            t.A = Answers.ReadAll(id);
            t.Q = Questions.Read(id);

            return View(t);
        }



        public IActionResult PostAnswer(string username, string detail, int questionID)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            ViewBag.SaveMessage = "Your Answer has been posted.";
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



        public IActionResult UpVoteAnswer(int answerID)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            Answers.UpVoteAnswer(answerID);
            Answers a = Answers.Read(answerID);
            Thread t = Thread.AssembleThread(a.QuestionID);
            return View("ReadAnswers", t);
        }



        public IActionResult DownVoteAnswer(int answerID)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            Answers.DownVoteAnswer(answerID);
            Answers a = Answers.Read(answerID);
            Thread t = Thread.AssembleThread(a.QuestionID);
            return View("ReadAnswers", t);
        }


        [HttpGet]
        public IActionResult EditAnswer(int ID)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            Answers a = Answers.Read(ID);
            ViewBag.ID = a.ID;
            Thread t = Thread.AssembleThread(a.QuestionID);
            return View(t);
        }



        public IActionResult UpdateAnswer(string detail, int ID)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            ViewBag.Message = "Your entry has been saved.";

            Answers a = Answers.Read(ID);
            Answers.Update(a, detail);
            Thread t = Thread.AssembleThread(a.QuestionID);
            return View("ReadAnswers", t );
        }



        public IActionResult SearchQuestions(string Category, string Search)
        {
            ViewBag.username = HttpContext.Request.Cookies["username"];
            List<Questions> q;
            if (Category == "Category")
            {
                q = Questions.SearchCategory(Search);
            }
            else if (Category == "Detail")
            {
                q = Questions.SearchDetail(Search);
            }
            else if (Category == "Title")
            {
                q = Questions.SearchTitle(Search);
            }
            else
            {
                q = Questions.SearchTags(Search);
            }
            return View("ReadQuestions", q);
        }

        public IActionResult CompletionStatus(int ID, int status)
        {

            Questions.MarkQuestionStatus(ID, status);
            List<Questions> QS = Questions.Read();
            return RedirectToAction("ReadQuestions", "QA");
        }

    }
}
