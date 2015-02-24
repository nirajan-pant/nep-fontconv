using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nepali_Font_Converter.NormalFontToUnicode.FontMappingToUnicode
{
    class F2UConversion
    {
        public String convertFontToUnicode(String font, String fText, String[] fNum, String[] fPA, String[] fAA, String[] fCA, String[] fS, String[] uPA, String[] uAA, String[] uCA, String[] uS)
        {
            if (font.CompareTo("kantipur")==0)
            {
                fText = fText.Replace("F", "f");
            }
            fText = fText + ("   ");
            String output = "";
            String[] unicodeNumerics = { "०", "१", "२", "३", "४", "५", "६", "७", "८", "९" };
            int p = 0;
            String curChar = null;
            while (p < fText.Length)
            {
                curChar = fText[p].ToString();
                try
                {
                    //JOptionPane.showMessageDialog(null, p+"  "+curChar);
                    switch (curChar)
                    {
                        case "c":
                            //JOptionPane.showMessageDialog(null, "case c ..");
                            switch (fText[p + 1].ToString())
                            {
                                case "f":
                                    //JOptionPane.showMessageDialog(null, "case f ..");
                                    switch (fText[p + 2].ToString())
                                    {
                                        case "]":
                                            //JOptionPane.showMessageDialog(null, "case ] ..");
                                            output = output + ("ओ");
                                            p += 3;
                                            break;
                                        case "}":
                                            output = output + ("औ");
                                            p += 3;
                                            break;
                                        default:
                                            output = output + ("आ");
                                            p += 2;
                                            break;
                                    }
                                    break;
                                default:
                                    //JOptionPane.showMessageDialog(null, "c default..");
                                    output = output + ("अ");
                                    p++;
                                    break;
                            }
                            break;
                        case "P":
                            switch (fText[p + 1].ToString())
                            {
                                case "]":
                                    output = output + ("ऐ");
                                    p += 2;
                                    break;
                                default:
                                    output = output + ("ए");
                                    p++;
                                    break;
                            }
                            break;
                        case "p":
                            switch (fText[p + 1].ToString())
                            {
                                case "m":
                                    output = output + ("ऊ");
                                    p += 2;
                                    break;
                                default:
                                    output = output + ("उ");
                                    p++;
                                    break;
                            }
                            break;
                        case "0":
                            switch (fText[p + 1].ToString())
                            {
                                case "f":
                                    output = output + ("ण");
                                    p += 2;
                                    //JOptionPane.showMessageDialog(null, "ण comes");
                                    break;
                                default:
                                    output = output + ("ण्");
                                    p++;
                                    break;
                            }
                            break;
                        case "k":
                            switch (fText[p + 1].ToString())
                            {
                                case "m":
                                    output = output + ("फ");
                                    p += 2;
                                    break;
                                default:
                                    switch (fText[p + 2].ToString())
                                    {
                                        case "m":
                                            output = output + ("फ");
                                            fText = fText.Substring(0, p) + (fText.Substring(p + 1, p + 2-p-1)) + (fText.Substring(p + 3));
                                            p += 2;
                                            break;
                                        default:
                                            output = output + ("प");
                                            p++;
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case "q":
                            switch (fText[p + 1].ToString())
                            {
                                case "m":
                                    output = output + ("क्र");
                                    p += 2;
                                    break;
                                default:
                                    output = output + ("त्र");
                                    p++;
                                    break;
                            }
                            break;
                        case "Q":
                            switch (fText[p + 1].ToString())
                            {
                                case "m":
                                    output = output + ("क्त");
                                    p += 2;
                                    break;
                                default:
                                    output = output + ("त्त");
                                    p++;
                                    break;
                            }
                            break;
                        case "e":
                            switch (fText[p + 1].ToString())
                            {
                                case "m":
                                    output = output + ("झ");
                                    p += 2;
                                    break;
                                default:
                                    switch (fText[p + 2].ToString())
                                    {
                                        case "m":
                                            output = output + ("झ");
                                            fText = fText.Substring(0, p) + (fText.Substring(p + 1, p + 2-p-1)) + (fText.Substring(p + 3));
                                            p += 2;
                                            break;
                                        default:
                                            output = output + ("भ");
                                            p++;
                                            break;
                                    }
                                    break;
                            }

                            break;
                        case "i":
                            switch (fText[p + 1].ToString())
                            {
                                case "f":
                                    output = output + ("ष");
                                    p += 2;
                                    break;
                                default:
                                    output = output + ("ष्");
                                    p++;
                                    break;
                            }
                            break;
                        case "I":
                            switch (fText[p + 1].ToString())
                            {
                                case "f":
                                    output = output + ("क्ष");
                                    p += 2;
                                    break;
                                default:
                                    output = output + ("क्ष्");
                                    p++;
                                    break;
                            }
                            break;
                        case "f":
                            //JOptionPane.showMessageDialog(null, "case f ..");
                            switch (fText[p + 1].ToString())
                            {
                                case "]":
                                    //JOptionPane.showMessageDialog(null, "case ] ..");
                                    output = output + ("ो");
                                    p += 2;
                                    break;
                                case "}":
                                    output = output + ("ौ");
                                    p += 2;
                                    break;
                                default:
                                    output = output + ("ा");
                                    p += 1;
                                    break;
                            }
                            break;
                        default:
                            if (fNum.Contains(curChar))
                            {
                                int pos = Array.IndexOf(fNum, curChar);
                                output = output + unicodeNumerics[pos];
                                p++;
                            }
                            else if (fS.Contains(curChar))
                            {
                                int pos = Array.IndexOf(fS, curChar);
                                output = output + uS[pos];
                                p++;
                            }
                            else if (fPA.Contains(curChar))
                            {
                                int pos = Array.IndexOf(fPA, curChar);
                                output = output + uPA[pos];
                                p++;
                            }
                            else if (fAA.Contains(curChar))
                            {
                                int pos = Array.IndexOf(fAA, curChar);
                                output = output + uAA[pos];
                                p++;
                            }
                            else if (fCA.Contains(curChar))
                            {
                                int pos = Array.IndexOf(fCA, curChar);
                                output = output + uCA[pos];
                                p++;
                            }
                            else
                            {
                                output = output + curChar;
                                p++;
                            }
                            break;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            return output;
        }  
    }
}
