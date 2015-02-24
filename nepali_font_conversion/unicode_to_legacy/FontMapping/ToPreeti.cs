using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nepali_Font_Converter.UnicodeToFont
{
    class ToPreeti
    {
        public String convertToRFont(String uText)
        {
            uText = uText + " ";
            int strLength = uText.Length;
            int p = 0;
            String RFText = "";
            //Initialize different arrays for different symbol lists
            //Arrays for Unicode fonts and kantipur font for replacing letter with corresponding letter
            String[] anka = { "०", "१", "२", "३", "४", "५", "६", "७", "८", "९" };
            String[] uFontSwor = { "अ", "आ", "इ", "ई", "उ", "ऊ", "ऋ", "ए", "ऐ", "ओ", "औ" };
            String[] uFontSworSymb = { "ा", "ि", "ी", "ु", "ू", "ृ", "े", "ै", "ो", "ौ" };
            String[] uFontVyanjan = { "क", "ख", "ग", "घ", "ङ", "च", "छ", "ज", "झ", "ञ", "ट", "ठ", "ड", "ढ", "ण", "त", "थ", "द", "ध", "न", "प", "फ", "ब", "भ", "म", "य", "र", "ल", "व", "श", "ष", "स", "ह" };
            String[] chihna = { "्", "।", "॥", "ँ", "ऽ", "ः", "ं", "ॐ", "\"", "'", ":", ",", "(", ")", "?", ".", "‌+", "“", "”", "‘", "’", "/", "!", "-", "%", "=", ";", "$" };
            String[] PreetiChihna = { "\\", ".", "..", "F", "˜", "M", "+", "ç", "æ", "…", "M", ",", "-", "_", "<", "=", "±", "æ", "Æ", "…", "Ú", "÷", "Û", "–", "Ü", "Ö", "Ù", "‘" };

            String[] PreetiAnka = { ")", "!", "@", "#", "$", "%", "^", "&", "*", "(" };
            String[] PreetiSwor = { "c", "cf", "O", "O{", "p", "pm", "C", "P", "P]", "cf]", "cf}" };
            String[] PreetiSworSymb = { "f", "l", "L", "'", "\"", "[", "]", "}", "f]", "f}" };
            String[] PreetiVyanjan = { "s", "v", "u", "3", "ª", "r", "5", "h", "´", "`", "6", "7", "8", "9", "0f", "t", "y", "b", "w", "g", "k", "km", "a", "e", "d", "o", "/", "n", "j", "z", "if", ";", "x" };
            String[] PreetiAadhaVarn = { "S", "V", "U", "£", "ª\\", "R", "5\\", "H", "‰", "~", "6\\", "7\\", "8\\", "9\\", "0", "T", "Y", "b\\", "W", "G", "K", "ˆ", "A", "E", "D", "o\\", "/\\", "N", "J", "Z", "i", ":", "X" };
            try
            {
                //Check while end of the string
                while (p < strLength)
                {
                    //MessageBox.Show(p+"  "+uText.charAt(p))
                    char letter = uText[p];
                    int pos;
                    String convChar = "";
                    //ckeck whether given string in in array or not and if yes then find the index on that element.
                    if (anka.Contains(letter.ToString()))
                    {
                        pos = Array.IndexOf(anka, letter.ToString());
                        //MessageBox.Show(pos);
                        convChar = PreetiAnka[pos];
                        p++;
                    }
                    //If character belongs to unicode font vyanjan list
                    else if (uFontVyanjan.Contains(letter.ToString()))
                    {
                        pos = Array.IndexOf(uFontVyanjan, letter.ToString());

                        ////MessageBox.Show(uText[p + 1] + "  " + uText[p + 2]);
                        //If the next character to character at position p then check for halanta case    
                        if (uText[p + 1].CompareTo('्') == 0)
                        {
                            switch (uText.ElementAt(p).ToString())
                            {
                                //Conversion of corresponds of क e.g. क्ष, क्त, क्र
                                case "क":
                                    switch (uText.ElementAt(p + 2).ToString())
                                    {
                                        case "ष":
                                            switch (uText.ElementAt(p + 3).ToString())
                                            {
                                                //Conversion of क्ष्
                                                case "\u094D":
                                                    convChar = "I";
                                                    p = p + 4;
                                                    break;
                                                default:
                                                    convChar = "If";
                                                    p = p + 3;
                                                    break;
                                            }
                                            break;
                                        case "त":
                                            convChar = "Qm";
                                            p = p + 3;
                                            break;
                                        case "र":
                                            convChar = "qm";
                                            p = p + 3;
                                            break;
                                        case " ":
                                            convChar = "s\\";
                                            p = p + 2;
                                            break;
                                        default:
                                            convChar = "S";
                                            p += 2;
                                            break;
                                    }
                                    break;
                                //Conversion of corresponds of ङ
                                case "ङ":
                                    switch (uText.ElementAt(p + 2).ToString())
                                    {
                                        case "क":
                                            convChar = "Í";
                                            p += 3;
                                            break;
                                        case "ख":
                                            convChar = "Î";
                                            p += 3;
                                            break;
                                        case "ग":
                                            convChar = "Ë";
                                            p += 3;
                                            break;
                                        case "घ":
                                            convChar = "‹";
                                            p += 3;
                                            break;
                                        case "य":
                                            convChar = "ªØ";
                                            p += 3;
                                            break;
                                        default:
                                            convChar = "ª\\";
                                            p += 2;
                                            break;
                                    }
                                    break;
                                //Conversion of corresponds of छ
                                case "छ":
                                    switch (uText.ElementAt(p + 2).ToString())
                                    {
                                        case "य":
                                            convChar = "5Ø";
                                            p += 3;
                                            break;
                                        default:
                                            convChar = "5\\";
                                            p += 2;
                                            break;
                                    }
                                    break;
                                case "ज":
                                    switch (uText.ElementAt(p + 2).ToString())
                                    {
                                        case "ञ":
                                            convChar = "1";
                                            p += 3;
                                            break;
                                        case " ":
                                            convChar = "h\\";
                                            p = p + 3;
                                            break;
                                        default:
                                            convChar = "H";
                                            p += 2;
                                            break;
                                    }
                                    break;
                                //Conversion of corresponds of ट
                                case "ट":
                                    switch (uText.ElementAt(p + 2).ToString())
                                    {
                                        case "ट":
                                            convChar = "§";
                                            p += 3;
                                            break;
                                        case "ठ":
                                            convChar = "Ý";
                                            p += 3;
                                            break;
                                        case "य":
                                            convChar = "6Ø";
                                            p += 3;
                                            break;
                                        case "र":
                                            convChar = "6«";
                                            p += 3;
                                            break;
                                        default:
                                            convChar = "6\\";
                                            p += 2;
                                            break;
                                    }
                                    break;
                                //Conversion of corresponds of ठ
                                case "ठ":
                                    switch (uText.ElementAt(p + 2).ToString())
                                    {
                                        case "ठ":
                                            convChar = "¶";
                                            p += 3;
                                            break;
                                        case "य":
                                            convChar = "7Ø";
                                            p += 3;
                                            break;
                                        case "र":
                                            convChar = "7«";
                                            p += 3;
                                            break;
                                        default:
                                            convChar = "7\\";
                                            p += 2;
                                            break;
                                    }
                                    break;
                                //Conversion of corresponds of ड
                                case "ड":
                                    switch (uText.ElementAt(p + 2).ToString())
                                    {
                                        case "ड":
                                            convChar = "•";
                                            p += 3;
                                            break;
                                        case "ढ":
                                            convChar = "°";
                                            p += 3;
                                            break;
                                        case "य":
                                            convChar = "8Ø";
                                            p += 3;
                                            break;
                                        case "र":
                                            convChar = "8«";
                                            p += 3;
                                            break;
                                        default:
                                            convChar = "8\\";
                                            p += 2;
                                            break;
                                    }
                                    break;
                                //Conversion of corresponds of ढ
                                case "ढ":
                                    switch (uText.ElementAt(p + 2).ToString())
                                    {
                                        case "य":
                                            convChar = "9Ø";
                                            p += 3;
                                            break;
                                        case "र":
                                            convChar = "9«";
                                            p += 3;
                                            break;
                                        default:
                                            convChar = "9\\";
                                            p += 2;
                                            break;
                                    }
                                    break;
                                //Conversion of corresponds of त
                                case "त":
                                    switch (uText.ElementAt(p + 2).ToString())
                                    {
                                        case "त":
                                            convChar = "Q";
                                            p += 3;
                                            break;
                                        case "र":
                                            convChar = "q";
                                            p += 3;
                                            break;
                                        case " ":
                                            convChar = "t\\";
                                            p += 2;
                                            break;
                                        default:
                                            convChar = "T";
                                            p += 2;
                                            break;
                                    }
                                    break;
                                //Conversion of corresponds of द
                                case "द":
                                    switch (uText.ElementAt(p + 2).ToString())
                                    {
                                        case "द":
                                            convChar = "2";
                                            p += 3;
                                            break;
                                        case "ध":
                                            convChar = "4";
                                            p += 3;
                                            break;
                                        case "म":
                                            convChar = "ß";
                                            p += 3;
                                            break;
                                        case "य":
                                            convChar = "B";
                                            p += 3;
                                            break;
                                        case "र":
                                            convChar = "›";
                                            p += 3;
                                            break;
                                        case "व":
                                            convChar = "å";
                                            p += 3;
                                            break;
                                        default:
                                            convChar = "b\\";
                                            p += 2;
                                            break;
                                    }
                                    break;
                                //Conversion of श्र
                                case "श":
                                    switch (uText.ElementAt(p + 2).ToString())
                                    {
                                        case "र":
                                            convChar = ">";
                                            p += 3;
                                            break;
                                        case " ":
                                            convChar="z\\";
                                            p+=2;
                                            break;
                                        default:
                                            convChar = "Z";
                                            p += 2;
                                            break;
                                    }
                                    break;
                                //Conversion of र to रेफ
                                case "र":
                                    convChar = "{";
                                    p += 2;
                                    break;
                                //Halanta and र् symbol conversion
                                default:
                                    //MessageBox.Show("consonant detected");                                    
                                    switch (uText.ElementAt(p + 1).ToString())
                                    {
                                        case "्":
                                            switch (uText.ElementAt(p + 2).ToString())
                                            {
                                                case " ":
                                                    //MessageBox.Show("space detected");
                                                    convChar = PreetiVyanjan[pos] + ("\\ ");
                                                    p += 3;
                                                    break;
                                                case "र":
                                                    //MessageBox.Show("space detected");
                                                    convChar = PreetiVyanjan[pos] + ("|");
                                                    p += 3;
                                                    break;
                                                default:
                                                    if (uFontVyanjan.Contains(uText.ElementAt(p + 2).ToString()))
                                                    {
                                                        convChar = PreetiAadhaVarn[pos];
                                                        p += 2;
                                                        break;
                                                    }
                                                    else
                                                    {
                                                        convChar = PreetiVyanjan[pos] + ("\\");
                                                        p += 2;
                                                        break;
                                                    }
                                            }
                                            break;
                                    }
                                    break;
                            }
                        }
                        //Conversion of letters with र
                        else if ((uText.ElementAt(p).ToString()).Equals("र"))
                        {
                            switch (uText.ElementAt(p + 1).ToString())
                            {
                                case "ु":
                                    convChar = "?";
                                    p += 2;
                                    break;
                                case "ू":
                                    convChar = "¿";
                                    p += 2;
                                    break;
                                case "्":
                                    convChar = "{";
                                    p += 2;
                                    break;
                                default:
                                    convChar = "/";
                                    p++;
                                    break;
                            }
                        }
                        //Conversion of हृ, ह्
                        else if ((uText.ElementAt(p).ToString()).Equals("ह"))
                        {
                            switch (uText.ElementAt(p + 1).ToString())
                            {
                                case "ृ":
                                    convChar = "Å";
                                    p += 2;
                                    break;
                                case "्":
                                    convChar = "X";
                                    p += 2;
                                    break;
                                default:
                                    convChar = "x";
                                    p++;
                                    break;
                            }
                        }
                        //If no of above condition is satisfied then change letter to corresponding regular font character
                        else
                        {
                            //MessageBox.Show("else condition "+pos);
                            convChar = PreetiVyanjan[pos];
                            p++;
                        }
                    }
                    //Conversion of Swor Akshar
                    else if (uFontSwor.Contains(letter.ToString()))
                    {
                        pos = Array.IndexOf(uFontSwor, letter.ToString());
                        //MessageBox.Show(pos);
                        convChar = PreetiSwor[pos];
                        p++;
                    }
                    //Conversion of Swor Symbols according to corresponding array elements except ि
                    else if (uFontSworSymb.Contains(letter.ToString()))
                    {
                        pos = Array.IndexOf(uFontSworSymb, letter.ToString());
                        //MessageBox.Show(pos);
                        convChar = PreetiSworSymb[pos];
                        p++;
                    }
                    //Conversion of Chihna
                    else if (chihna.Contains(letter.ToString()))
                    {
                        switch (letter.ToString())
                        {
                            //Conversion of Single Quotation with their correct position
                            case "'":
                                if (p > 0 && ((uText[p - 1].CompareTo(' ')) == 0) || (p == 0) || ((uText[p - 1].CompareTo('\n') == 0)))
                                {
                                    convChar = "…";
                                    p++;
                                }
                                else
                                {
                                    convChar = "Ú";
                                    p++;
                                }
                                break;
                            //Conversion of Double Quotation with their proper position
                            case "\"":
                                if (p > 0 && ((uText[p - 1].CompareTo(' ')) == 0) || (p == 0) || ((uText[p - 1].CompareTo('\n') == 0)))
                                {
                                    convChar = "æ";
                                    p++;
                                }
                                else
                                {
                                    convChar = "Æ";
                                    p++;
                                }
                                break;
                            //Convert other symbols according to corresponding array elements
                            default:
                                pos = Array.IndexOf(chihna, letter.ToString());
                                //MessageBox.Show(pos);
                                convChar = PreetiChihna[pos];
                                p++;
                                break;
                        }
                    }
                    //Place all other characters as is that are not listed above
                    else
                    {
                        convChar = letter.ToString();
                        p++;
                    }
                    RFText = RFText + convChar;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            //Return converted text
            return RFText;
        }    
    }
}
