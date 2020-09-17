using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using System.Data;
using Dapper;
using Microsoft.EntityFrameworkCore.Internal;

namespace Dapper_Project.Models
{
    [Table("Answers")]
    public class Answers
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Detail { get; set; }
        public int QuestionID { get; set; }
        //^Foreign Key from Questions
        public string Posted { get; set; }
        public int UpVotes { get; set; }


        const string server = "Server=9QP7Q13\\SQLEXPRESS;Database=Slack;user id=sa;password=abc123";

        public static Answers Read(int _id)
        {
            IDbConnection db = new SqlConnection(server);
            Answers A = db.Get<Answers>(_id);
            return A;
        }

        public static List<Answers> ReadAll(long Qid)
        {
            IDbConnection db = new SqlConnection(server);
            List<Answers> A = db.Query<Answers>($"select * from [Answers] where Questionid = {Qid} ORDER BY Upvotes desc").AsList<Answers>();

            return A;
        }

        public static void Create(string username, string detail, int questionID)
        {
            IDbConnection db = new SqlConnection(server);
            Answers answers = new Answers()
            {
                Username = username,
                Detail = detail,
                QuestionID = questionID,
                Posted = DateTime.Now.ToString(),
                UpVotes = 0
            };

            db.Insert(answers);
        }

        public static void Update(string username, string detail, int questionID)
        {
            IDbConnection db = new SqlConnection(server);
            Answers answers = new Answers()
            {
                Username = username,
                Detail = detail,
                QuestionID = questionID,
                Posted = $"Edited at {DateTime.Now}"
            };

            db.Update(answers);
        }

        public static void Delete(int id)
        {
            IDbConnection db = new SqlConnection(server);
            db.Delete(new Answers { ID = id });

        }


        public static void UpVoteAnswer(int answerID)
        {
            Answers a = Answers.Read(answerID);
            a.UpVotes = a.UpVotes + 1;
            IDbConnection db = new SqlConnection(server);
            db.Update(a);
        }
        public static void DownVoteAnswer(int answerID)
        {
            Answers a = Answers.Read(answerID);
            a.UpVotes = a.UpVotes - 1;
            IDbConnection db = new SqlConnection(server);
            db.Update(a);
        }
    }
}
