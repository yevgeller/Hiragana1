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

        public List<QuestionV1> GetNewTest2(QuestionType testType, int numberOfQuestions) {
            return new List<QuestionV1>();
        }
    }
}