using Hiragana1.Shared;
using Hiragana1.Shared.DTOs;
using Microsoft.AspNetCore.SignalR.Protocol;
using QuestionnaireService;
using SyllabaryQuizGenerator;

namespace Hiragana1.Server.Services
{
    public interface IQuestionnaireService
    {
        IEnumerable<QuestionDto> GetQuizItems();
        IEnumerable<QuestionDto> GetQuizItems(int q, Hiragana1.Shared.QuizType quizType);
    }
    public class QuestionnaireService : IQuestionnaireService
    {
        public QuestionnaireService()
        {

        }

        public IEnumerable<SyllabaryDTO> GetAllCharacters()
        {
            QuizGenerator gq = new QuizGenerator();

            var result = gq.GetAllSyllabaryCharacters();

            var all = new List<SyllabaryDTO>();

            foreach(SyllabaryCharacter s in result)
            {
                all.Add(new SyllabaryDTO
                {
                    Hiragana = s.Hiragana,
                    Katakana = s.Katakana,
                    Transliteration = s.Transliteration,
                    IsDigraph = s.IsDigraph,
                    IsWithDiacritics = s.IsWithDiacritics,
                    UniqueId = s.UniqueId
                });
            }

            return all;
        }

        public IEnumerable<QuestionDto> GetQuizItems(int q, Shared.QuizType quizType)
        {
            QuizGenerator qg = new QuizGenerator();

            SyllabaryQuizGenerator.QuizType adjustedType = (SyllabaryQuizGenerator.QuizType)Enum.Parse(typeof(SyllabaryQuizGenerator.QuizType), quizType.ToString(), true); ;

            var ret = qg.GenerateQuizItems(q, adjustedType);

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
                    Question = input[i].Question,
                    OrdinalNumber = input[i].OrdinalNumber
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
