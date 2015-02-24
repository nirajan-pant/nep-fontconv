using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nepali_Font_Converter.NormalFontToUnicode.CharacterReposition
{
    class ReposRephF2U
    {
        public String reposReph(String text)//To reposition REPH
        {
            //MessageBox.show(text);
            String reposTextPart1 = "";
            String reposTextPart2 = text + ("  ");
            String[] uFontSworSymb = { "ा", "ी", "ु", "ू", "ृ", "े", "ै", "ो", "ौ" };
            int k;

            for (k = 0; k < reposTextPart2.Length; k++)
            {
                int i = 2, j = 0;

                //if condition for not to change the position of r with ya
                //character at k+3 is zero width joiner
                if ((reposTextPart2[k].CompareTo('र')==0) && (reposTextPart2[k + 1].CompareTo('्')==0) && (reposTextPart2[k + 2].CompareTo('‍')==0) && reposTextPart2[k + 3].CompareTo('य')==0)
                {
                    k += 4;
                }

                else if ((reposTextPart2[k].CompareTo('र')==0) && (reposTextPart2[k + 1].CompareTo('्')==0))
                {
                    if (uFontSworSymb.Contains(reposTextPart2[k - 1].ToString()))
                    {
                        i++;
                        //MessageBox.show("i="+i);
                    }
                    while ((k - i) >= 0)
                    {
                        if (reposTextPart2[k - i].CompareTo('्')==0)
                        {
                            j = k - i - 1;
                            i = i + 2;
                        }
                        else
                        {
                            j = k - i + 1;
                            break;
                        }
                    }
                    //MessageBox.show("out of while k="+k+" i="+i);
                    String str = reposTextPart2.Substring(0, j);
                    //MessageBox.show(str);
                    String str1 = reposTextPart2.Substring(j, k-j); //Substring(start_index, length)
                    //MessageBox.show(str1);
                    String str2 = reposTextPart2.Substring(k + 2);
                    //MessageBox.show(str2);
                    reposTextPart1 = reposTextPart1 + str + ("र्") + str1;
                    reposTextPart2 = str2;
                    k = 0;
                }
            }
            return ((reposTextPart1 + reposTextPart2).Replace("र्इ", "ई"));
        }   
    }
}
