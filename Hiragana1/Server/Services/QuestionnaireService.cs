using Hiragana1.Shared;

namespace Hiragana1.Server.Services
{
    public interface IQuestionnaireService
    {
        IEnumerable<QuestionV1> GetNewQuestionnaire(int numberOfQuestions, QuestionType questionType)
    }
    public class QuestionnaireService
    {
    }
}
