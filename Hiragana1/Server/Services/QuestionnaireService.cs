using Hiragana1.Shared;
using Hiragana1.Shared.DTOs;
using QuestionnaireService;
using SyllabaryQuizGenerator;

namespace Hiragana1.Server.Services
{
    public interface IQuestionnaireService
    {
        //IEnumerable<QuestionV1> GetNewQuestionnaire(int numberOfQuestions, QuestionnaireType questionType);
        IEnumerable<QuestionDto> GetQuizItems();
    }
    public class QuestionnaireService : IQuestionnaireService
    {
        public QuestionnaireService()
        {
            
        }

        //public IEnumerable<QuestionV1> GetNewQuestionnaire(int numberOfQuestions, QuestionnaireType questionType)
        //{
        //    QuestionnaireGenerator generator = new QuestionnaireGenerator();
        //    return generator.GetNewTest2(testType: QuestionnaireType.EnglishToHiragana, 5);
        //}

        public IEnumerable<QuestionDto> GetQuizItems()
        {
            QuizGenerator qg = new QuizGenerator();
            var ret = qg.GenerateQuizItems(10);

            List<QuestionDto> items = new List<QuestionDto>();
            foreach (var item in ret)
            {
                items.Add(new QuestionDto { 
                    Id = item.Id, 
                    Answers = item.Answers,
                    CorrectAnswer = item.CorrectAnswer, 
                    NextQuizItemId = item.NextQuizItemId, 
                    Question = item.Question 
                });
            }

            return items;
        }
    }
}
