using Hiragana1.Shared;
using QuestionnaireService;

namespace Hiragana1.Server.Services
{
    public interface IQuestionnaireService
    {
        IEnumerable<QuestionV1> GetNewQuestionnaire(int numberOfQuestions, QuestionnaireType questionType);
    }
    public class QuestionnaireService : IQuestionnaireService
    {
        public QuestionnaireService()
        {
            
        }

        public IEnumerable<QuestionV1> GetNewQuestionnaire(int numberOfQuestions, QuestionnaireType questionType)
        {
            QuestionnaireGenerator generator = new QuestionnaireGenerator();
            return generator.GetNewTest2(testType: QuestionnaireType.EnglishToHiragana, 5);
        }
    }
}
