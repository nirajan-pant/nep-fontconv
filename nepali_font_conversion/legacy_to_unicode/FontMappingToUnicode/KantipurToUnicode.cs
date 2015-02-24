using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nepali_Font_Converter.NormalFontToUnicode.FontMappingToUnicode
{
    class KantipurToUnicode
    {
        public String convertKantipurToUnicode(String kantipurText)
        {
            kantipurText = kantipurText + ("   ");
            String output = "";
            //SingleCharLetter[] is a array of single letter of Preeti font that is complete by itself e.g. numerics, a, i, u ,e, ka, kha, .....
            String[] kantipurNumerics = { ")", "!", "@", "#", "$", "%", "^", "&", "*", "(" };
            String[] kantipurPurnaAkshar ={"c", "O", "p", "C", "P", "s", "v", "u", "3", "ª", "r", "5", "h", "´", "`", "6", "7", "8", "9",
            "t", "y", "b", "w", "g", "k", "˚", "a", "e", "d", "o", "/", "©", "®", "µ", "Â", "™", "∂", "∕", "n", "j", "z", "È", ";", "x", "Ô", "q", "1"};
            String[] kantipurAadhaAkshar ={"S", "V", "U", "£", "R", "H", "¤", "Σ", "∆", "√", "‰", "~", "0", "T", "Œ", "Y", "W", "G", "K", "º",
            "Î", "Ï", "A", "E", "D", "Ø", "ø", "N", "J", "Z", "˘", "i", ":", "≈", "I", "œ", "¡"};
            String[] kantipurCompoundAkshar = { "Í", "◊", "¨", "Ë", "‹", "§", "", "¶", "•", "°", "Q", "2", "4", "¢", "ß", "B", "å", "„", "Ì", "?", "¿", ">", "X" };
            //String []unicodeNumerics={"०", "१", "२", "३", "४", "५", "६", "७", "८", "९"};
            String[] unicodePurnaAkshar ={"अ", "इ", "उ", "ऋ", "ए", "क", "ख", "ग", "घ", "ङ", "च", "छ", "ज", "झ", "ञ", "ट", "ठ", "ड", "ढ", "त", "थ", "द",
            "ध", "न", "प", "फ", "ब", "भ", "म", "य", "र", "र", "र", "र", "र", "र", "र", "र", "ल", "व", "श", "ष", "स", "ह", "क्ष", "त्र", "ज्ञ"};
            String[] unicodeAadhaAkshar ={"क्", "ख्", "ग्", "घ्", "च्", "ज्", "झ्", "झ्", "झ्", "झ्", "झ्", "ञ्", "ण्", "त्", "त्त्", "थ्", "ध्", "न्", "प्",
            "फ्", "फ्", "फ्", "ब्", "भ्", "म्", "्य", "य्", "ल्", "व्", "श्", "श्", "ष्", "स्", "ह्", "क्ष्", "त्र्", "ज्ञ्"};
            String[] unicodeCompoundAkshar = { "ङ्क", "ङ्ख", "ङ्ग", "ङ्ग", "ङ्घ", "ट्ट", "ट्ठ", "ठ्ठ", "ड्ड", "ड्ढ", "त्त", "द्द", "द्ध", "द्ध", "द्म", "द्य", "द्व", "ध्र", "न्न", "रु", "रू", "श्र", "हृ" };
            //compositeCharLetter[] is the array of letter that are formed by combining two or more char symbols of Preeti font ef ksha, sha, aa, ee, ....
            //symbols[] is array of symbols of Preeti font
            String[] symbols ={"'", "\"", "+", ",", "-", ".", "<", "=", "F", "L", "M", "[", "\\", "]", "_", "f", "l", "{", "|", "}", "¥", "«", "±", "Æ",
            "Ú", "æ", "ç", "÷", "˜", "π", "–", "—", "‘", "“", "†", "…", "›", "∞", "≠", "≤", "¬", "≥", "Ò", "ý"};
            String[] symbolsUnicode ={"ु", "ू", "ं", ",", "(", "।", "?", ".", "ा", "ी", ":", "ृ", "्", "े", ")", "ा", "ि", "र्", "्र", "ै",
        "र्‍", "्र", "+", "”", "’", "“", "ॐ", "/", "ऽ", "!", "-", "—", "ॅ", "ँ", "!", "‘", "ऽ", "%",  "=", ";", "…", "़", "…", ""};
            //"र्‍" zero width joiner also concataned
            output = new F2UConversion().convertFontToUnicode("kantipur", kantipurText, kantipurNumerics, kantipurPurnaAkshar,
                    kantipurAadhaAkshar, kantipurCompoundAkshar, symbols, unicodePurnaAkshar, unicodeAadhaAkshar, unicodeCompoundAkshar, symbolsUnicode);
            return output;
        }
    }
}
