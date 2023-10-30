using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiragana1.Shared.DTOs
{
    public class SelectedQuizParametersDto
    {
        public QuizType QuizType { get; set; }
        public int NumberOfQuestions { get; set; }
    }
}
