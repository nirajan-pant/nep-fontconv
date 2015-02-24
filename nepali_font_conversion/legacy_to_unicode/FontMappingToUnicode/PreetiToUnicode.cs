using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nepali_Font_Converter.NormalFontToUnicode.FontMappingToUnicode
{
    class PreetiToUnicode
    {
        public String convertPreetiToUnicode(String preetiText)
        {
            preetiText = preetiText + ("   ");
            String output = "";
            //SingleCharLetter[] is a array of single letter of Preeti font that is complete by itself e.g. numerics, a, i, u ,e, ka, kha, .....
            String[] preetiNumerics = { ")", "!", "@", "#", "$", "%", "^", "&", "*", "(" };
            String[] preetiPurnaAkshar ={"c", "O", "p", "C", "P", "s", "v", "u", "3", "ª", "r", "5", "h", "´", "`", "6",
            "7", "8", "9", "t", "y", "b", "w", "g", "k", "a", "e", "d", "o", "/", "n", "j", "z", "i", ";", "x", "I", "q", "1"};
            String[] preetiAadhaAkshar ={"S", "V", "U", "£", "R", "H", "‰", "~", "0", "T", "Y", "W", "G", "K", "ˆ", "A", "E", "D", "Ø", "N",
            "J", "Z", ":", "X", "¡"};
            String[] preetiCompoundAkshar = { "2", "4", "B", "ß", "å", "›", "Å", "Í", "Î", "Ë", "‹", "•", "§", "Ý", "¶", "°", ">", "„", "Q", "q", "?", "¿", "Ì" };
            String[] unicodePurnaAkshar ={"अ", "इ", "उ", "ऋ", "ए", "क", "ख", "ग", "घ", "ङ", "च", "छ", "ज", "झ", "ञ", "ट", "ठ", "ड", "ढ", "त", 
            "थ", "द", "ध", "न", "प", "ब", "भ", "म", "य", "र", "ल", "व", "श", "ष्", "स", "ह", "क्ष्", "त्र", "ज्ञ"};
            String[] unicodeAadhaAkshar ={"क्", "ख्", "ग्", "घ्", "च्", "ज्", "झ्", "ञ्", "ण्", "त्", "थ्", "ध्", "न्", "प्", "फ्", "ब्", "भ्", "म्", "्य", "ल्",
            "व्", "श्", "स्", "ह्", "ज्ञ्"};
            String[] unicodeCompoundAkshar = { "द्द", "द्ध", "द्य", "द्म", "द्व", "द्र", "हृ", "ङ्क", "ङ्ख", "ङ्ग", "ङ्घ", "ड्ड", "ट्ट", "ट्ठ", "ठ्ठ", "ड्ढ", "श्र", "ध्र", "त्त", "त्र", "रु", "रू", "न्न" };
            //compositeCharLetter[] is the array of letter that are formed by combining two or more char symbols of Preeti font ef ksha, sha, aa, ee, ....
            //symbols[] is array of symbols of Preeti font
            String[] symbols ={"'", "\"", "f", "l", "L" ,"+", ",", "-", ".", "<", "=", "F", "M", "[", "\\", "]", "_", "f", "{", "|", "}", "¥", 
            "«", "±", "Æ", "Ö", "Ù", "…", "Ú",	"Û", "Ü", "æ", "ç", "÷", "˜", "–", "—", "‘", "Þ"};
            String[] symbolsUnicode ={"ु", "ू", "ा", "ि", "ी", "ं", ",", "(", "।", "?", ".", "ँ", ":", "ृ", "्", "े", ")", "ा", "र्", "्र",
            "ै", "र्", "्र", "+", "”", "=", ";", "‘", "’", "!", "%", "“", "ॐ", "/", "ऽ", "-", "—", "ॅ", "़"};
            //"र्‍" zero width joiner also concataned
            output = new F2UConversion().convertFontToUnicode("preeti", preetiText, preetiNumerics, preetiPurnaAkshar,
                    preetiAadhaAkshar, preetiCompoundAkshar, symbols, unicodePurnaAkshar, unicodeAadhaAkshar, unicodeCompoundAkshar, symbolsUnicode);
            return output;
        }
    }
}
