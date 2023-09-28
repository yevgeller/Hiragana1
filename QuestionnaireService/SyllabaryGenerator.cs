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
        //string hiragana = "    げ こ ご さ ざ し じ す ず せ ぜ そ ぞ た だ ち ぢ っ つ づ て で と ど な に ぬ ね の は ば ぱ ひ び ぴ ふ ぶ ぷ へ べ ぺ ほ ぼ ぽ ま み む め も ゃ や ゅ ゆ ょ よ ら り る れ ろ ゎ わ ゐ ゑ を ん ゔ ゕ ゖ゛゜ゝゞゟ";
        //string katakana = "    ゲ コ ゴ サ ザ シ ジ ス ズ セ ゼ ソ ゾ タ ダ チ ヂ ッ ツ ヅ テ デ ト ド ナ ニ ヌ ネ ノ ハ バ パ ヒ ビ ピ フ ブ プ ヘ ベ ペ ホ ボ ポ マ ミ ム メ モ ャ ヤ ュ ユ ョ ヨ ラ リ ル レ ロ ヮ ワ ヰ ヱ ヲ ン ヴ ヵ ヶ ヷ ヸ ヹ ヺ ・ ー ヽ ヾ ヿ";

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
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });
            //result.Add(new SyllabaryCharacter { Hiragana = "", Katakana = "", Transliteration = "" });

            return result;
        }
    }
}
