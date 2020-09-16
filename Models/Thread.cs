using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper_Project.Models
{
    public class Thread
    {
        public Questions Q { get; set; }

        public List<Answers> A { get; set; }

        public static Thread AssembleThread(int  id)
        {
            Thread t = new Thread();
            t.A = Answers.ReadAll(id);
            t.Q = Questions.Read(id);
            return t;
        }

        public static void DeleteThread(Thread it)
        {
            foreach (Answers ans in it.A)
            {
                Answers.Delete(ans.ID);
            }

            Questions.Delete(it.Q.ID);

        }
    }
}
