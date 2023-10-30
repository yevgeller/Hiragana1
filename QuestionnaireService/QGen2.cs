using SyllabaryQuizGenerator;

namespace QuestionnaireService
{
    public class QGen2      
    {
        public List<QuizItem> GetQuizItems()
        {
            QuizGenerator qg = new QuizGenerator();
            return qg.GenerateQuizItems(10);

        }
    }
}
