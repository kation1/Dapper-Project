﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace Dapper_Project.Models
{
    //Data Access Layer
    [Table("Questions")]
    public class Questions
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime Posted { get; set; }
        public string Category { get; set; }
        public string Tags { get; set; }
        public int Status { get; set; }

        //const string server = "Server=9QP7Q13\\SQLEXPRESS;Database=Slack;user id=sa;password=abc123"; // Tyler Database
        const string server = "Server=7RP7Q13\\SQLEXPRESS;Database=Slack;user id=csharp;password=abc123"; //David Database

        public static Questions Read(int _id)
        {
            IDbConnection db = new SqlConnection(server);
            Questions Q = db.Get<Questions>(_id);
            return Q;
        }

        public static List<Questions> Read()
        {
            IDbConnection db = new SqlConnection(server);
            List<Questions> Q = db.GetAll<Questions>().ToList();
            return Q;
        }

        public static void Create (string username, string title, string detail, string category, string tags)
        {
            IDbConnection db = new SqlConnection(server);
            Questions questions = new Questions()
            {
                Username = username,
                Title = title,
                Posted = DateTime.Now,
                Detail = detail,
                Category = category,
                Tags = tags,
                Status = 1
            };

            db.Insert(questions);
        }

        
        public static void Update(int id, string username, string title, string detail, string category, string tags)
        {
            IDbConnection db = new SqlConnection(server);
            Questions questions = new Questions()
            {
                ID = id,
                Username = username,
                Title = title,
                Posted = DateTime.Now,
                Detail = detail,
                Category = category,
                Tags = tags,
                Status = 1
            };

            db.Update(questions);

        }
        
        public static void Delete(int id)
        {
            IDbConnection db = new SqlConnection(server);
            db.Delete( new Questions{ID = id});
            //db.Delete(Answers.Delete(new Answers { ID = id }));
        }

        public static List<Questions> SearchTitle(string search)
        {
            IDbConnection db = new SqlConnection(server);
            List<Questions> Q = db.Query<Questions>($"select * from Questions where Title LIKE '%{search}%'").AsList();

            return Q;
        }

        public static List<Questions> SearchDetail(string search)
        {
            IDbConnection db = new SqlConnection(server);
            List<Questions> Q = db.Query<Questions>($"select * from Questions where Detail LIKE '%{search}%'").AsList();

            return Q;
        }

        public static List<Questions> SearchCategory(string search)
        {
            IDbConnection db = new SqlConnection(server);
            List<Questions> Q = db.Query<Questions>($"select * from Questions where Category LIKE '%{search}%'").AsList();

            return Q;
        }

        public static List<Questions> SearchTags(string search)
        {
            IDbConnection db = new SqlConnection(server);
            List<Questions> Q = db.Query<Questions>($"select * from Questions where Tags LIKE '%{search}%'").AsList();

            return Q;
        }

        public static void MarkQuestionStatus(int ID, int status)
        {
            Questions q = Questions.Read(ID);
            q.Status = status;
            IDbConnection db = new SqlConnection(server);
            db.Update(q);

        }

        //Sort by marked open status or marked closed status
        //Don't allow answers to be posted on questions that are closed.
    }
}
