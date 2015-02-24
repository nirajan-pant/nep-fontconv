using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nepali_Font_Converter.NormalFontToUnicode.CharacterReposition
{
    class RepositionIkarF2U
    {
        public String reposIkar(String text)
        {
            //MessageBox.show(text);
            String reposTextPart1 = "";
            String reposTextPart2 = text;
            int k = 0;
            for (k = 0; k < reposTextPart2.Length; k++)
            {
                //MessageBox.show("for loop k"+k);
                int i = 2, j = 0;
                if (reposTextPart2[k].CompareTo('ि')==0)
                {
                    while ((j = k + i) < reposTextPart2.Length)
                    {
                        if (reposTextPart2[k + i].CompareTo('्')==0)
                        {
                            i = i + 2;
                        }
                        else
                        {
                            break;
                        }
                    }
                    //MessageBox.show("out of while k="+k+" j="+j);
                    String str = reposTextPart2.Substring(0, k);
                    //MessageBox.show(str);
                    String str1 = reposTextPart2.Substring(k + 1, j-k-1);
                    //MessageBox.show(str1);
                    String str2 = reposTextPart2.Substring(j);
                    //MessageBox.show(null, str2);
                    //MessageBox.show(str+"    "+str1+"    "+str2);
                    reposTextPart1 = reposTextPart1 + str + str1 + ("ि");
                    reposTextPart2 = str2;
                    k = -1;
                    //MessageBox.show("k=0 executed.");
                }
            }
            return reposTextPart1 + (reposTextPart2);
        } 
    }
}
