using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9AprilClassTaskDay14.Models
{
    class Question:BaseEntity
    {
        public Question(string text, List<string> variants, int correctVariant):base(_count++)
        {
            Text = text;
            Variants = variants;
            CorrectVariant = correctVariant;
        }

        public static int _count { get; set; } = 1;
        public string Text { get; set; }
        public List<string> Variants { get; set; } = [];
        public int CorrectVariant;
       

        
    }
}
