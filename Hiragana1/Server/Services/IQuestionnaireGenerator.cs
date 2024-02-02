using SyllabaryQuizGenerator;

namespace Hiragana1.Server.Services
{
    public interface IQuestionnaireGenerator
    {
        public List<SyllabaryQuizGenerator.QuizItem> GenerateQuizItems();
        public List<SyllabaryQuizGenerator.QuizItem> GenerateQuizItems(int number, QuizType quizType, int numberOfPossibleAnswers);
        public List<SyllabaryQuizGenerator.SyllabaryCharacter> GetAllSyllabaryCharacters();
    }
}
