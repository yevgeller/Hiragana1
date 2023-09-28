using Hiragana1.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionnaireService
{
    public static class SyllabaryGenerator
    {
        //string hiragana = "あ い う え お か が き ぎ く ぐ け げ こ ご さ ざ し じ す ず せ ぜ そ ぞ た だ ち ぢ っ つ づ て で と ど な に ぬ ね の は ば ぱ ひ び ぴ ふ ぶ ぷ へ べ ぺ ほ ぼ ぽ ま み む め も ゃ や ゅ ゆ ょ よ ら り る れ ろ ゎ わ ゐ ゑ を ん ゔ ゕ ゖ゛゜ゝゞゟ";
        //string katakana = "ア イ ウ エ オ カ ガ キ ギ ク グ ケ ゲ コ ゴ サ ザ シ ジ ス ズ セ ゼ ソ ゾ タ ダ チ ヂ ッ ツ ヅ テ デ ト ド ナ ニ ヌ ネ ノ ハ バ パ ヒ ビ ピ フ ブ プ ヘ ベ ペ ホ ボ ポ マ ミ ム メ モ ャ ヤ ュ ユ ョ ヨ ラ リ ル レ ロ ヮ ワ ヰ ヱ ヲ ン ヴ ヵ ヶ ヷ ヸ ヹ ヺ ・ ー ヽ ヾ ヿ";
        //string hiragana = "  ぜ そ ぞ た だ ち ぢ っ つ づ て で と ど な に ぬ ね の は ば ぱ ひ び ぴ ふ ぶ ぷ へ べ ぺ ほ ぼ ぽ ま み む め も ゃ や ゅ ゆ ょ よ ら り る れ ろ ゎ わ ゐ ゑ を ん ゔ ゕ ゖ゛゜ゝゞゟ";
        //string katakana = "  ゼ ソ ゾ タ ダ チ ヂ ッ ツ ヅ テ デ ト ド ナ ニ ヌ ネ ノ ハ バ パ ヒ ビ ピ フ ブ プ ヘ ベ ペ ホ ボ ポ マ ミ ム メ モ ャ ヤ ュ ユ ョ ヨ ラ リ ル レ ロ ヮ ワ ヰ ヱ ヲ ン ヴ ヵ ヶ ヷ ヸ ヹ ヺ ・ ー ヽ ヾ ヿ";

        public static List<SyllabaryCharacter> GetSyllabaryCharacters()
        {
            List<SyllabaryCharacter> result = new List<SyllabaryCharacter> ();
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            result.Add(new SyllabaryCharacter { Hiragana = "あ", Katakana = "ア", Transliteration = "a" });
            result.Add(new SyllabaryCharacter { Hiragana = "い", Katakana = "イ", Transliteration = "i" });
            result.Add(new SyllabaryCharacter { Hiragana = "う", Katakana = "ウ", Transliteration = "u" });
            result.Add(new SyllabaryCharacter { Hiragana = "え", Katakana = "エ", Transliteration = "e" });
            result.Add(new SyllabaryCharacter { Hiragana = "お", Katakana = "オ", Transliteration = "o" });
            //result.Add(new SyllabaryCharacter { Hiragana = "か", Katakana = "カ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "が", Katakana = "ガ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "き", Katakana = "キ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ぎ", Katakana = "ギ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "く", Katakana = "ク", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ぐ", Katakana = "グ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "け", Katakana = "ケ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "げ", Katakana = "ゲ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "こ", Katakana = "コ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ご", Katakana = "ゴ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "さ", Katakana = "サ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ざ", Katakana = "ザ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "し", Katakana = "シ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "じ", Katakana = "ジ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "す", Katakana = "ス", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ず", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ズ", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "せ", Katakana = "セ", Transliteration = "" });

            //result.Add(new SyllabaryCharacter { Hiragana = "ぜ", Katakana = "ゼ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "そ", Katakana = "ソ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ぞ", Katakana = "ゾ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "た", Katakana = "タ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "だ", Katakana = "ダ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ち", Katakana = "チ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ぢ", Katakana = "ヂ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "つ", Katakana = "ツ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "づ", Katakana = "ヅ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "て", Katakana = "テ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "で", Katakana = "デ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "と", Katakana = "ト", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ど", Katakana = "ド", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "な", Katakana = "ナ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "に", Katakana = "ニ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ぬ", Katakana = "ヌ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ね", Katakana = "ネ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "の", Katakana = "ノ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "は", Katakana = "ハ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ば", Katakana = "バ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ぱ", Katakana = "パ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ひ", Katakana = "ヒ", Transliteration = "" }); 
            //result.Add(new SyllabaryCharacter { Hiragana = "び", Katakana = "ビ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ぴ", Katakana = "ピ", Transliteration = "" }); 
            //result.Add(new SyllabaryCharacter { Hiragana = "ふ", Katakana = "フ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ぶ", Katakana = "ブ", Transliteration = "" }); 
            //result.Add(new SyllabaryCharacter { Hiragana = "ぷ", Katakana = "プ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "へ", Katakana = "ヘ", Transliteration = "" }); 
            //result.Add(new SyllabaryCharacter { Hiragana = "べ", Katakana = "ベ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ぺ", Katakana = "ペ", Transliteration = "" }); 
            //result.Add(new SyllabaryCharacter { Hiragana = "ほ", Katakana = "ホ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ぼ", Katakana = "ボ", Transliteration = "" }); 
            //result.Add(new SyllabaryCharacter { Hiragana = "ぽ", Katakana = "ポ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ま", Katakana = "マ", Transliteration = "" }); 
            //result.Add(new SyllabaryCharacter { Hiragana = "み", Katakana = "ミ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "む", Katakana = "ム", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "め", Katakana = "メ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "も", Katakana = "モ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "や", Katakana = "ヤ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ゆ", Katakana = "ユ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "よ", Katakana = "ヨ", Transliteration = "" });


            //string hiragana = "ゃ  ゅ  ょ       ゎ  ゐ ゑ   ゔ ゕ ゖ゛゜ゝゞゟ";
            //string katakana = "ャ  ュ  ョ       ヮ  ヰ ヱ   ヴ ヵ ヶ ヷ ヸ ヹ ヺ ・ ー ヽ ヾ ヿ";

            //result.Add(new SyllabaryCharacter { Hiragana = "ら", Katakana = "ラ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "り", Katakana = "リ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "る", Katakana = "ル", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "れ", Katakana = "レ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "ろ", Katakana = "ロ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "わ", Katakana = "ワ", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "を", Katakana = "ヲ", Transliteration = "" }); 
            //result.Add(new SyllabaryCharacter { Hiragana = "ん", Katakana = "ン", Transliteration = "" });
            return result;
        }
    }
}
