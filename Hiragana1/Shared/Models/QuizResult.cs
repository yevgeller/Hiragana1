using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiragana1.Shared.Models
{
    public class QuizResult
    {
        public int NumberOfErrors { get; set; }
        public int NumberOfQuestions { get; set; }
        public QuizType QuizType { get; set; }

        public string ResultString()
        {
            return $"{NumberOfQuestions} {QuizType} questions, {NumberOfErrors} errors";
        }
    
    }


}
