using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using System.Data;
using Dapper;

namespace Dapper_Project.Models
{
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

        const string server = "Server=9QP7Q13\\SQLEXPRESS;Database=Slack;user id=sa;password=abc123";

        public static Questions Read(long _id)
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
        
    }
}
