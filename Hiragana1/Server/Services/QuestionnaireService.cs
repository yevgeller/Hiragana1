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
        IEnumerable<QuestionDto> GetQuizItems(int q, Hiragana1.Shared.QuizType quizType);
    }
    public class QuestionnaireService : IQuestionnaireService
    {
        public QuestionnaireService()
        {

        }

        public IEnumerable<QuestionDto> GetQuizItems(int q, Shared.QuizType quizType)
        {
            QuizGenerator qg = new QuizGenerator();
            (Colors)System.Enum.Parse(typeof(Colors), "Green");
             SyllabaryQuizGenerator.QuizType adjustedType = (SyllabaryQuizGenerator.QuizType)Enum.Parse(typeof(SyllabaryQuizGenerator.QuizType), quizType.ToString()); ;
            quizType;

            //var ret = qg.GenerateQuizItems(q, adjustedType);
            var ret = qg.GenerateQuizItems(q);
            return NormalizeQuizItems(ret);
        }

        private List<QuestionDto> NormalizeQuizItems(List<QuizItem> input)
        {
            List<QuestionDto> items = new List<QuestionDto>();

            for (int i = 0; i < input.Count; i++)
            {
                items.Add(new QuestionDto
                {
                    PositionNumber = i + 1,
                    Id = input[i].Id,
                    Answers = input[i].Answers,
                    CorrectAnswer = input[i].CorrectAnswer,
                    NextQuizItemId = input[i].NextQuizItemId,
                    Question = input[i].Question
                });
            }

            return items;
        }
        
        public IEnumerable<QuestionDto> GetQuizItems()
        {
            QuizGenerator qg = new QuizGenerator();
            var ret = qg.GenerateQuizItems(3);

            return NormalizeQuizItems(ret);
        }
    }
}
   //public IEnumerable<QuestionV1> GetNewQuestionnaire(int numberOfQuestions, QuizType questionType)
        //{
        //    QuestionnaireGenerator generator = new QuestionnaireGenerator();
        //    return generator.GetNewTest2(testType: QuizType.EnglishToHiragana, 5);
        //}
