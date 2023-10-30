using Hiragana1.Shared;
using Hiragana1.Shared.DTOs;
using Microsoft.AspNetCore.SignalR.Protocol;
using QuestionnaireService;
using SyllabaryQuizGenerator;

namespace Hiragana1.Server.Services
{
    public interface IQuestionnaireService
    {
        //IEnumerable<QuestionV1> GetNewQuestionnaire(int numberOfQuestions, QuizType questionType);
        IEnumerable<QuestionDto> GetQuizItems();
    }
    public class QuestionnaireService : IQuestionnaireService
    {
        public QuestionnaireService()
        {
            
        }

        //public IEnumerable<QuestionV1> GetNewQuestionnaire(int numberOfQuestions, QuizType questionType)
        //{
        //    QuestionnaireGenerator generator = new QuestionnaireGenerator();
        //    return generator.GetNewTest2(testType: QuizType.EnglishToHiragana, 5);
        //}

        public IEnumerable<QuestionDto> GetQuizItems()
        {
            QuizGenerator qg = new QuizGenerator();
            var ret = qg.GenerateQuizItems(10);

            List<QuestionDto> items = new List<QuestionDto>();
                        
            for(int i=0; i< items.Count; i++)
            {
                items.Add(new QuestionDto { 
                    PositionNumber = i + 1,
                    Id = items[i].Id, 
                    Answers = items[i].Answers,
                    CorrectAnswer = items[i].CorrectAnswer, 
                    NextQuizItemId = items[i].NextQuizItemId, 
                    Question = items[i].Question 
                });
            }

            return items;
        }
    }
}
