using Hiragana1.Shared;

namespace QuestionnaireService
{

    public class QuestionnaireGenerator
    {
        string hiragana = "あ い う え お か が き ぎ く ぐ け げ こ ご さ ざ し じ す ず せ ぜ そ ぞ た だ ち ぢ っ つ づ て で と ど な に ぬ ね の は ば ぱ ひ び ぴ ふ ぶ ぷ へ べ ぺ ほ ぼ ぽ ま み む め も ゃ や ゅ ゆ ょ よ ら り る れ ろ ゎ わ ゐ ゑ を ん ゔ ゕ ゖ゛゜ゝゞゟ";
        string katakana = "ア イ ウ エ オ カ ガ キ ギ ク グ ケ ゲ コ ゴ サ ザ シ ジ ス ズ セ ゼ ソ ゾ タ ダ チ ヂ ッ ツ ヅ テ デ ト ド ナ ニ ヌ ネ ノ ハ バ パ ヒ ビ ピ フ ブ プ ヘ ベ ペ ホ ボ ポ マ ミ ム メ モ ャ ヤ ュ ユ ョ ヨ ラ リ ル レ ロ ヮ ワ ヰ ヱ ヲ ン ヴ ヵ ヶ ヷ ヸ ヹ ヺ ・ ー ヽ ヾ ヿ";
        private List<QuestionV1> hiToKa = new List<QuestionV1>();
        public QuestionnaireGenerator()
        {
            hiToKa.Add(new QuestionV1 { QuestionId = 1, QuestionType = QuestionnaireType.HiraganaToKatakana, Question = "あ", CorrectAnswer = "ア" });
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

        public IEnumerable<QuestionV1> GetNewTest2(QuestionnaireType testType, int numberOfQuestions)
        {
            var result = new List<QuestionV1>();
            var remaining = numberOfQuestions;

            while (remaining > 0)
            {
                result.Add(GetNextQuestion(testType, result.Select(x=>x.Question), 4));
                //get next question
                //List<QuestionV1> questionCandidates = SyllabaryGenerator.GetSyllabaryCharacters().Where(x=>!)
                remaining--;
            }

            return new List<QuestionV1>();
        }

        private QuestionV1 GetNextQuestion(QuestionnaireType questionType, IEnumerable<string> existingQuestions, int numberOfAnswers)
        {
            var remainingQuestions = SyllabaryGenerator
                .GetSyllabaryCharacters();

            //    EnglishToHiragana = 0,
            //EnglishToKatakana,
            //HiraganaToEnglish,
            //KatakanaToEnglish,
            //HiraganaToKatakana,
            //KatakanaToHiragana,
            //Random
            Random rnd = new Random();
            QuestionV1 q = new QuestionV1();
            q.QuestionType = questionType == QuestionnaireType.Random ? (QuestionnaireType)rnd.Next(5) : questionType;

            switch (q.QuestionType)
            {
                case QuestionnaireType.EnglishToHiragana:
                case QuestionnaireType.EnglishToKatakana:
                    remainingQuestions = remainingQuestions
                        .Where(x => !existingQuestions.Contains(x.Transliteration))
                        .ToList();
                    break;
                case QuestionnaireType.HiraganaToEnglish:
                case QuestionnaireType.HiraganaToKatakana:
                    remainingQuestions = remainingQuestions
                        .Where(x => !existingQuestions.Contains(x.Hiragana))
                        .ToList();
                    break;
                case QuestionnaireType.KatakanaToEnglish:
                case QuestionnaireType.KatakanaToHiragana:
                    remainingQuestions = remainingQuestions
                        .Where(x => !existingQuestions.Contains(x.Katakana))
                        .ToList();
                    break;
                default:
                    break;
            }

            if (!remainingQuestions.Any())
            {
                throw new Exception("no questions found");
            }

            SyllabaryCharacter ch = remainingQuestions[rnd.Next(remainingQuestions.Count)];
            int correctAnswerPosition = rnd.Next(numberOfAnswers - 1);
            switch (q.QuestionType)
            {
                case QuestionnaireType.EnglishToHiragana:
                    q = ProduceQuestion(questionType, ch.Transliteration, ch.Hiragana, numberOfAnswers, remainingQuestions, rnd, correctAnswerPosition);
                    break;
                case QuestionnaireType.EnglishToKatakana:
                    q = new QuestionV1 { QuestionType = questionType, Question = ch.Transliteration, CorrectAnswer = ch.Katakana };
                    break;
                case QuestionnaireType.HiraganaToEnglish:
                    q = new QuestionV1 { QuestionType = questionType, Question = ch.Hiragana, CorrectAnswer = ch.Transliteration };
                    break;
                case QuestionnaireType.HiraganaToKatakana:
                    q = new QuestionV1 { QuestionType = questionType, Question = ch.Hiragana, CorrectAnswer = ch.Katakana };
                    break;
                case QuestionnaireType.KatakanaToEnglish:
                    q = new QuestionV1 { QuestionType = questionType, Question = ch.Katakana, CorrectAnswer = ch.Transliteration };
                    break;
                case QuestionnaireType.KatakanaToHiragana:
                    q = new QuestionV1 { QuestionType = questionType, Question = ch.Katakana, CorrectAnswer = ch.Hiragana };
                    break;
                default:
                    q = new QuestionV1 { QuestionType = questionType, Question = ch.Hiragana, CorrectAnswer = ch.Katakana };
                    break;
            }

            return q;
        }

        private static QuestionV1 ProduceQuestion(QuestionnaireType questionType, string assignment, string correctAnswer, int numberOfAnswers, List<SyllabaryCharacter> remainingQuestions, Random rnd, int correctAnswerPosition)
        {
            var q = new QuestionV1 { QuestionType = questionType, Question = assignment, CorrectAnswer = correctAnswer, Answers = (new string[]{ "","","",""}).ToList() };
            q.Answers[correctAnswerPosition] = q.CorrectAnswer;
            var answerCandidates = SyllabaryGenerator.AllHiraganaCharacters().Where(x => x != q.CorrectAnswer);

            for (int i = 0; i < q.Answers.Count(); i++)
            {
                if (!string.IsNullOrEmpty(q.Answers[i]))
                {
                    var randomSyllable = remainingQuestions[rnd.Next(remainingQuestions.Count)];
                    remainingQuestions.Remove(randomSyllable);
                    q.Answers[i] = randomSyllable.Hiragana;
                }
            }

            return q;
        }
    }
}