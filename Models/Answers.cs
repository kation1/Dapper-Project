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
    [Table("Answers")]
    public class Answers
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Detail { get; set; }
        public string QuestionID { get; set; }
        //^Foreign Key from Questions

        public string Posted { get; set; }
        //Datetime^
        public string Category { get; set; }
        public int Status { get; set; }



    }
}
