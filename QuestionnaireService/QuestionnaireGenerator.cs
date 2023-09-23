using Hiragana1.Shared;

namespace QuestionnaireService
{
    public class QuestionnaireGenerator
    {

        private List<QuestionV1> hiToKa = new List<QuestionV1>();
        public QuestionnaireGenerator()
        {
                hiToKa.Add(new QuestionV1 { QuestionId=1, QuestionType = QuestionType.HiraganaToKatakana, Question= "あ", CorrectAnswer= "ア" });
        }

        private List<QuestionV1> list = new List<QuestionV1> {
             new QuestionV1 {
                 QuestionId = 1,
                Answers = new[] { "one", "two", "three", "four" }.ToList(),
                CorrectAnswer = "one",
                Question = "ichi"
            },
 new QuestionV1 {
     QuestionId = 2,
                Answers = new[] { "one", "two", "three", "four" }.ToList(),
                CorrectAnswer = "two",
                Question = "ni"
            }, new QuestionV1 {
                QuestionId = 3,
                Answers = new[] { "one", "two", "three", "four" }.ToList(),
                CorrectAnswer = "three",
                Question = "ichi"
            }, new QuestionV1 {
                QuestionId = 4,
                Answers = new[] { "one", "two", "three", "four" }.ToList(),
                CorrectAnswer = "one",
                Question = "ichi"
            }, new QuestionV1 {
                QuestionId = 5,
                Answers = new[] { "one", "two", "three", "four" }.ToList(),
                CorrectAnswer = "one",
                Question = "ichi"
            }
        };
        public List<QuestionV1> GetNewTest()
        {


            return new List<QuestionV1>();
        }
    }
}