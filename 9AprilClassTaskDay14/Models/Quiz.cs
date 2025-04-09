using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9AprilClassTaskDay14.Models
{
    class Quiz:BaseEntity
    {

        public string Name {  get; set; }
        public List<Question> Questions { get; set; }

        public static int _count { get; set; } = 0;
        public Quiz(string name, List<Question> questions):base(_count++)
        {
            Name = name;
            Questions = questions;
        }
    }
}
