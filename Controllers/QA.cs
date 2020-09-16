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
            List<Questions> QS = Questions.Read();
            return View(QS);
        }

        public IActionResult AskQuestion()
        {
            return View();
        }

        public IActionResult AddQuestion(string username, string title, string detail, string category, string tags)
        {
            Questions.Create(username, title, detail, category, tags);

            return RedirectToAction("ReadQuestions", "QA");
            //return Content($"{tags}");
        }

        public IActionResult EditQuestion(long id)
        {
            Questions questions = Questions.Read(id);


            return View(questions);
        }

        public IActionResult UpdateQuestion(int id, string username, string title, string detail, string category, string tags)
        {
            ViewBag.Message = "Your entry has been saved.";
            Questions.Update(id, username, title, detail, category, tags);
            return RedirectToAction("ReadQuestions", "QA");
        }

        public IActionResult RemoveQuestion(int id)
        {
            Questions.Delete(id);

            return RedirectToAction("ReadQuestions", "QA");
        }

        public IActionResult RemoveAnswer(int id)
        {
            Answers.Delete(id);

            return RedirectToAction("ReadAnswers", "QA");

        }

        public IActionResult ReadAnswers(int id)
        {
            Thread t = new Thread();
            t.A = Answers.ReadAll(id);
            t.Q = Questions.Read(id);

            return View(t);
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
