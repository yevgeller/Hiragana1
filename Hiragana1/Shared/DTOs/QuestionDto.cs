using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiragana1.Shared.DTOs
{
    [DebuggerDisplay("Id:{Id};NextId:{NextQuizItemId}")]
    public class QuestionDto
    {
        public int Id { get; set; } = 0;
        public int NextQuizItemId { get; set; } = 0;
        public string? Question { get; set; }

        public string? CorrectAnswer { get; set; }
        public List<string> Answers { get; set; } = new List<string>();

        public int PositionNumber { get; set; } = -1;

        public bool IsCompleteQuizItem()
        {
            return Id > 0 && 
                NextQuizItemId > 0 && 
                !string.IsNullOrEmpty(Question) &&
                !string.IsNullOrEmpty(CorrectAnswer) && 
                Answers.Any() &&
                !Answers.Any(x => string.IsNullOrEmpty(x));
        }

        public bool IsIncompleteQuizItem()
        {
            return !IsCompleteQuizItem();
        }
    }
}
